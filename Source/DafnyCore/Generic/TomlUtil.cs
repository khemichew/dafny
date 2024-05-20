using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Dafny;
using Tomlyn.Model;
using Type = System.Type;
namespace MutateCSharp
{
    internal class Schemata318
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT318");
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

    }
}

namespace DafnyCore.Generic
{
    public static class TomlUtil
    {

        public static bool TryGetValueFromToml(ErrorReporter reporter, IToken origin, string sourceDir, string tomlPath,
          Type type, object tomlValue, out object value)
        {
            if (tomlValue == null)
            {
                value = null;
                return MutateCSharp.Schemata318.ReplaceBooleanConstant_0(1L, false);
            }

            if (type.IsAssignableFrom(typeof(List<string>)))
            {
                return TryGetListValueFromToml<string>(reporter, origin, sourceDir, tomlPath, (TomlArray)tomlValue, out value);
            }
            if (type.IsAssignableFrom(typeof(List<FileInfo>)))
            {
                return TryGetListValueFromToml<FileInfo>(reporter, origin, sourceDir, tomlPath, (TomlArray)tomlValue, out value);
            }

            if (tomlValue is string tomlString)
            {
                if (MutateCSharp.Schemata318.ReplaceBinExprOp_1(2L, type, typeof(FileInfo)))
                {
                    // Need to make sure relative paths are interpreted relative to the source of the value,
                    // not the current directory.
                    var fullPath = sourceDir != null ? Path.GetFullPath(tomlString, sourceDir) : tomlString;
                    value = new FileInfo(fullPath);
                    return MutateCSharp.Schemata318.ReplaceBooleanConstant_0(3L, true);
                }

                if (typeof(Enum).IsAssignableFrom(type))
                {
                    try
                    {
                        value = Enum.Parse(type, tomlString);
                        return MutateCSharp.Schemata318.ReplaceBooleanConstant_0(4L, true);
                    }
                    catch (ArgumentException)
                    {
                        value = null;
                        return MutateCSharp.Schemata318.ReplaceBooleanConstant_0(5L, false);
                    }
                }
            }

            if (!type.IsInstanceOfType(tomlValue))
            {
                if (MutateCSharp.Schemata318.ReplaceBinExprOp_1(6L, type, typeof(string)))
                {
                    value = tomlValue.ToString();
                    return MutateCSharp.Schemata318.ReplaceBooleanConstant_0(7L, true);
                }
                reporter.Error(MessageSource.Project, origin, $"property '{tomlPath}' is of type '{tomlValue.GetType()}' but should be of type '{type}'");
                value = null;
                return MutateCSharp.Schemata318.ReplaceBooleanConstant_0(8L, false);
            }

            value = tomlValue;
            return MutateCSharp.Schemata318.ReplaceBooleanConstant_0(9L, true);
        }

        private static bool TryGetListValueFromToml<T>(ErrorReporter reporter, IToken origin, string sourceDir, string tomlPath, TomlArray tomlValue, out object value)
        {
            var success = MutateCSharp.Schemata318.ReplaceBooleanConstant_0(10L, true);
            value = tomlValue.Select((e, i) =>
            {
                if (TryGetValueFromToml(reporter, origin, sourceDir, $"{tomlPath}[{i}]", typeof(T), e, out var elementValue))
                {
                    return (T)elementValue;
                }
                success = MutateCSharp.Schemata318.ReplaceBooleanConstant_0(11L, false);
                return default(T);
            }).ToList();
            return success;
        }
    }
}