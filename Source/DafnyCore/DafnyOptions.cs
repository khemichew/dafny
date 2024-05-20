// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.CommandLine;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using JetBrains.Annotations;
using Microsoft.Dafny;
using Microsoft.Dafny.Compilers;
using Microsoft.Dafny.Plugins;
using Bpl = Microsoft.Boogie;
namespace MutateCSharp
{
    internal class Schemata270
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT270");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
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
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_5(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 >= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 > argument2; }
            return argument1 >= argument2;
        }

        internal static bool ReplaceBinExprOp_16(long mutantId, System.PlatformID argument1, System.PlatformID argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, System.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_19(long mutantId, System.Version argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBooleanConstant_2(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_21(long mutantId, System.Version argument1, System.Version argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 5)) { return argument1() || argument2(); }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1() && argument2(); }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1() | argument2(); }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1() & argument2(); }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1() ^ argument2(); }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1() == argument2(); }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1() != argument2(); }
            return argument1() || argument2();
        }

        internal static bool ReplaceBinExprOp_17(long mutantId, System.Diagnostics.Process argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static uint ReplaceNumericConstant_14(long mutantId, uint argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 2)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return 0; }
            return argument1;
        }

        internal static int ReplaceBinExprOp_8(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_20(long mutantId, System.Version argument1, System.Version argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 <= argument2;
        }

        internal static int ReplacePrefixUnaryExprOp_12(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return ++argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return +argument1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return ~argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return --argument1; }
            return ++argument1;
        }

        internal static string ReplaceStringConstant_1(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 5)) { return argument1() & argument2(); }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1() || argument2(); }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1() && argument2(); }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1() | argument2(); }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1() ^ argument2(); }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1() == argument2(); }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1() != argument2(); }
            return argument1() & argument2();
        }

        internal static bool ReplaceBinExprOp_18(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public enum FunctionSyntaxOptions
    {
        Version3,
        Migration3To4,
        ExperimentalTreatUnspecifiedAsGhost,
        ExperimentalTreatUnspecifiedAsCompiled,
        ExperimentalPredicateAlwaysGhost,
        Version4,
    }

    public enum QuantifierSyntaxOptions
    {
        Version3,
        Version4,
    }

    public record Options(IDictionary<Option, object> OptionArguments, IDictionary<Argument, object> Arguments);

    public class DafnyOptions : Bpl.CommandLineOptions
    {

        public string GetPrintPath(string path) => UseBaseNameForFileName ? Path.GetFileName(path) : path;
        public TextWriter ErrorWriter { get; set; }
        public TextReader Input { get; }

        public static readonly DafnyOptions Default = new(TextReader.Null, TextWriter.Null, TextWriter.Null);

        public IList<Uri> CliRootSourceUris = new List<Uri>();

        public DafnyProject DafnyProject { get; set; }

        public static void ParseDefaultFunctionOpacity(Option<CommonOptionBag.DefaultFunctionOpacityOptions> option, Bpl.CommandLineParseState ps, DafnyOptions options)
        {
            if (ps.ConfirmArgumentCount(MutateCSharp.Schemata270.ReplaceNumericConstant_0(1L, 1)))
            {
                if (ps.args[ps.i].Equals(MutateCSharp.Schemata270.ReplaceStringConstant_1(5L, "transparent")))
                {
                    options.Set(option, CommonOptionBag.DefaultFunctionOpacityOptions.Transparent);
                }
                else if (ps.args[ps.i].Equals(MutateCSharp.Schemata270.ReplaceStringConstant_1(6L, "autoRevealDependencies")))
                {
                    options.Set(option, CommonOptionBag.DefaultFunctionOpacityOptions.AutoRevealDependencies);
                }
                else if (ps.args[ps.i].Equals(MutateCSharp.Schemata270.ReplaceStringConstant_1(7L, "opaque")))
                {
                    options.Set(option, CommonOptionBag.DefaultFunctionOpacityOptions.Opaque);
                }
                else
                {
                    InvalidArgumentError(option.Name, ps);
                }
            }
        }

        public void ApplyBinding(Option option)
        {
            if (legacyBindings.ContainsKey(option))
            {
                legacyBindings[option](this, Get(option));
            }
        }

        public T Get<T>(Argument<T> argument)
        {
            return (T)Options.Arguments.GetOrCreate(argument, () => default(T));
        }


        public T Get<T>(Option<T> option)
        {
            return (T)Options.OptionArguments.GetOrCreate(option, () => default(T));
        }

        public object Get(Option option)
        {
            return Options.OptionArguments[option];
        }

        public void SetUntyped(Option option, object value)
        {
            Options.OptionArguments[option] = value;
        }

        public void Set<T>(Option<T> option, T value)
        {
            Options.OptionArguments[option] = value;
        }

        protected override void AddFile(string file, Bpl.CommandLineParseState ps)
        {
            CliRootSourceUris.Add(new Uri(Path.GetFullPath(file)));
            base.AddFile(file, ps);
        }

        private static Dictionary<Option, Action<DafnyOptions, object>> legacyBindings = new();
        public static void RegisterLegacyBinding<T>(Option<T> option, Action<DafnyOptions, T> bind)
        {
            legacyBindings[option] = (options, o) => bind(options, (T)o);
        }

        public static void ParseFileInfo(Option<FileInfo> option, Bpl.CommandLineParseState ps, DafnyOptions options)
        {
            if (ps.ConfirmArgumentCount(MutateCSharp.Schemata270.ReplaceNumericConstant_0(8L, 1)))
            {
                options.Set(option, new FileInfo(ps.args[ps.i]));
            }
        }

        public static void ParseFileInfoElement(Option<IList<FileInfo>> option, Bpl.CommandLineParseState ps, DafnyOptions options)
        {
            var value = (IList<FileInfo>)options.Options.OptionArguments.GetOrCreate(option, () => new List<FileInfo>());
            if (ps.ConfirmArgumentCount(MutateCSharp.Schemata270.ReplaceNumericConstant_0(12L, 1)))
            {
                value.Add(new FileInfo(ps.args[ps.i]));
            }
        }

        public static void ParseString(Option<string> option, Bpl.CommandLineParseState ps, DafnyOptions options)
        {
            if (ps.ConfirmArgumentCount(MutateCSharp.Schemata270.ReplaceNumericConstant_0(16L, 1)))
            {
                options.Set(option, ps.args[ps.i]);
            }
        }

        public static void ParseStringElement(Option<IList<string>> option, Bpl.CommandLineParseState ps, DafnyOptions options)
        {
            var value = (IList<string>)options.Options.OptionArguments.GetOrCreate(option, () => new List<string>());
            if (ps.ConfirmArgumentCount(MutateCSharp.Schemata270.ReplaceNumericConstant_0(20L, 1)))
            {
                value.Add(ps.args[ps.i]);
            }
        }

        public static void ParseImplicitEnable(Option<bool> option, Bpl.CommandLineParseState ps, DafnyOptions options)
        {
            options.Set(option, MutateCSharp.Schemata270.ReplaceBooleanConstant_2(24L, true));
        }

        public static void ParseBoolean(Option<bool> option, Bpl.CommandLineParseState ps, DafnyOptions options)
        {
            int result = MutateCSharp.Schemata270.ReplaceNumericConstant_0(25L, 0);
            if (ps.GetIntArgument(ref result, MutateCSharp.Schemata270.ReplaceNumericConstant_0(29L, 2)))
            {
                options.Set(option, MutateCSharp.Schemata270.ReplaceBinExprOp_3(37L, result, MutateCSharp.Schemata270.ReplaceNumericConstant_0(33L, 1)));
            }
        }

        public static void ParseGeneralTraitsOption(Option<CommonOptionBag.GeneralTraitsOptions> option, Bpl.CommandLineParseState ps, DafnyOptions options)
        {
            if (ps.ConfirmArgumentCount(MutateCSharp.Schemata270.ReplaceNumericConstant_0(42L, 1)))
            {
                switch (ps.args[ps.i])
                {
                    case "legacy":
                        options.Set(option, CommonOptionBag.GeneralTraitsOptions.Legacy);
                        break;
                        break;
                    case "datatype":
                        options.Set(option, CommonOptionBag.GeneralTraitsOptions.Datatype);
                        break;
                        break;
                    case "full":
                        options.Set(option, CommonOptionBag.GeneralTraitsOptions.Full);
                        break;
                        break;
                    default:
                        InvalidArgumentError(option.Name, ps);
                        break;
                        break;
                }
            }
        }

        private static readonly List<LegacyUiForOption> LegacyUis = new();

        public static void RegisterLegacyUi<T>(Option<T> option,
          Action<Option<T>, Bpl.CommandLineParseState, DafnyOptions> parse,
          string category, string legacyName = null, string legacyDescription = null, T defaultValue = default(T), string argumentName = null)
        {
            LegacyUis.Add(new LegacyUiForOption(
              option,
              (state, options) => parse(option, state, options),
              category,
              legacyName ?? option.Name,
              legacyDescription ?? option.Description,
              argumentName ?? option.ArgumentHelpName ?? MutateCSharp.Schemata270.ReplaceStringConstant_1(46L, "value"),
              defaultValue));
        }

        private static DafnyOptions defaultImmutableOptions;
        public static DafnyOptions DefaultImmutableOptions => defaultImmutableOptions ??= CreateUsingOldParser(Console.Out, Console.In);

        public static DafnyOptions CreateUsingOldParser(TextWriter outputWriter, TextReader input = null, params string[] arguments)
        {
            input ??= TextReader.Null;
            var result = new DafnyOptions(input, outputWriter, outputWriter);
            result.Parse(arguments);
            return result;
        }

        public override bool Parse(string[] arguments)
        {
            int i;
            for (i = MutateCSharp.Schemata270.ReplaceNumericConstant_0(47L, 0); MutateCSharp.Schemata270.ReplaceBinExprOp_4(51L, i, arguments.Length); MutateCSharp.Schemata270.ReplacePostfixUnaryExprOp_5(56L, ref i))
            {
                if (MutateCSharp.Schemata270.ReplaceBinExprOp_6(58L, arguments[i], MutateCSharp.Schemata270.ReplaceStringConstant_1(57L, "--args")))
                {
                    break;
                }
            }

            try
            {
                if (MutateCSharp.Schemata270.ReplaceBinExprOp_7(59L, i, arguments.Length))
                {
                    return BaseParse(arguments, MutateCSharp.Schemata270.ReplaceBooleanConstant_2(64L, true));
                }
                MainArgs = arguments.Skip(MutateCSharp.Schemata270.ReplaceBinExprOp_8(69L, i, MutateCSharp.Schemata270.ReplaceNumericConstant_0(65L, 1))).ToList();
                return BaseParse(arguments.Take(i).ToArray(), MutateCSharp.Schemata270.ReplaceBooleanConstant_2(78L, true));
            }
            catch (Exception e)
            {
                ErrorWriter.WriteLine(MutateCSharp.Schemata270.ReplaceStringConstant_1(79L, "Invalid filename: ") + e.Message);
                return MutateCSharp.Schemata270.ReplaceBooleanConstant_2(80L, false);
            }

            return default;
        }

        protected override Bpl.CommandLineParseState InitializeCommandLineParseState(string[] args)
        {
            return new TextWriterParseState(args, ToolName, ErrorWriter);
        }

        public
            /// <summary>
            /// Needed because the Boogie version writes to Console.Error
            /// </summary>
            class TextWriterParseState : Bpl.CommandLineParseState
        {
            private readonly TextWriter errorWriter;

            public TextWriterParseState(string[] args, string toolName, TextWriter errorWriter) : base(args, toolName)
            {
                this.errorWriter = errorWriter;
            }

            public override void Error(string message, params string[] args)
            {
                errorWriter.WriteLine(MutateCSharp.Schemata270.ReplaceStringConstant_1(81L, "{0}: Error: {1}"), ToolName, string.Format(message, args));
                EncounteredErrors = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(82L, true);
            }
        }

        /// <summary>
        /// Customized version of Microsoft.Boogie.CommandLineOptions.Parse
        /// Needed because the Boogie version writes to Console.Error
        /// </summary>
        public bool BaseParse(string[] args, bool allowFile)
        {
            Environment = Environment + MutateCSharp.Schemata270.ReplaceStringConstant_1(83L, "Command Line Options: ") + string.Join(MutateCSharp.Schemata270.ReplaceStringConstant_1(84L, " "), args);
            args = cce.NonNull<string[]>((string[])args.Clone());
            Bpl.CommandLineParseState state;
            for (state = InitializeCommandLineParseState(args); MutateCSharp.Schemata270.ReplaceBinExprOp_4(85L, state.i, args.Length); state.i = state.nextIndex)
            {
                cce.LoopInvariant(state.args == args);
                string file = args[state.i];
                state.s = file.Trim();
                bool flag = MutateCSharp.Schemata270.ReplaceBinExprOp_9(92L, () => state.s.StartsWith(MutateCSharp.Schemata270.ReplaceStringConstant_1(90L, "-")), () => state.s.StartsWith(MutateCSharp.Schemata270.ReplaceStringConstant_1(91L, "/")));
                int length = state.s.IndexOf(':');
                if (MutateCSharp.Schemata270.ReplaceBinExprOp_11(107L, () => MutateCSharp.Schemata270.ReplaceBinExprOp_10(102L, MutateCSharp.Schemata270.ReplaceNumericConstant_0(98L, 0), length), () => flag))
                {
                    state.hasColonArgument = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(113L, true);
                    args[state.i] = state.s.Substring(MutateCSharp.Schemata270.ReplaceBinExprOp_8(118L, length, MutateCSharp.Schemata270.ReplaceNumericConstant_0(114L, 1)));
                    state.s = state.s.Substring(MutateCSharp.Schemata270.ReplaceNumericConstant_0(127L, 0), length);
                }
                else
                {
                    MutateCSharp.Schemata270.ReplacePrefixUnaryExprOp_12(131L, ref state.i);
                    state.hasColonArgument = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(135L, false);
                }
                state.nextIndex = state.i;
                if (flag)
                {
                    if (!ParseOption(state.s.Substring(MutateCSharp.Schemata270.ReplaceNumericConstant_0(136L, 1)), state))
                    {
                        if (MutateCSharp.Schemata270.ReplaceBinExprOp_13(146L, () => MutateCSharp.Schemata270.ReplaceBinExprOp_3(140L, Path.DirectorySeparatorChar, '/'), () => state.s.StartsWith(MutateCSharp.Schemata270.ReplaceStringConstant_1(145L, "/"))))
                        {
                            AddFile(file, state);
                        }
                        else
                        {
                            UnknownSwitch(state);
                        }
                    }
                }
                else if (allowFile)
                {
                    AddFile(file, state);
                }
                else
                {
                    state.Error($"Boogie option '{state.s}' must start with - or /");
                }
            }
            if (state.EncounteredErrors)
            {
                ErrorWriter.WriteLine(MutateCSharp.Schemata270.ReplaceStringConstant_1(152L, "Use /help for available options"));
                return MutateCSharp.Schemata270.ReplaceBooleanConstant_2(153L, false);
            }
            ApplyDefaultOptions();
            return MutateCSharp.Schemata270.ReplaceBooleanConstant_2(154L, true);
        }

        public DafnyOptions(TextReader inputReader, TextWriter outputWriter, TextWriter errorWriter)
          : base(outputWriter, MutateCSharp.Schemata270.ReplaceStringConstant_1(155L, "dafny"), MutateCSharp.Schemata270.ReplaceStringConstant_1(156L, "Dafny program verifier"), new Bpl.ConsolePrinter())
        {
            Input = inputReader;
            ErrorWriter = errorWriter;
            ErrorTrace = MutateCSharp.Schemata270.ReplaceNumericConstant_0(157L, 0);
            Prune = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(161L, true);
            TypeEncodingMethod = Bpl.CoreOptions.TypeEncoding.Arguments;
            NormalizeNames = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(162L, true);
            EmitDebugInformation = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(163L, false);
            Backend = new CsharpBackend(this);
            Printer = new NullPrinter();
        }

        public override string VersionNumber
        {
            get
            {
                return FileVersionInfo
                  .GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
            }
        }

        public Options Options { get; set; } = new(new Dictionary<Option, object>(), new Dictionary<Argument, object>());

        public override string Version
        {
            get { return ToolName + VersionSuffix; }
        }

        public override string VersionSuffix
        {
            get { return MutateCSharp.Schemata270.ReplaceStringConstant_1(164L, " ") + VersionNumber; }
        }

        public bool RunLanguageServer { get; set; }

        public enum DiagnosticsFormats
        {
            PlainText,
            JSON,
        }

        public bool UsingNewCli = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(165L, false);
        public bool UnicodeOutput = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(166L, false);
        public DiagnosticsFormats DiagnosticsFormat = DiagnosticsFormats.PlainText;
        public bool DisallowSoundnessCheating = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(167L, false);
        public int Induction = MutateCSharp.Schemata270.ReplaceNumericConstant_0(168L, 4);
        public int InductionHeuristic = MutateCSharp.Schemata270.ReplaceNumericConstant_0(172L, 6);
        public string DafnyPrelude = null;
        public string DafnyPrintFile = null;
        public bool AllowSourceFolders = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(176L, false);
        public List<string> SourceFolders { get; } = new(); // list of folders, for those commands that permit processing all source files in folders

        public enum ContractTestingMode
        {
            None,
            Externs,
            TestedExterns,
        }

        public PrintModes PrintMode = PrintModes.Everything; // Default to printing everything
        public bool DafnyVerify = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(177L, true);
        public string DafnyPrintResolvedFile = null;
        public List<string> DafnyPrintExportedViews = new List<string>();
        public bool Compile = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(178L, true);
        public List<string> MainArgs = new List<string>();
        public bool FormatCheck = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(179L, false);

        public string CompilerName;
        public IExecutableBackend Backend;
        public bool Verbose = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(180L, true);
        public bool EnforcePrintEffects = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(181L, false);
        public string DafnyPrintCompiledFile = null;
        public string CoverageLegendFile = null;
        public string MainMethod = null;
        public bool ForceCompile = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(182L, false);
        public bool RunAfterCompile = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(183L, false);
        public uint SpillTargetCode = MutateCSharp.Schemata270.ReplaceNumericConstant_14(184L, 0); // [0..4]
        public bool DisallowIncludes = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(187L, false);
        public bool DisallowExterns = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(188L, false);
        public bool AllowExterns => !DisallowExterns;
        public bool DisableNLarith = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(189L, false);
        public int ArithMode = MutateCSharp.Schemata270.ReplaceNumericConstant_0(190L, 1); // [0..10]
        public string AutoReqPrintFile = null;
        public bool ignoreAutoReq = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(194L, false);
        public bool Optimize = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(195L, false);
        public bool AutoTriggers = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(196L, true);
        public bool RewriteFocalPredicates = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(197L, true);
        public bool PrintTooltips = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(198L, false);
        public bool PrintStats = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(199L, false);
        public string MethodsToTest = null;
        public bool DisallowConstructorCaseWithoutParentheses = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(200L, false);
        public bool PrintFunctionCallGraph = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(201L, false);
        public bool WarnShadowing = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(202L, false);
        public FunctionSyntaxOptions FunctionSyntax = FunctionSyntaxOptions.Version4;
        public QuantifierSyntaxOptions QuantifierSyntax = QuantifierSyntaxOptions.Version4;
        public int DefiniteAssignmentLevel = MutateCSharp.Schemata270.ReplaceNumericConstant_0(203L, 1); // [0..5] 2 and 3 have the same effect, 4 turns off an array initialisation check and field initialization check, unless --enforce-determinism is used.
        public HashSet<string> LibraryFiles { get; set; } = new();
        public ContractTestingMode TestContracts = ContractTestingMode.None;

        public bool ForbidNondeterminism { get; set; }

        public int DeprecationNoise = MutateCSharp.Schemata270.ReplaceNumericConstant_0(207L, 1);
        public bool VerifyAllModules = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(211L, false);
        public bool SeparateModuleOutput = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(212L, false);

        public enum IncludesModes
        {
            None,
            Immediate,
            Transitive
        }

        public IncludesModes PrintIncludesMode = IncludesModes.None;
        public int OptimizeResolution = MutateCSharp.Schemata270.ReplaceNumericConstant_0(213L, 2);
        public bool IncludeRuntime = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(217L, true);
        public CommonOptionBag.SystemModuleMode SystemModuleTranslationMode = CommonOptionBag.SystemModuleMode.Omit;
        public bool UseJavadocLikeDocstringRewriter = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(218L, false);
        public bool DisableScopes = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(219L, false);
        public bool UseStdin = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(220L, false);
        public bool FailOnWarnings = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(221L, false);
        [CanBeNull] private TestGenerationOptions testGenOptions = null;
        public bool ExtractCounterexample = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(222L, false);

        public bool ShowProofObligationExpressions = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(223L, false);

        public bool AuditProgram = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(224L, false);

        public static string DefaultZ3Version = MutateCSharp.Schemata270.ReplaceStringConstant_1(225L, "4.12.1");
        // Not directly user-configurable, only recorded once we discover it
        public string SolverIdentifier { get; private set; }
        public Version SolverVersion { get; set; }

        public static readonly ReadOnlyCollection<Plugin> DefaultPlugins =
          new(new[] { SinglePassCodeGenerator.Plugin, InternalDocstringRewritersPluginConfiguration.Plugin });
        private IList<Plugin> cliPluginCache;
        public IList<Plugin> Plugins => cliPluginCache ??= ComputePlugins(AdditionalPlugins, AdditionalPluginArguments);
        public List<Plugin> AdditionalPlugins = new();
        public IList<string> AdditionalPluginArguments = new List<string>();

        public static IList<Plugin> ComputePlugins(List<Plugin> additionalPlugins, IList<string> allArguments)
        {
            var result = new List<Plugin>(DefaultPlugins.Concat(additionalPlugins));
            foreach (var pluginAndArgument in allArguments)
            {
                try
                {
                    var pluginArray = pluginAndArgument.Split(',');
                    var pluginPath = pluginArray[MutateCSharp.Schemata270.ReplaceNumericConstant_0(226L, 0)];
                    var arguments = Array.Empty<string>();
                    if (MutateCSharp.Schemata270.ReplaceBinExprOp_7(234L, pluginArray.Length, MutateCSharp.Schemata270.ReplaceNumericConstant_0(230L, 2)))
                    {
                        // There are no commas in paths, but there can be in arguments
                        var argumentsString = string.Join(',', pluginArray.Skip(MutateCSharp.Schemata270.ReplaceNumericConstant_0(239L, 1)));
                        // Parse arguments, accepting and remove double quotes that isolate long arguments
                        arguments = ParsePluginArguments(argumentsString);
                    }

                    result.Add(AssemblyPlugin.Load(pluginPath, arguments));
                }
                catch (Exception e)
                {
                    result.Add(new ErrorPlugin(pluginAndArgument, e));
                }
            }

            return result;
        }

        private static string[] ParsePluginArguments(string argumentsString)
        {
            var splitter = new Regex(MutateCSharp.Schemata270.ReplaceStringConstant_1(243L, @"""(?<escapedArgument>(?:[^""\\]|\\\\|\\"")*)""|(?<rawArgument>[^ ]+)"));
            var escapedChars = new Regex(MutateCSharp.Schemata270.ReplaceStringConstant_1(244L, @"(?<escapedDoubleQuote>\\"")|\\\\"));
            return splitter.Matches(argumentsString).Select(
              matchResult =>
                matchResult.Groups[MutateCSharp.Schemata270.ReplaceStringConstant_1(245L, "escapedArgument")].Success
                  ? escapedChars.Replace(matchResult.Groups[MutateCSharp.Schemata270.ReplaceStringConstant_1(246L, "escapedArgument")].Value,
                    matchResult2 => matchResult2.Groups[MutateCSharp.Schemata270.ReplaceStringConstant_1(247L, "escapedDoubleQuote")].Success ? MutateCSharp.Schemata270.ReplaceStringConstant_1(248L, "\"") : MutateCSharp.Schemata270.ReplaceStringConstant_1(249L, "\\"))
                  : matchResult.Groups[MutateCSharp.Schemata270.ReplaceStringConstant_1(250L, "rawArgument")].Value
            ).ToArray();
        }

        public static bool TryParseResourceCount(string value, out uint result)
        {
            return uint.TryParse(value, NumberStyles.AllowExponent, null, out result);
        }

        /// <summary>
        /// Automatic shallow-copy constructor
        /// </summary>
        public DafnyOptions(DafnyOptions src, bool useNullWriters = false) : this(
          src.Input, src.OutputWriter, src.ErrorWriter)
        {
            src.CopyTo(this, useNullWriters);
            CliRootSourceUris = new List<Uri>(src.CliRootSourceUris);
            ProverOptions = new List<string>(src.ProverOptions);
            Options = new Options(
              src.Options.OptionArguments.ToDictionary(kv => kv.Key, kv => kv.Value),
              src.Options.Arguments.ToDictionary(kv => kv.Key, kv => kv.Value));
        }

        private void CopyTo(DafnyOptions dst, bool useNullWriters)
        {
            var type = typeof(DafnyOptions);
            while (MutateCSharp.Schemata270.ReplaceBinExprOp_15(251L, type, null))
            {
                var fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                foreach (var fi in fields)
                {
                    var value = fi.GetValue(this);
                    // This hacky code is necessary until we switch to a Boogie version that implements https://github.com/boogie-org/boogie/pull/788
                    if (MutateCSharp.Schemata270.ReplaceBinExprOp_13(252L, () => useNullWriters, () => fi.Name is "<ErrorWriter>k__BackingField" or "<OutputWriter>k__BackingField"))
                    {
                        value = TextWriter.Null;
                    }
                    fi.SetValue(dst, value);
                }
                type = type.BaseType;
            }
        }

        public virtual TestGenerationOptions TestGenOptions =>
          testGenOptions ??= new TestGenerationOptions();

        protected override bool ParseOption(string name, Bpl.CommandLineParseState ps)
        {
            if (ParseDafnySpecificOption(name, ps))
            {
                return MutateCSharp.Schemata270.ReplaceBooleanConstant_2(258L, true);
            }

            foreach (var option in LegacyUis.Where(o => MutateCSharp.Schemata270.ReplaceBinExprOp_6(259L, o.Name, name)))
            {
                option.Parse(ps, this);
                return MutateCSharp.Schemata270.ReplaceBooleanConstant_2(260L, true);
            }

            return ParseBoogieOption(name, ps);
        }

        private bool ParseBoogieOption(string name, Bpl.CommandLineParseState ps)
        {
            return base.ParseOption(name, ps);
        }

        public override string Help => MutateCSharp.Schemata270.ReplaceStringConstant_1(261L, "Use 'dafny --help' to see help for the new Dafny CLI format.\n") +
          LegacyUiForOption.GenerateHelp(base.Help, LegacyUis, MutateCSharp.Schemata270.ReplaceBooleanConstant_2(262L, true));

        protected bool ParseDafnySpecificOption(string name, Bpl.CommandLineParseState ps)
        {
            var args = ps.args; // convenient synonym
            switch (name)
            {

                case "view":
                    if (ps.ConfirmArgumentCount(1))
                    {
                        DafnyPrintExportedViews = args[ps.i].Split(',').ToList();
                    }

                    return true;
                    break;
                case "compile":
                    {
                        int compile = 0;
                        if (ps.GetIntArgument(ref compile, 5))
                        {
                            // convert option to two booleans
                            Compile = compile != 0;
                            ForceCompile = compile == 2 || compile == 4;
                            RunAfterCompile = compile == 3 || compile == 4;
                        }

                        return true;
                    }

                    break;
                case "compileVerbose":
                    {
                        int verbosity = 0;
                        if (ps.GetIntArgument(ref verbosity, 2))
                        {
                            Verbose = verbosity == 1;
                        }

                        return true;
                    }

                    break;
                case "trackPrintEffects":
                    {
                        int printEffects = 0;
                        if (ps.GetIntArgument(ref printEffects, 2))
                        {
                            EnforcePrintEffects = printEffects == 1;
                        }

                        return true;
                    }

                    break;
                case "Main":
                case "main":
                    {
                        if (ps.ConfirmArgumentCount(1))
                        {
                            MainMethod = args[ps.i];
                        }

                        return true;
                    }

                    break;
                case "check":
                    {
                        if (!ps.hasColonArgument || ps.ConfirmArgumentCount(1))
                        {
                            FormatCheck = !ps.hasColonArgument || args[ps.i] == "1";
                        }

                        return true;
                    }

                    break;
                case "dafnyVerify":
                    {
                        int verify = 0;
                        if (ps.GetIntArgument(ref verify, 2))
                        {
                            DafnyVerify = verify != 0; // convert to boolean
                        }

                        return true;
                    }

                    break;
                case "diagnosticsFormat":
                    {
                        if (ps.ConfirmArgumentCount(1))
                        {
                            switch (args[ps.i])
                            {
                                case "json":
                                    Printer = new DafnyJsonConsolePrinter(this);
                                    DiagnosticsFormat = DiagnosticsFormats.JSON;
                                    break;
                                case "text":
                                    Printer = new DafnyConsolePrinter(this);
                                    DiagnosticsFormat = DiagnosticsFormats.PlainText;
                                    break;
                                case var df:
                                    ps.Error($"Unsupported diagnostic format: '{df}'; expecting one of 'json', 'text'.");
                                    break;
                            }
                        }

                        return true;
                    }

                    break;
                case "spillTargetCode":
                    {
                        uint spill = 0;
                        if (ps.GetUnsignedNumericArgument(ref spill, x => true))
                        {
                            SpillTargetCode = spill;
                        }

                        return true;
                    }

                    break;
                case "coverage":
                    {
                        if (ps.ConfirmArgumentCount(1))
                        {
                            CoverageLegendFile = args[ps.i];
                        }

                        return true;
                    }

                    break;
                case "noCheating":
                    {
                        int cheat = 0; // 0 is default, allows cheating
                        if (ps.GetIntArgument(ref cheat, 2))
                        {
                            DisallowSoundnessCheating = cheat == 1;
                        }

                        return true;
                    }

                    break;
                case "induction":
                    ps.GetIntArgument(ref Induction, 5);
                    return true;
                    break;
                case "inductionHeuristic":
                    ps.GetIntArgument(ref InductionHeuristic, 7);
                    return true;
                    break;
                case "noIncludes":
                    DisallowIncludes = true;
                    return true;
                    break;
                case "noExterns":
                    DisallowExterns = true;
                    return true;
                    break;
                case "noNLarith":
                    DisableNLarith = true;
                    return true;
                    break;
                case "arith":
                    {
                        int a = 0;
                        if (ps.GetIntArgument(ref a, 11))
                        {
                            ArithMode = a;
                        }
                        return true;
                    }

                    break;
                case "autoReqPrint":
                    if (ps.ConfirmArgumentCount(1))
                    {
                        AutoReqPrintFile = args[ps.i];
                    }
                    return true;
                    break;
                case "noAutoReq":
                    ignoreAutoReq = true;
                    return true;
                    break;
                case "stats":
                    PrintStats = true;
                    return true;
                    break;
                case "funcCallGraph":
                    PrintFunctionCallGraph = true;
                    return true;
                    break;
                case "warnShadowing":
                    WarnShadowing = true;
                    return true;
                    break;
                case "verifyAllModules":
                    VerifyAllModules = true;
                    return true;
                    break;
                case "emitUncompilableCode":
                    this.Set(CommonOptionBag.EmitUncompilableCode, true);
                    return true;
                    break;
                case "separateModuleOutput":
                    SeparateModuleOutput = true;
                    return true;
                    break;
                case "deprecation":
                    {
                        int d = 1;
                        if (ps.GetIntArgument(ref d, 3))
                        {
                            DeprecationNoise = d;
                        }

                        return true;
                    }

                    break;
                case "functionSyntax":
                    if (ps.ConfirmArgumentCount(1))
                    {
                        if (args[ps.i] == "3")
                        {
                            FunctionSyntax = FunctionSyntaxOptions.Version3;
                        }
                        else if (args[ps.i] == "4")
                        {
                            FunctionSyntax = FunctionSyntaxOptions.Version4;
                        }
                        else if (args[ps.i] == "migration3to4")
                        {
                            FunctionSyntax = FunctionSyntaxOptions.Migration3To4;
                        }
                        else if (args[ps.i] == "experimentalDefaultGhost")
                        {
                            FunctionSyntax = FunctionSyntaxOptions.ExperimentalTreatUnspecifiedAsGhost;
                        }
                        else if (args[ps.i] == "experimentalDefaultCompiled")
                        {
                            FunctionSyntax = FunctionSyntaxOptions.ExperimentalTreatUnspecifiedAsCompiled;
                        }
                        else if (args[ps.i] == "experimentalPredicateAlwaysGhost")
                        {
                            FunctionSyntax = FunctionSyntaxOptions.ExperimentalPredicateAlwaysGhost;
                        }
                        else
                        {
                            InvalidArgumentError(name, ps);
                        }
                    }

                    return true;
                    break;
                case "quantifierSyntax":
                    if (ps.ConfirmArgumentCount(1))
                    {
                        if (args[ps.i] == "3")
                        {
                            QuantifierSyntax = QuantifierSyntaxOptions.Version3;
                        }
                        else if (args[ps.i] == "4")
                        {
                            QuantifierSyntax = QuantifierSyntaxOptions.Version4;
                        }
                        else
                        {
                            InvalidArgumentError(name, ps);
                        }
                    }

                    return true;
                    break;
                case "printTooltips":
                    PrintTooltips = true;
                    return true;
                    break;
                case "warnMissingConstructorParentheses":
                    DisallowConstructorCaseWithoutParentheses = true;
                    return true;
                    break;
                case "autoTriggers":
                    {
                        int autoTriggers = 0;
                        if (ps.GetIntArgument(ref autoTriggers, 2))
                        {
                            AutoTriggers = autoTriggers == 1;
                        }

                        return true;
                    }

                    break;
                case "rewriteFocalPredicates":
                    {
                        int rewriteFocalPredicates = 0;
                        if (ps.GetIntArgument(ref rewriteFocalPredicates, 2))
                        {
                            RewriteFocalPredicates = rewriteFocalPredicates == 1;
                        }

                        return true;
                    }

                    break;
                case "optimize":
                    {
                        Optimize = true;
                        return true;
                    }

                    break;
                case "optimizeResolution":
                    {
                        int d = 2;
                        if (ps.GetIntArgument(ref d, 3))
                        {
                            OptimizeResolution = d;
                        }

                        return true;
                    }

                    break;
                case "definiteAssignment":
                    {
                        int da = 0;
                        if (ps.GetIntArgument(ref da, 5))
                        {
                            DefiniteAssignmentLevel = da;
                        }

                        if (da == 3)
                        {
                            ForbidNondeterminism = true;
                        }

                        return true;
                    }

                    break;
                case "useRuntimeLib":
                    {
                        IncludeRuntime = false;
                        return true;
                    }

                    break;
                case "disableScopes":
                    {
                        DisableScopes = true;
                        return true;
                    }

                    break;
                case "printIncludes":
                    if (ps.ConfirmArgumentCount(1))
                    {
                        if (args[ps.i].Equals("None"))
                        {
                            PrintIncludesMode = IncludesModes.None;
                        }
                        else if (args[ps.i].Equals("Immediate"))
                        {
                            PrintIncludesMode = IncludesModes.Immediate;
                        }
                        else if (args[ps.i].Equals("Transitive"))
                        {
                            PrintIncludesMode = IncludesModes.Transitive;
                        }
                        else
                        {
                            InvalidArgumentError(name, ps);
                        }

                        if (PrintIncludesMode == IncludesModes.Immediate || PrintIncludesMode == IncludesModes.Transitive)
                        {
                            Compile = false;
                            DafnyVerify = false;
                        }
                    }

                    return true;
                    break;
                case "stdin":
                    {
                        UseStdin = true;
                        return true;
                    }

                    break;
                case "warningsAsErrors":
                    FailOnWarnings = true;
                    return true;
                    break;
                case "extractCounterexample":
                    ExtractCounterexample = true;
                    EnhancedErrorMessages = 1;
                    return true;
                    break;
                case "showProofObligationExpressions":
                    ShowProofObligationExpressions = true;
                    return true;
                    break;
                case "testContracts":
                    if (ps.ConfirmArgumentCount(1))
                    {
                        if (args[ps.i].Equals("Externs"))
                        {
                            TestContracts = ContractTestingMode.Externs;
                        }
                        else if (args[ps.i].Equals("TestedExterns"))
                        {
                            TestContracts = ContractTestingMode.TestedExterns;
                        }
                        else
                        {
                            InvalidArgumentError(name, ps);
                        }
                    }
                    return true;
                    break;
            }

            // Defer to superclass
            return base.ParseOption(name, ps);
        }

        private static string[] ParseInnerArguments(string argumentsString)
        {
            var splitter = new Regex(MutateCSharp.Schemata270.ReplaceStringConstant_1(263L, @"""(?<escapedArgument>(?:[^""\\]|\\\\|\\"")*)""|(?<rawArgument>[^ ]+)"));
            var escapedChars = new Regex(MutateCSharp.Schemata270.ReplaceStringConstant_1(264L, @"(?<escapedDoubleQuote>\\"")|\\\\"));
            return splitter.Matches(argumentsString).Select(
              matchResult =>
                matchResult.Groups[MutateCSharp.Schemata270.ReplaceStringConstant_1(265L, "escapedArgument")].Success
                ? escapedChars.Replace(matchResult.Groups[MutateCSharp.Schemata270.ReplaceStringConstant_1(266L, "escapedArgument")].Value,
                  matchResult2 => matchResult2.Groups[MutateCSharp.Schemata270.ReplaceStringConstant_1(267L, "escapedDoubleQuote")].Success ? MutateCSharp.Schemata270.ReplaceStringConstant_1(268L, "\"") : MutateCSharp.Schemata270.ReplaceStringConstant_1(269L, "\\"))
                : matchResult.Groups[MutateCSharp.Schemata270.ReplaceStringConstant_1(270L, "rawArgument")].Value
            ).ToArray();
        }

        public static void InvalidArgumentError(string name, Bpl.CommandLineParseState ps)
        {
            ps.Error(MutateCSharp.Schemata270.ReplaceStringConstant_1(271L, "Invalid argument \"{0}\" to option {1}"), ps.args[ps.i], name);
        }

        public override void ApplyDefaultOptions()
        {
            foreach (var legacyUiOption in LegacyUis)
            {
                if (!Options.OptionArguments.ContainsKey(legacyUiOption.Option))
                {
                    Options.OptionArguments[legacyUiOption.Option] = legacyUiOption.DefaultValue;
                }
                if (legacyBindings.ContainsKey(legacyUiOption.Option))
                {
                    var value = Get(legacyUiOption.Option);
                    legacyBindings[legacyUiOption.Option](this, value);
                }
            }

            ApplyDefaultOptionsWithoutSettingsDefault();
        }

        public void ApplyDefaultOptionsWithoutSettingsDefault()
        {
            base.ApplyDefaultOptions();

            Backend ??= new CsharpBackend(this);
            // Ask Boogie to perform abstract interpretation
            UseAbstractInterpretation = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(272L, true);
            Ai.J_Intervals = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(273L, true);
        }

        public bool IsUsingZ3()
        {
            return !ProverOptions.Any(x => MutateCSharp.Schemata270.ReplaceBinExprOp_13(276L, () => x.StartsWith(MutateCSharp.Schemata270.ReplaceStringConstant_1(274L, "SOLVER=")), () => !x.EndsWith(MutateCSharp.Schemata270.ReplaceStringConstant_1(275L, "=z3"))));
        }

        public void ProcessSolverOptions(ErrorReporter errorReporter, IToken token)
        {
            if (IsUsingZ3())
            {
                var z3Version = SetZ3ExecutablePath(errorReporter, token);
                SetZ3Options(z3Version);
            }
        }

        public override string AttributeHelp => MutateCSharp.Schemata270.ReplaceStringConstant_1(282L, @"Dafny: The documentation about attributes is best viewed here:
      https://dafny-lang.github.io/dafny/DafnyRef/DafnyRef#sec-attributes
      
     The following attributes are supported by this version.
    {:extern}
    {:extern <s1:string>}
    {:extern <s1:string>, <s2:string>}
      NOTE: :extern is target-language dependent.
      The extern modifier is used
        * to alter the CompileName of entities such as modules, classes, methods, etc.,
        * to alter the ReferenceName of the entities,
        * to decide how to define external abstract types,
        * to decide whether to emit target code or not, and
        * to decide whether a declaration is allowed not to have a body.
      The CompileName is the name for the entity when translating to one of the target languages.
      The ReferenceName is the name used to refer to the entity in the target language.
      A common use case of :extern is to avoid name clashes with existing library functions.

      :extern takes 0, 1, or 2 (possibly empty) string arguments:
        - 0: Dafny will use the Dafny name as the CompileName and not affect the ReferenceName
        - 1: Dafny will use s1 as the CompileName, and replaces the last portion of the ReferenceName by s1.
             When used on an abstract type, s1 is used as a hint as to how to declare that type when compiling.
        - 2: Dafny will use s2 as the CompileName.
             Dafny will use a combination of s1 and s2 such as for example s1.s2 as the ReferenceName
             It may also be the case that one of the arguments is simply ignored.
      Dafny does not perform sanity checks on the arguments---it is the user's responsibility not to generate
      malformed target code.

    {:compile}
      The {:compile} attribute takes a boolean argument. It may be applied to any top-level declaration.
      If that argument is false, then that declaration will not be compiled at all.
      
      The difference with {:extern} is that {:extern} will still emit declaration code if necessary,
      whereas {:compile false} will just ignore the declaration for compilation purposes.

    {:main}
      When executing a program, Dafny will first look for a method annotated with {:main}, and otherwise
      will look for `method Main()`, and then execute the first of these two methods found.

    {:axiom}
      Ordinarily, the compiler gives an error for every function or
      method without a body. If the function or method is ghost, then
      marking it with {:axiom} suppresses the error. The {:axiom}
      attribute says you're taking responsibility for the existence
      of a body for the function or method.

    {:abstemious}
      TODO

    {:print}
      This attributes declares that a method may have print effects,
      that is, it may use 'print' statements and may call other methods
      that have print effects. The attribute can be applied to compiled
      methods, constructors, and iterators, and it gives an error if
      applied to functions or ghost methods. An overriding method is
      allowed to use a {:print} attribute only if the overridden method
      does.
      Print effects are enforced only with /trackPrintEffects:1.

    {:nativeType}
      Can be applied to newtype declarations for integer types and
      indicates an expectation of what native type (or not) the
      newtype should compile to.

      If a newtype declaration has no explicit :nativeType attribute,
      then the compiler still attempts to find a suitable native numeric
      type, which is then reflected in an informational message or
      hovertext.

      {:nativeType} and {:nativeType true} say that the type is expected
      to compile to some native numeric type, but leaves it to the
      compiler to choose which one. If no suitable native target type is
      found, an error is generated.

      {:nativeType false} says to avoid using a native numeric type.
      Instead, the type will be compiled as an unbounded integer.

      {:nativeType X} where X is one of the following strings:
        ""byte""      8 bits, unsigned
        ""sbyte""     8 bits, signed
        ""ushort""    16 bits, unsigned
        ""short""     16 bits, signed
        ""uint""      32 bits, unsigned
        ""int""       32 bits, signed
        ""number""    53 bits, signed
        ""ulong""     64 bits, unsigned
        ""long""      64 bits, signed
      says to use the indicated target type. If the target compiler
      does not support X, then an error is generated. Also, if, after
      scrutinizing the constraint predicate, the compiler cannot confirm
      that the type's values will fit in X, an error is generated.

      {:nativeType XX} where XX is a list of strings from the list above,
      says to use the first X in XX that the compiler supports. If
      the compiler doesn't support any native type in XX, then an error
      is generated. Also, unless the compiler can confirm that all of
      the listed native types can fit the type's values, an error is
      generated.

    {:tailrecursion}
      Can be applied to methods and functions to direct compilation of
      recursive calls as tail calls.

      A method or function is _tail recursive_ if all of the following
      points apply:
      * It is not mutually recursive with another method or function.
      * Ignoring any parts of the method/function body that are ghost,
        every recursive call is a tail call (that is, the body has no
        more work to do after a recursive call). Note that any ghost
        code that follows a recursive method call is ignored.
      * In the case of a function, the function is not used as a
        first-class value inside the function body.
      For a function F, this definition is extended to additionally allow
      tail calls to appear in simple expressions like ""E + F(...)"" or
      ""F(...) + E"" for certain operators ""+"" where E does not mention
      F, provided that all such expressions are compatible. These
      are called _simple accumulator_ tail calls.

      By default, Dafny compiles tail recursive methods and functions
      using tail calls, automatically handling simple accumulator tail
      calls.

      {:tailrecursion false} is used to turn off tail calls.

      {:tailrecursion} or {:tailrecursion true} is used to confirm
      that the method/function is compiled and tail recursive. If it
      is not, an error is given.

    {:termination}
      Dafny currently lacks the features needed to specify usable termination
      metrics for trait methods that are dynamically dispatched to method
      implementations given in other modules. This issue and a sketch of a
      solution are described in https://github.com/dafny-lang/dafny/issues/1588.
      Until such features are added to the language, a type `C` that extends a
      trait `T` must be declared in the same module as `T`.
      There is, however, an available loophole: if a programmer is willing to
      take the responsibility that all calls to methods in a trait `T`
      that dynamically dispatch to implementations in other modules terminate,
      then the trait `T` can be marked with `{:termination false}`. This will
      allow `T` to be extended by types declared in modules outside `T`'s module.

      Caution: This loophole is unsound; that is, if a cross-module dynamic
      dispatch fails to terminate, then this and other errors in the program
      may have been overlooked by the verifier.       

      The meaning of `{:termination false}` is defined only on trait declarations.
      It has no meaning if applied to other declarations.

      Applying `{:termination false}` to a trait is similar to the
      effect of declaring each of its methods with `decreases *`, but
      there are several differences.  The biggest difference is that
      `decreases *` is sound, whereas the attribute is not. As such,
      `decreases *` cannot be used with functions, lemmas, or ghost
      methods, and callers of a `decreases *` method must themselves
      be declared with `decreases *`. In contrast, `{:termination false}`
      applies to all functions, lemmas, and methods of the trait, and
      callers do not have to indicate that they are using such a
      trait. Another difference is that `{:termination false}` does
      not change checking for intra-module calls. That is, even if a
      trait is declared with `{:termination false}`, calls to its
      functions, lemmas, and methods from within the module where the
      trait is declared are checked for termination in the usual
      manner.

    {:options ""/opt0:xyz"", ""/opt1"", ...}
      When applied to a module, this attribute configures Dafny as if
      `/opt0:xyz` and `/opt1` had been passed on the command line.
      Outside of the module, options revert to their previous values.
      Supported options: %SUPPORTED_OPTIONS%.

    {:warnShadowing}
      TODO

    {:verify}
      TODO

    {:autocontracts}
      TODO

    {:opaque}
      TODO

    {:autoReq}
      When applied to a function definition, Dafny automatically
      strengthens that function's `requires` clause sufficiently so that
      it may call each of the functions that it calls.

      When applied to a module, this attribute is inherited by every
      function in the module.

      The `/autoReqPrint:<file>` option will print out the inferred,
      stronger requires clauses to the given file. The `/noAutoReq`
      option instructs Dafny to ignore any `{:autoReq}` attributes.

    {:timeLimitMultiplier}
      TODO

    {:no_inline}
      When predicates such as `predicate P(x: int) { x % 2 == 0 }`
      are used in assertions like `assert P(6);`, Dafny
      will by default try to figure out if it can split the call
      into multiple assertions that are easier for the verifier.
      Hence, sometimes, if allowed to do so (e.g. no `{:opaque}`),
      Dafny will inline the predicate, resulting in, for example,
      `assert 6 % 2 == 0`.
      
      Adding the attribute `{:no_inline}` to a function will prevent
      the Dafny verifier from inlining it, but unless the function is
      `{:opaque}` its definition will still be available.
      
      This trick can be helpful, for a huge conjunct predicate `P`,
      assuming that `P(x)` already hold, if we don't want `P`
      to be opaque, and we `assert P(x)` again. Inlining might result
      in performance issues because it will have to infer every single
      conjunct. Adding `{:no_inline}` to the predicate can result
      in such cases in the verifier being faster.

    {:nowarn}
      TODO

    {:autotriggers}
      TODO

    {:trigger}
      TODO").Replace(MutateCSharp.Schemata270.ReplaceStringConstant_1(283L, "%SUPPORTED_OPTIONS%"),
            string.Join(MutateCSharp.Schemata270.ReplaceStringConstant_1(284L, ", "), DafnyAttributeOptions.KnownOptions));

        private static ConcurrentDictionary<string, Version> z3VersionPerPath = new();
        /// <summary>
        /// Dafny releases come with their own copy of Z3, to save users the trouble of having to install extra dependencies.
        /// For this to work, Dafny first tries any prover path explicitly provided by the user, then looks for for the copy
        /// distributed with Dafny, and finally looks in any directory in the system PATH environment variable.
        /// </summary>
        private Version SetZ3ExecutablePath(ErrorReporter errorReporter, IToken token)
        {
            string confirmedProverPath = null;
            string nextStepsMessage = $"Please either provide a path to the `z3` executable using the `--solver-path <path>` option, manually place the `z3` directory next to the `dafny` executable you are using (this directory should contain `bin/z3-{DefaultZ3Version}` or `bin/z3-{DefaultZ3Version}.exe`), or set the PATH environment variable to also include a directory containing the `z3` executable.";

            // Try an explicitly provided prover path, if there is one.
            var pp = MutateCSharp.Schemata270.ReplaceStringConstant_1(285L, "PROVER_PATH=");
            var proverPathOption = ProverOptions.Find(o => o.StartsWith(pp));
            if (proverPathOption != null)
            {
                var proverPath = proverPathOption.Substring(pp.Length);
                // Boogie will perform the ultimate test to see if "proverPath" is real--it will attempt to run it.
                // However, by at least checking if the file exists, we can produce a better error message in common scenarios.
                // Unfortunately, there doesn't seem to be a portable way of checking whether it's executable.
                if (!File.Exists(proverPath))
                {
                    errorReporter.Error(MessageSource.Verifier, token, $"Z3 not found at {proverPath}. " + nextStepsMessage);
                    return null;
                }

                confirmedProverPath = proverPath;
            }

            var platform = System.Environment.OSVersion.Platform;
            var isUnix = MutateCSharp.Schemata270.ReplaceBinExprOp_9(288L, () => MutateCSharp.Schemata270.ReplaceBinExprOp_16(286L, platform, PlatformID.Unix), () => MutateCSharp.Schemata270.ReplaceBinExprOp_16(287L, platform, PlatformID.MacOSX));

            // Next, try looking in a directory relative to Dafny itself.
            if (confirmedProverPath is null)
            {
                var dafnyBinDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                var z3LocalBinName = isUnix
                  ? $"z3-{DefaultZ3Version}"
                  : $"z3-{DefaultZ3Version}.exe";
                var z3BinPath = Path.Combine(dafnyBinDir, MutateCSharp.Schemata270.ReplaceStringConstant_1(294L, "z3"), MutateCSharp.Schemata270.ReplaceStringConstant_1(295L, "bin"), z3LocalBinName);

                if (File.Exists(z3BinPath))
                {
                    confirmedProverPath = z3BinPath;
                }
            }

            // Finally, try looking in the system PATH variable.
            var z3GlobalBinName = isUnix ? MutateCSharp.Schemata270.ReplaceStringConstant_1(296L, "z3") : MutateCSharp.Schemata270.ReplaceStringConstant_1(297L, "z3.exe");
            if (confirmedProverPath is null)
            {
                confirmedProverPath = System.Environment
                  .GetEnvironmentVariable(MutateCSharp.Schemata270.ReplaceStringConstant_1(298L, "PATH"))?
                  .Split(isUnix ? ':' : ';')
                  .Select(s => Path.Combine(s, z3GlobalBinName))
                  .FirstOrDefault(File.Exists);
            }

            if (confirmedProverPath is not null)
            {
                ProverOptions.Add($"{pp}{confirmedProverPath}");
                return z3VersionPerPath.GetOrAdd(confirmedProverPath, GetZ3Version);
            }

            errorReporter.Error(MessageSource.Verifier, DafnyProject.StartingToken, MutateCSharp.Schemata270.ReplaceStringConstant_1(299L, "Z3 is not found. ") + nextStepsMessage);
            return null;
        }

        private static readonly Regex Z3VersionRegex = new Regex(MutateCSharp.Schemata270.ReplaceStringConstant_1(300L, @"Z3 version (?<major>\d+)\.(?<minor>\d+)\.(?<patch>\d+)"));

        [CanBeNull]
        public static Version GetZ3Version(string proverPath)
        {
            var z3Process = new ProcessStartInfo(proverPath, MutateCSharp.Schemata270.ReplaceStringConstant_1(301L, "-version"))
            {
                CreateNoWindow = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(302L, true),
                RedirectStandardError = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(303L, true),
                RedirectStandardOutput = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(304L, true),
                RedirectStandardInput = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(305L, true
      )
            };
            var run = Process.Start(z3Process);
            if (MutateCSharp.Schemata270.ReplaceBinExprOp_17(306L, run, null))
            {
                return null;
            }

            var actualOutput = run.StandardOutput.ReadToEnd();
            run.WaitForExit();
            var versionMatch = Z3VersionRegex.Match(actualOutput);
            if (!versionMatch.Success)
            {
                // Might be another solver.
                return null;
            }

            var major = int.Parse(versionMatch.Groups[MutateCSharp.Schemata270.ReplaceStringConstant_1(307L, "major")].Value);
            var minor = int.Parse(versionMatch.Groups[MutateCSharp.Schemata270.ReplaceStringConstant_1(308L, "minor")].Value);
            var patch = int.Parse(versionMatch.Groups[MutateCSharp.Schemata270.ReplaceStringConstant_1(309L, "patch")].Value);
            return new Version(major, minor, patch);
        }

        // Set a Z3 option, but only if it is not overwriting an existing option.
        private void SetZ3Option(string name, string value)
        {
            if (!ProverOptions.Any(o => o.StartsWith($"O:{name}=")))
            {
                ProverOptions.Add($"O:{name}={value}");
            }
        }

        public void SetZ3Options(Version z3Version)
        {
            // Don't allow changing this once set, just in case:
            // a DooFile will record this and will get confused if it changes.
            if (MutateCSharp.Schemata270.ReplaceBinExprOp_9(330L, () => (MutateCSharp.Schemata270.ReplaceBinExprOp_13(312L, () => SolverIdentifier != null, () => MutateCSharp.Schemata270.ReplaceBinExprOp_18(311L, SolverIdentifier, MutateCSharp.Schemata270.ReplaceStringConstant_1(310L, "Z3"))))
      , () => (MutateCSharp.Schemata270.ReplaceBinExprOp_13(324L, () => MutateCSharp.Schemata270.ReplaceBinExprOp_19(318L, SolverVersion, null), () => MutateCSharp.Schemata270.ReplaceBinExprOp_20(319L, SolverVersion, z3Version)))))
            {
                throw new Exception(MutateCSharp.Schemata270.ReplaceStringConstant_1(336L, "Attempted to set Z3 options more than once"));
            }
            SolverIdentifier = MutateCSharp.Schemata270.ReplaceStringConstant_1(337L, "Z3");
            SolverVersion = z3Version;

            // Boogie sets the following Z3 options by default:
            // smt.mbqi = false
            // model.compact = false
            // model.v2 = true
            // pp.bv_literals = false

            // Boogie also used to set the following options, but does not anymore.
            SetZ3Option(MutateCSharp.Schemata270.ReplaceStringConstant_1(338L, "auto_config"), MutateCSharp.Schemata270.ReplaceStringConstant_1(339L, "false"));
            SetZ3Option(MutateCSharp.Schemata270.ReplaceStringConstant_1(340L, "type_check"), MutateCSharp.Schemata270.ReplaceStringConstant_1(341L, "true"));
            SetZ3Option(MutateCSharp.Schemata270.ReplaceStringConstant_1(342L, "smt.qi.eager_threshold"), MutateCSharp.Schemata270.ReplaceStringConstant_1(343L, "100")); // TODO: try lowering
            SetZ3Option(MutateCSharp.Schemata270.ReplaceStringConstant_1(344L, "smt.delay_units"), MutateCSharp.Schemata270.ReplaceStringConstant_1(345L, "true"));
            SetZ3Option(MutateCSharp.Schemata270.ReplaceStringConstant_1(346L, "model_evaluator.completion"), MutateCSharp.Schemata270.ReplaceStringConstant_1(347L, "true"));
            SetZ3Option(MutateCSharp.Schemata270.ReplaceStringConstant_1(348L, "model.completion"), MutateCSharp.Schemata270.ReplaceStringConstant_1(349L, "true"));
            if (MutateCSharp.Schemata270.ReplaceBinExprOp_9(367L, () => z3Version is null, () => MutateCSharp.Schemata270.ReplaceBinExprOp_21(362L, z3Version, new Version(MutateCSharp.Schemata270.ReplaceNumericConstant_0(350L, 4), MutateCSharp.Schemata270.ReplaceNumericConstant_0(354L, 8), MutateCSharp.Schemata270.ReplaceNumericConstant_0(358L, 6)))))
            {
                SetZ3Option(MutateCSharp.Schemata270.ReplaceStringConstant_1(373L, "model_compress"), MutateCSharp.Schemata270.ReplaceStringConstant_1(374L, "false"));
            }
            else
            {
                SetZ3Option(MutateCSharp.Schemata270.ReplaceStringConstant_1(375L, "model.compact"), MutateCSharp.Schemata270.ReplaceStringConstant_1(376L, "false"));
            }

            // This option helps avoid "time travelling triggers".
            // See: https://github.com/dafny-lang/dafny/discussions/3362
            SetZ3Option(MutateCSharp.Schemata270.ReplaceStringConstant_1(377L, "smt.case_split"), MutateCSharp.Schemata270.ReplaceStringConstant_1(378L, "3"));

            if (MutateCSharp.Schemata270.ReplaceBinExprOp_10(383L, MutateCSharp.Schemata270.ReplaceNumericConstant_0(379L, 3), ArithMode))
            {
                SetZ3Option(MutateCSharp.Schemata270.ReplaceStringConstant_1(388L, "smt.arith.nl"), MutateCSharp.Schemata270.ReplaceStringConstant_1(389L, "false"));
            }
        }

        protected override string HelpBody => DafnyHelpBody + BoogieHelpBody;

        protected string BoogieHelpBody => base.HelpBody;

        protected string DafnyHelpBody =>
          $@"
All the .dfy files supplied on the command line along with files recursively
included by 'include' directives are considered a single Dafny program;
however only those files listed on the command line are verified.

Exit code: 0 -- success; 1 -- invalid command-line; 2 -- parse or type errors;
           3 -- compilation errors; 4 -- verification errors

---- Input configuration ---------------------------------------------------

/stdin
    Read standard input and treat it as an input .dfy file.

---- Plugins ---------------------------------------------------------------

---- Overall reporting and printing ----------------------------------------

/stats
    Print interesting statistics about the Dafny files supplied.

/printIncludes:<None|Immediate|Transitive>
    None (default) - Print nothing.
    Immediate - Print files included by files listed on the command line.
    Transitive - Recurses on the files printed by Immediate.

    Immediate and Transitive will exit after printing.

/view:<view1, view2>
    Print the filtered views of a module after it is resolved (/rprint).
    If print before the module is resolved (/dprint), then everything in
    the module is printed. If no view is specified, then everything in
    the module is printed.
/funcCallGraph
    Print out the function call graph. Format is: func,mod=callee*

/pmtrace
    Print pattern-match compiler debug info.

/printTooltips
    Dump additional positional information (displayed as mouse-over
    tooltips by the VS Code plugin) to stdout as 'Info' messages.

/diagnosticsFormat:<text|json>
    Choose how to report errors, warnings, and info messages.
    text (default) - Use human readable output
    json - Print each message as a JSON object, one per line.

---- Language feature selection --------------------------------------------

/noIncludes
    Ignore include directives.

/noExterns
    Ignore extern attributes.

/functionSyntax:<version>
    The syntax for functions is changing from Dafny version 3 to version
    4. This switch gives early access to the new syntax, and also
    provides a mode to help with migration.

    3 - Compiled functions are written `function method` and
        `predicate method`. Ghost functions are written `function` and
        `predicate`.
    4 (default) - Compiled functions are written `function` and `predicate`. Ghost
        functions are written `ghost function` and `ghost predicate`.
    migration3to4 - Compiled functions are written `function method` and
        `predicate method`. Ghost functions are written `ghost function`
        and `ghost predicate`. To migrate from version 3 to version 4,
        use this flag on your version 3 program. This will give flag all
        occurrences of `function` and `predicate` as parsing errors.
        These are ghost functions, so change those into the new syntax
        `ghost function` and `ghost predicate`. Then, start using
        /functionSyntax:4. This will flag all occurrences of `function
        method` and `predicate method` as parsing errors. So, change
        those to just `function` and `predicate`. Now, your program uses
        version 4 syntax and has the exact same meaning as your previous
        version 3 program.
    experimentalDefaultGhost - Like migration3to4, but allow `function`
        and `predicate` as alternatives to declaring ghost functions and
        predicates, respectively.
    experimentalDefaultCompiled - Like migration3to4, but allow
        `function` and `predicate` as alternatives to declaring compiled
        functions and predicates, respectively.
    experimentalPredicateAlwaysGhost - Compiled functions are written
        `function`. Ghost functions are written `ghost function`.
        Predicates are always ghost and are written `predicate`.

/quantifierSyntax:<version>
    The syntax for quantification domains is changing from Dafny version
    3 to version 4, more specifically where quantifier ranges (|
    <Range>) are allowed. This switch gives early access to the new
    syntax.

    3 - Ranges are only allowed after all quantified variables
        are declared. (e.g. set x, y | 0 <= x < |s| && y in s[x] && 0 <=
        y :: y)
    4 (default) - Ranges are allowed after each quantified variable declaration.
        (e.g. set x | 0 <= x < |s|, y <- s[x] | 0 <= y :: y)

    Note that quantifier variable domains (<- <Domain>) are available in
    both syntax versions.

/disableScopes
    Treat all export sets as 'export reveal *'. i.e. don't hide function
    bodies or type definitions during translation.

---- Warning selection -----------------------------------------------------

/warnShadowing
    Emits a warning if the name of a declared variable caused another
    variable to be shadowed.

/warnMissingConstructorParenthesis
    Emits a warning when a constructor name in a case pattern is not
    followed by parentheses.

/deprecation:<n>
    0 - Don't give any warnings about deprecated features.
    1 (default) - Show warnings about deprecated features.

/warningsAsErrors
    Treat warnings as errors.

---- Verification options -------------------------------------------------

/dafnyVerify:<n>
    0 - Stop after resolution and typechecking.
    1 - Continue on to verification and compilation.

/verifyAllModules
    Verify modules that come from an include directive.

/emitUncompilableCode
    Allow compilers to emit uncompilable code that usually contain useful
    information about what feature is missing, rather than
    stopping on the first problem

/separateModuleOutput
    Output verification results for each module separately, rather than
    aggregating them after they are all finished.

/noCheating:<n>
    0 (default) - Allow assume statements and free invariants.
    1 - Treat all assumptions as asserts, and drop free.

/induction:<n>
    0 - Never do induction, not even when attributes request it.
    1 - Only apply induction when attributes request it.
    2 - Apply induction as requested (by attributes) and also for
        heuristically chosen quantifiers.
    3 - Apply induction as requested, and for heuristically chosen
        quantifiers and lemmas.
    4 (default) - Apply induction as requested, and for lemmas.

/inductionHeuristic:<n>
    0 - Least discriminating induction heuristic (that is, lean toward
        applying induction more often).
    1,2,3,4,5 - Levels in between, ordered as follows as far as how
        discriminating they are: 0 < 1 < 2 < (3,4) < 5 < 6.
    6 (default) - Most discriminating.

/trackPrintEffects:<n>
    0 (default) - Every compiled method, constructor, and iterator,
       whether or not it bears a {{:print}} attribute, may have print
       effects.
    1 - A compiled method, constructor, or iterator is allowed to have
       print effects only if it is marked with {{:print}}.

/definiteAssignment:<n>
    0 - Ignores definite-assignment rules. This mode is for testing
        only--it is not sound.
    1 (default) - Enforces definite-assignment rules for compiled
        variables and fields whose types do not support
        auto-initialization, and for ghost variables and fields whose
        type is possibly empty.
    2 - Enforces definite-assignment for all non-yield-parameter
        variables and fields, regardless of their types.
    3 - Like 2, but also performs checks in the compiler that no
        nondeterministic statements are used; thus, a program that
        passes at this level 3 is one that the language guarantees that
        values seen during execution will be the same in every run of
        the program.
    4 - Like 1, but enforces definite assignment for all local variables
        and out-parameters, regardless of their types. (Whether or not
        fields and new arrays are subject to definite assignments depends
        on their types.)

/noAutoReq
    Ignore autoReq attributes.

/autoReqPrint:<file>
    Print out requirements that were automatically generated by autoReq.

/noNLarith
    Reduce Z3's knowledge of non-linear arithmetic (*,/,%).

    Results in more manual work, but also produces more predictable
    behavior. (This switch will perhaps be replaced by /arith in the
    future. For now, it takes precedence of /arith.)

/arith:<n>
    (experimental) Adjust how Dafny interprets arithmetic operations.

    0 - Use Boogie/Z3 built-ins for all arithmetic operations.
    1 (default) - Like 0, but introduce symbolic synonyms for *,/,%, and
        allow these operators to be used in triggers.
    2 - Like 1, but introduce symbolic synonyms also for +,-.
    3 - Turn off non-linear arithmetic in the SMT solver. Still, use
        Boogie/Z3 built-in symbols for all arithmetic operations.
    4 - Like 3, but introduce symbolic synonyms for *,/,%, and allow
        these operators to be used in triggers.
    5 - Like 4, but introduce symbolic synonyms also for +,-.
    6 - Like 5, and introduce axioms that distribute + over *.
    7 - like 6, and introduce facts that associate literals arguments of *.
    8 - Like 7, and introduce axiom for the connection between *,/,%.
    9 - Like 8, and introduce axioms for sign of multiplication.
    10 - Like 9, and introduce axioms for commutativity and
        associativity of *.

/autoTriggers:<n>
    0 - Do not generate {{:trigger}} annotations for user-level
        quantifiers.
    1 (default) - Add a {{:trigger}} to each user-level quantifier.
        Existing annotations are preserved.

/rewriteFocalPredicates:<n>
    0 - Don't rewrite predicates in the body of prefix lemmas.
    1 (default) - In the body of prefix lemmas, rewrite any use of a
        focal predicate P to P#[_k-1].

/extractCounterexample
    If verification fails, report a detailed counterexample for the
    first failing assertion (experimental).

---- Compilation options ---------------------------------------------------

/compile:<n>
    0 - Do not compile Dafny program.
    1 (default) - Upon successful verification of the Dafny program,
        compile it to the designated target language. (/noVerify
        automatically counts as a failed verification.)
    2 - Always attempt to compile Dafny program to the target language,
        regardless of verification outcome.
    3 - If there is a Main method and there are no verification errors
        and /noVerify is not used, compiles program in memory (i.e.,
        does not write an output file) and runs it.
    4 - Like (3), but attempts to compile and run regardless of
        verification outcome.
/Main:<name>
    Specify the (fully-qualified) name of the method to use as the executable entry point.
    Default is the method with the {{:main}} attribute, or else the method named 'Main'.
    A Main method can have at most one (non-ghost) argument of type `seq<string>`
--args <arg1> <arg2> ...
    When running a Dafny file through /compile:3 or /compile:4, '--args' provides
    all arguments after it to the Main function, at index starting at 1.
    Index 0 is used to store the executable's name if it exists.

/compileVerbose:<n>
    0 - Don't print status of compilation to the console.
    1 (default) - Print information such as files being written by the
        compiler to the console.

/spillTargetCode:<n>
    Explicitly writes the code in the target language to one or more files.
    This is not necessary to run a Dafny program, but may be of interest when
    building multi-language programs or for debugging.

    0 (default) - Don't make any extra effort to write the textual
        target program (but still compile it, if /compile indicates to
        do so).
    1 - Write the textual target program, if it is being compiled.
    2 - Write the textual target program, provided it passes the
        verifier (and /noVerify is NOT used), regardless of /compile
        setting.
    3 - Write the textual target program, regardless of verification
        outcome and /compile setting.
    Note, some compiler targets may (always or in some situations) write
    out the textual target program as part of compilation, in which case
    /spillTargetCode:0 behaves the same way as /spillTargetCode:1.
/coverage:<file>
    The compiler emits branch-coverage calls and outputs into <file> a
    legend that gives a description of each source-location identifier
    used in the branch-coverage calls. (Use - as <file> to print to the
    console.)

/optimize
    Produce optimized C# code by passing the /optimize flag to csc.exe.

/optimizeResolution:<n>
    0 - Resolve and translate all methods.
    1 - Translate methods only in the call graph of current verification
        target.
    2 (default) - As in 1, but only resolve method bodies in
        non-included Dafny sources.
/useRuntimeLib
    Refer to a pre-built DafnyRuntime.dll in the compiled assembly
    rather than including DafnyRuntime.cs verbatim.

/testContracts:<Externs|TestedExterns>
    Enable run-time testing of the compilable portions of certain function
    or method contracts, at their call sites. The current implementation
    focuses on {{:extern}} code but may support other code in the future.

    Externs - Check contracts on every call to a function or method marked
        with the {{:extern}} attribute, regardless of where it occurs.
    TestedExterns - Check contracts on every call to a function or method
        marked with the {{:extern}} attribute when it occurs in a method
        with the {{:test}} attribute, and warn if no corresponding test
        exists for a given external declaration.

----------------------------------------------------------------------------

Dafny generally accepts Boogie options and passes these on to Boogie.
However, some Boogie options, like /loopUnroll, may not be sound for
Dafny or may not have the same meaning for a Dafny program as it would
for a similar Boogie program.
".Replace(MutateCSharp.Schemata270.ReplaceStringConstant_1(390L, "\n"), MutateCSharp.Schemata270.ReplaceStringConstant_1(391L, "\n  "));
    }
}

public
class ErrorReportingCommandLineParseState : Bpl.CommandLineParseState
{
    private readonly Errors errors;
    private IToken token;

    public ErrorReportingCommandLineParseState(string[] args, string toolName, Errors errors, IToken token)
      : base(args, toolName)
    {
        this.errors = errors;
        this.token = token;
    }

    public override void Error(string message, params string[] args)
    {
        errors.SemErr(GenericErrors.ErrorId.g_option_error, token, string.Format(message, args));
        EncounteredErrors = MutateCSharp.Schemata270.ReplaceBooleanConstant_2(392L, true);
    }
}

public
/// <summary>
/// Wrapper object that restricts which options may be applied.
/// Used by the parser to parse <c>:options</c> strings.
/// </summary>
class DafnyAttributeOptions : DafnyOptions
{
    public static readonly HashSet<string> KnownOptions = new()
    {
        MutateCSharp.Schemata270.ReplaceStringConstant_1(393L, "functionSyntax"),
        MutateCSharp.Schemata270.ReplaceStringConstant_1(394L, "quantifierSyntax"
  )
    };

    private readonly Errors errors;
    public IToken Token { get; set; }

    public DafnyAttributeOptions(DafnyOptions opts, Errors errors) : base(opts)
    {
        this.errors = errors;
        Token = null;
    }

    protected override Bpl.CommandLineParseState InitializeCommandLineParseState(string[] args)
    {
        return new ErrorReportingCommandLineParseState(args, ToolName, errors, Token ?? Microsoft.Dafny.Token.NoToken);
    }

    private void Unsupported(string name, Bpl.CommandLineParseState ps)
    {
        ps.Error($"Option {name} unrecognized or unsupported in ':options' attributes.");
    }

    protected override void UnknownSwitch(Bpl.CommandLineParseState ps)
    {
        Unsupported(ps.s, ps);
    }

    protected override bool ParseOption(string name, Bpl.CommandLineParseState ps)
    {
        if (!KnownOptions.Contains(name))
        {
            return MutateCSharp.Schemata270.ReplaceBooleanConstant_2(395L, false);
        }
        return base.ParseOption(name, ps);
    }

    protected override void AddFile(string file, Bpl.CommandLineParseState ps)
    {
        Unsupported(file, ps);
    }
}
