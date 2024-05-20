using System;
using System.Collections.Generic;
using System.CommandLine;
using Microsoft.Dafny;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata330
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT330");
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

        internal static bool ReplaceBinExprOp_1(long mutantId, System.Type argument1, System.Type argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static string ReplaceStringConstant_2(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

    }
}

namespace DafnyCore.Options
{
    public class OptionCompatibility
    {
        public delegate bool OptionCheck(ErrorReporter reporter, IToken origin, string prefix, Option option, object localValue, object libraryValue);

        public static bool CheckOptionMatches(ErrorReporter reporter, IToken origin, string prefix, Option option, object localValue, object libraryValue)
        {
            if (OptionValuesEqual(option, localValue, libraryValue))
            {
                return MutateCSharp.Schemata330.ReplaceBooleanConstant_0(1L, true);
            }

            reporter.Error(MessageSource.Project, origin,
              $"{prefix}: --{option.Name} is set locally to {OptionValueToString(option, localValue)}, " +
              $"but the library was built with {OptionValueToString(option, libraryValue)}");
            return MutateCSharp.Schemata330.ReplaceBooleanConstant_0(2L, false);
        }

        private static string OptionValueToString(Option option, object value)
        {
            if (MutateCSharp.Schemata330.ReplaceBinExprOp_1(3L, option.ValueType, typeof(IEnumerable<string>)))
            {
                var values = (IEnumerable<string>)value;
                return $"[{string.Join(',', values)}]";
            }

            if (value == null)
            {
                return MutateCSharp.Schemata330.ReplaceStringConstant_2(4L, "a version of Dafny that does not have this option");
            }
            return value.ToString();
        }

        private static bool OptionValuesEqual(Option option, object first, object second)
        {
            if (first.Equals(second))
            {
                return MutateCSharp.Schemata330.ReplaceBooleanConstant_0(5L, true);
            }

            if (MutateCSharp.Schemata330.ReplaceBinExprOp_1(6L, option.ValueType, typeof(IEnumerable<string>)))
            {
                return ((IEnumerable<string>)first).SequenceEqual((IEnumerable<string>)second);
            }

            return MutateCSharp.Schemata330.ReplaceBooleanConstant_0(7L, false);
        }

        public static bool OptionValuesImplied(object first, object second)
        {
            try
            {
                return MutateCSharp.Schemata330.ReplaceBinExprOp_3(8L, () => !(bool)first, () => (bool)second);
            }
            catch (NullReferenceException)
            {
                throw new Exception(MutateCSharp.Schemata330.ReplaceStringConstant_2(14L, "Comparing options of Doo files created by different Dafny builds. You are probably using a locally built Dafny that has the same version as a different built."));
            }

            return default;
        }

        public static bool OptionLibraryImpliesLocalError(ErrorReporter reporter, IToken origin, string prefix, Option option, object localValue, object libraryValue)
        {
            return CheckOptionLibraryImpliesLocal(reporter, origin, prefix, option, ErrorLevel.Error,
              localValue, libraryValue);
        }

        public static bool OptionLibraryImpliesLocalWarning(ErrorReporter reporter, IToken origin, string prefix, Option option, object localValue, object libraryValue)
        {
            return CheckOptionLibraryImpliesLocal(reporter, origin, prefix, option, ErrorLevel.Warning,
              localValue, libraryValue);
        }

        /// Checks that the library option ==> the local option.
        /// E.g. --no-verify: the only incompatibility is if it's on in the library but not locally.
        /// Generally the right check for options that weaken guarantees.
        private static bool CheckOptionLibraryImpliesLocal(ErrorReporter reporter, IToken origin, string prefix, Option option, ErrorLevel severity, object localValue, object libraryValue)
        {
            if (OptionValuesImplied(libraryValue, localValue))
            {
                return MutateCSharp.Schemata330.ReplaceBooleanConstant_0(15L, true);
            }

            reporter.Message(MessageSource.Project, severity, "", origin,
              $"{prefix}: --{option.Name} is set locally to {OptionValueToString(option, localValue)}, but the library was built with {OptionValueToString(option, libraryValue)}");
            return MutateCSharp.Schemata330.ReplaceBooleanConstant_0(16L, false);
        }

        /// Checks that the local option ==> the library option.
        /// E.g. --track-print-effects: the only incompatibility is if it's on locally but not in the library.
        /// Generally the right check for options that strengthen guarantees.
        public static bool CheckOptionLocalImpliesLibrary(ErrorReporter reporter, IToken origin, string prefix, Option option, object localValue, object libraryValue)
        {
            if (OptionValuesImplied(localValue, libraryValue))
            {
                return MutateCSharp.Schemata330.ReplaceBooleanConstant_0(17L, true);
            }
            reporter.Error(MessageSource.Project, origin, LocalImpliesLibraryMessage(prefix, option, localValue, libraryValue));
            return MutateCSharp.Schemata330.ReplaceBooleanConstant_0(18L, false);
        }

        public static string LocalImpliesLibraryMessage(string prefix, Option option, object localValue, object libraryValue)
        {
            return $"{prefix}: --{option.Name} is set locally to {OptionValueToString(option, localValue)}, but the library was built with {OptionValueToString(option, libraryValue)}";
        }


        // Placeholder no-op check, used for options that need to be recorded but don't require any compatibility check.
        public static bool NoOpOptionCheck(ErrorReporter reporter, IToken origin, string prefix, Option option, object localValue, object libraryValue)
        {
            return MutateCSharp.Schemata330.ReplaceBooleanConstant_0(19L, true);
        }
    }
}