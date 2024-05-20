#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.CommandLine;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DafnyCore.Options;
using Microsoft.Extensions.FileSystemGlobbing;
using Tomlyn;
using Tomlyn.Model;
namespace MutateCSharp
{
    internal class Schemata327
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT327");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_15(long mutantId, System.Collections.Generic.ICollection<string> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, System.Uri argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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

        internal static bool ReplaceBooleanConstant_2(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static int ReplacePostfixUnaryExprOp_7(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
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

        internal static bool ReplaceBinExprOp_12(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 5)) { return argument1() != argument2(); }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1() || argument2(); }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1() && argument2(); }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1() | argument2(); }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1() & argument2(); }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1() ^ argument2(); }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1() == argument2(); }
            return argument1() != argument2();
        }

        internal static string ReplaceStringConstant_4(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_14(long mutantId, System.Collections.Generic.ISet<string> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_16(long mutantId, System.Type argument1, System.Type argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, System.Type argument1, System.Type argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, int argument1, int argument2)
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
    public class DafnyProject : IEquatable<DafnyProject>
    {
        public const string Extension = ".toml";
        public const string FileName = "dfyconfig" + Extension;

        public string ProjectName => Uri.ToString();

        public BatchErrorReporter Errors { get; init; } = new(DafnyOptions.Default);

        public Uri Uri { get; set; }
        public Uri? Base { get; set; }
        public ISet<string> Includes { get; }
        public ISet<string> Excludes { get; }
        public IDictionary<string, object> Options { get; }

        public bool UsesProjectFile => Path.GetFileName(Uri.LocalPath).EndsWith(FileName);
        public bool ImplicitFromCli;

        public IToken StartingToken => ImplicitFromCli ? Token.Cli : new Token
        {
            Uri = Uri,
            line = MutateCSharp.Schemata327.ReplaceNumericConstant_0(1L, 1),
            col = MutateCSharp.Schemata327.ReplaceNumericConstant_0(5L, 1
      )
        };

        public DafnyProject(Uri uri, Uri? @base, ISet<string> includes, ISet<string>? excludes = null, IDictionary<string, object>? options = null)
        {
            Uri = uri;
            Base = @base;
            Includes = includes;
            Excludes = excludes ?? new HashSet<string>();
            Options = options ?? new Dictionary<string, object>();
        }

        public static async Task<DafnyProject> Open(IFileSystem fileSystem, DafnyOptions dafnyOptions, Uri uri, IToken uriOrigin,
          bool defaultIncludes = true, bool serverNameCheck = true)
        {

            var emptyProject = new DafnyProject(uri, null, new HashSet<string>(), new HashSet<string>(),
              new Dictionary<string, object>());

            DafnyProject result;
            try
            {
                using var textReader = fileSystem.ReadFile(uri);
                var text = await textReader.ReadToEndAsync();
                var model = Toml.ToModel<DafnyProjectFile>(text, null, new TomlModelOptions());
                var directory = Path.GetDirectoryName(uri.LocalPath)!;

                result = new DafnyProject(uri, model.Base == null ? null : new Uri(Path.GetFullPath(model.Base, directory!)),
                  model.Includes?.Select(p => Path.GetFullPath(p, directory)).ToHashSet() ?? new HashSet<string>(),
                  model.Excludes?.Select(p => Path.GetFullPath(p, directory)).ToHashSet() ?? new HashSet<string>(),
                  model.Options ?? new Dictionary<string, object>());

                if (MutateCSharp.Schemata327.ReplaceBinExprOp_1(9L, result.Base, null))
                {
                    var baseProject = await Open(fileSystem, dafnyOptions, result.Base, new Token
                    {
                        Uri = uri,
                        line = MutateCSharp.Schemata327.ReplaceNumericConstant_0(10L, 1),
                        col = MutateCSharp.Schemata327.ReplaceNumericConstant_0(14L, 1
            )
                    }, MutateCSharp.Schemata327.ReplaceBooleanConstant_2(18L, false), MutateCSharp.Schemata327.ReplaceBooleanConstant_2(19L, false));
                    baseProject.Errors.CopyDiagnostics(result.Errors);
                    foreach (var include in baseProject.Includes)
                    {
                        if (!result.Excludes.Contains(include))
                        {
                            result.Includes.Add(include);
                        }
                    }

                    foreach (var include in baseProject.Excludes)
                    {
                        if (!result.Includes.Contains(include))
                        {
                            result.Excludes.Add(include);
                        }
                    }

                    foreach (var option in baseProject.Options)
                    {
                        if (!result.Options.ContainsKey(option.Key))
                        {
                            result.Options.Add(option.Key, option.Value);
                        }
                    }
                }
                if (MutateCSharp.Schemata327.ReplaceBinExprOp_3(26L, () => MutateCSharp.Schemata327.ReplaceBinExprOp_3(20L, () => defaultIncludes, () => model.Includes == null), () => !result.Includes.Any()))
                {
                    result.Includes.Add(MutateCSharp.Schemata327.ReplaceStringConstant_4(32L, "**/*.dfy"));
                }
            }
            catch (IOException e)
            {
                result = emptyProject;
                result.Errors.Error(MessageSource.Project, uriOrigin, e.Message);
            }
            catch (TomlException tomlException)
            {
                var propertyNotFoundRegex = new Regex(
                  @$"\((\d+),(\d+)\) : error : The property `(\w+)` was not found on object type {typeof(DafnyProject).FullName}");
                var propertyNotFoundMatch = propertyNotFoundRegex.Match(tomlException.Message);
                if (propertyNotFoundMatch.Success)
                {
                    var line = int.Parse(propertyNotFoundMatch.Groups[MutateCSharp.Schemata327.ReplaceNumericConstant_0(33L, 1)].Value);
                    var column = int.Parse(propertyNotFoundMatch.Groups[MutateCSharp.Schemata327.ReplaceNumericConstant_0(37L, 2)].Value);
                    var property = propertyNotFoundMatch.Groups[MutateCSharp.Schemata327.ReplaceNumericConstant_0(41L, 3)].Value;
                    result = emptyProject;
                    var token = new Token(line, column)
                    {
                        Uri = uri
                    };
                    result.Errors.Error(MessageSource.Project, token,
                      $"Dafny project files do not have the property {property}");
                }
                else
                {
                    var genericRegex = new Regex(@$"\((\d+),(\d+)\) : error : (.*)");
                    var genericMatch = genericRegex.Match(tomlException.Message);
                    if (genericMatch.Success)
                    {
                        var line = int.Parse(genericMatch.Groups[MutateCSharp.Schemata327.ReplaceNumericConstant_0(45L, 1)].Value);
                        var column = int.Parse(genericMatch.Groups[MutateCSharp.Schemata327.ReplaceNumericConstant_0(49L, 2)].Value);
                        var message = genericMatch.Groups[MutateCSharp.Schemata327.ReplaceNumericConstant_0(53L, 3)].Value;
                        result = emptyProject;
                        var token = new Token(line, column)
                        {
                            Uri = uri
                        };
                        result.Errors.Error(MessageSource.Project, token, message);
                    }
                    else
                    {
                        throw new Exception(MutateCSharp.Schemata327.ReplaceStringConstant_4(57L, "Could not parse Tomlyn error"));
                    }
                }
            }

            if (MutateCSharp.Schemata327.ReplaceBinExprOp_3(59L, () => serverNameCheck, () => MutateCSharp.Schemata327.ReplaceBinExprOp_5(58L, Path.GetFileName(uri.LocalPath), FileName)))
            {
                result.Errors.Warning(MessageSource.Project, "", result.StartingToken, $"only Dafny project files named {FileName} are recognised by the Dafny IDE.");
            }

            return result;
        }

        public IEnumerable<Uri> GetRootSourceUris(IFileSystem fileSystem)
        {
            if (!Uri.IsFile)
            {
                return new[] { Uri };
            }
            var matcher = GetMatcher(out var searchRoot);

            var result = matcher.Execute(fileSystem.GetDirectoryInfoBase(searchRoot));
            var files = result.Files.Select(f => Path.Combine(searchRoot, f.Path));
            return files.OrderBy(file => file).Select(file => new Uri(Path.GetFullPath(file))).
              Where(uri => !(MutateCSharp.Schemata327.ReplaceBinExprOp_3(65L, () => uri.Equals(Uri), () => uri.LocalPath.EndsWith(Extension))));
        }

        public bool ContainsSourceFile(Uri uri)
        {
            var matcher = GetMatcher(out var searchRoot);
            var fileSystemWithSourceFile = new InMemoryDirectoryInfoFromDotNet8(searchRoot, new[] { uri.LocalPath });
            return matcher.Execute(fileSystemWithSourceFile).HasMatches;
        }

        private Matcher GetMatcher(out string commonRoot)
        {
            var projectRoot = Path.GetDirectoryName(Uri.LocalPath)!;
            var diskRoot = Path.GetPathRoot(Uri.LocalPath)!;

            var includes = Includes;
            var excludes = Excludes;
            var fullPaths = includes.Concat(excludes).Select(p => Path.GetFullPath(p, projectRoot)).ToList();
            commonRoot = GetCommonParentDirectory(fullPaths) ?? diskRoot;
            var matcher = new Matcher();
            foreach (var includeGlob in includes)
            {
                matcher.AddInclude(Path.GetRelativePath(commonRoot, Path.GetFullPath(includeGlob, projectRoot)));
            }

            foreach (var excludeGlob in excludes)
            {
                matcher.AddExclude(Path.GetRelativePath(commonRoot, Path.GetFullPath(excludeGlob, projectRoot)));
            }

            return matcher;
        }

        string? GetCommonParentDirectory(IReadOnlyList<string> strings)
        {
            if (!strings.Any())
            {
                return null;
            }
            string commonPrefix = strings.FirstOrDefault() ?? "";

            foreach (var newString in strings)
            {
                var potentialMatchLength = Math.Min(newString.Length, commonPrefix.Length);

                if (MutateCSharp.Schemata327.ReplaceBinExprOp_6(71L, potentialMatchLength, commonPrefix.Length))
                {
                    commonPrefix = commonPrefix.Substring(MutateCSharp.Schemata327.ReplaceNumericConstant_0(76L, 0), potentialMatchLength);
                }

                for (var i = MutateCSharp.Schemata327.ReplaceNumericConstant_0(80L, 0); MutateCSharp.Schemata327.ReplaceBinExprOp_6(84L, i, potentialMatchLength); MutateCSharp.Schemata327.ReplacePostfixUnaryExprOp_7(89L, ref i))
                {
                    if (MutateCSharp.Schemata327.ReplaceBinExprOp_10(100L, () => MutateCSharp.Schemata327.ReplaceBinExprOp_8(90L, newString[i], '*'), () => MutateCSharp.Schemata327.ReplaceBinExprOp_9(95L, newString[i], commonPrefix[i])))
                    {
                        commonPrefix = commonPrefix.Substring(MutateCSharp.Schemata327.ReplaceNumericConstant_0(106L, 0), i);
                        break;
                    }
                }
            }

            if (!Path.EndsInDirectorySeparator(commonPrefix))
            {
                commonPrefix = Path.GetDirectoryName(commonPrefix)!;
            }

            return commonPrefix;
        }

        public void Validate(TextWriter outputWriter, IEnumerable<Option> possibleOptions)
        {

            var possibleNames = possibleOptions.Select(o => o.Name).ToHashSet();
            foreach (var optionThatDoesNotExist in Options.Where(option => !possibleNames.Contains(option.Key)))
            {
                outputWriter.WriteLine(
                  $"Warning: option '{optionThatDoesNotExist.Key}' that was specified in the project file, is not a valid Dafny option.");
            }
        }

        public bool TryGetValue(Option option, out object? value)
        {
            if (!Options.TryGetValue(option.Name, out var tomlValue))
            {
                value = null;
                return MutateCSharp.Schemata327.ReplaceBooleanConstant_2(110L, false);
            }

            var printTomlValue = PrintTomlOptionToCliValue(Uri, tomlValue, option);
            var parseResult = option.Parse(printTomlValue.ToArray());
            if (parseResult.Errors.Any())
            {
                Errors.Error(MessageSource.Project, StartingToken, $"could not parse value '{tomlValue}' for option '{option.Name}' that has type '{option.ValueType.Name}'");
                value = null;
                return MutateCSharp.Schemata327.ReplaceBooleanConstant_2(111L, false);
            }
            // By using the dynamic keyword, we can use the generic version of GetValueForOption which does type conversion,
            // which is sadly not accessible without generics.
            value = parseResult.GetValueForOption((dynamic)option);
            return MutateCSharp.Schemata327.ReplaceBooleanConstant_2(112L, true);
        }

        public static IEnumerable<string> PrintTomlOptionToCliValue(Uri uri, object value, Option valueType)
        {
            var projectDirectory = Path.GetDirectoryName(uri.LocalPath)!;

            if (value is TomlArray array)
            {
                List<string> elements;
                if (valueType.ValueType.IsAssignableTo(typeof(IEnumerable<FileInfo>)))
                {
                    elements = array.Select(element =>
                    {
                        if (element is string elementString)
                        {
                            return Path.GetFullPath(elementString, projectDirectory);
                        }

                        return element + "";
                    }).ToList();
                }
                else
                {
                    elements = array.Select(o => o + "").ToList();
                }

                return elements.SelectMany(e => new[] { valueType.Aliases.First(), e });
            }

            if (value is string stringValue && MutateCSharp.Schemata327.ReplaceBinExprOp_11(113L, valueType.ValueType, typeof(FileInfo)))
            {
                value = Path.GetFullPath(stringValue, projectDirectory);
            }

            return new[] { valueType.Aliases.First(), value + "" };
        }

        public bool Equals(DafnyProject? other)
        {
            if (ReferenceEquals(null, other))
            {
                return MutateCSharp.Schemata327.ReplaceBooleanConstant_2(114L, false);
            }

            if (ReferenceEquals(this, other))
            {
                return MutateCSharp.Schemata327.ReplaceBooleanConstant_2(115L, true);
            }

            var orderedOptions = Options.OrderBy(kv => kv.Key);
            var otherOrderedOptions = other.Options.OrderBy(kv => kv.Key);

            return MutateCSharp.Schemata327.ReplaceBinExprOp_3(135L, () => MutateCSharp.Schemata327.ReplaceBinExprOp_3(122L, () => MutateCSharp.Schemata327.ReplaceBinExprOp_3(116L, () => Equals(Uri, other.Uri), () => NullableSetEqual(Includes, other.Includes)), () => NullableSetEqual(Excludes, other.Excludes)), () => orderedOptions.SequenceEqual(otherOrderedOptions, new LambdaEqualityComparer<KeyValuePair<string, object>>(
                     (kv1, kv2) => MutateCSharp.Schemata327.ReplaceBinExprOp_3(129L, () => MutateCSharp.Schemata327.ReplaceBinExprOp_12(128L, kv1.Key, kv2.Key), () => GenericEquals(kv1.Value, kv2.Value)),
                     kv => kv.GetHashCode())));
        }

        [SuppressMessage("ReSharper", "NotDisposedResource")]
        public static bool GenericEquals(object? first, object? second)
        {
            if (MutateCSharp.Schemata327.ReplaceBinExprOp_3(141L, () => first == null, () => second == null))
            {
                return MutateCSharp.Schemata327.ReplaceBooleanConstant_2(147L, true);
            }

            if (MutateCSharp.Schemata327.ReplaceBinExprOp_10(148L, () => first == null, () => second == null))
            {
                return MutateCSharp.Schemata327.ReplaceBooleanConstant_2(154L, false);
            }

            if (first is IEnumerable firstEnumerable && second is IEnumerable secondEnumerable)
            {
                var firstEnumerator = firstEnumerable.GetEnumerator();
                var secondEnumerator = secondEnumerable.GetEnumerator();

                while (MutateCSharp.Schemata327.ReplaceBooleanConstant_2(155L, true))
                {
                    var a = firstEnumerator.MoveNext();
                    var b = secondEnumerator.MoveNext();
                    if (MutateCSharp.Schemata327.ReplaceBinExprOp_13(156L, () => a, () => b))
                    {
                        return MutateCSharp.Schemata327.ReplaceBooleanConstant_2(162L, false);
                    }

                    if (!a)
                    {
                        return MutateCSharp.Schemata327.ReplaceBooleanConstant_2(163L, true);
                    }

                    if (!GenericEquals(firstEnumerator.Current, secondEnumerator.Current))
                    {
                        return MutateCSharp.Schemata327.ReplaceBooleanConstant_2(164L, false);
                    }
                }
            }

            return first.Equals(second);
        }

        private static bool NullableSetEqual(ISet<string>? first, ICollection<string>? second)
        {
            if (MutateCSharp.Schemata327.ReplaceBinExprOp_3(167L, () => MutateCSharp.Schemata327.ReplaceBinExprOp_14(165L, first, null), () => MutateCSharp.Schemata327.ReplaceBinExprOp_15(166L, second, null)))
            {
                return MutateCSharp.Schemata327.ReplaceBooleanConstant_2(173L, true);
            }

            if (MutateCSharp.Schemata327.ReplaceBinExprOp_10(176L, () => MutateCSharp.Schemata327.ReplaceBinExprOp_14(174L, first, null), () => MutateCSharp.Schemata327.ReplaceBinExprOp_15(175L, second, null)))
            {
                return MutateCSharp.Schemata327.ReplaceBooleanConstant_2(182L, false);
            }
            return MutateCSharp.Schemata327.ReplaceBinExprOp_3(188L, () => MutateCSharp.Schemata327.ReplaceBinExprOp_8(183L, first.Count, second.Count), () => second.All(first.Contains));
        }

        public DafnyProject(DafnyProject original)
        {
            Uri = original.Uri;
            Includes = original.Includes.ToHashSet();
            Excludes = original.Excludes.ToHashSet();
            Options = original.Options.ToDictionary(kv => kv.Key, kv => kv.Value);
            Errors = original.Errors;
        }

        public DafnyProject Clone()
        {
            return new DafnyProject(this);
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return MutateCSharp.Schemata327.ReplaceBooleanConstant_2(194L, false);
            }

            if (ReferenceEquals(this, obj))
            {
                return MutateCSharp.Schemata327.ReplaceBooleanConstant_2(195L, true);
            }

            if (MutateCSharp.Schemata327.ReplaceBinExprOp_16(196L, obj.GetType(), this.GetType()))
            {
                return MutateCSharp.Schemata327.ReplaceBooleanConstant_2(197L, false);
            }

            return Equals((DafnyProject)obj);
        }

        [SuppressMessage("ReSharper", "NonReadonlyMemberInGetHashCode")]
        public override int GetHashCode()
        {
            return HashCode.Combine(Uri, Includes, Excludes, Options);
        }
    }

    public
    class DafnyProjectFile
    {
        public string? Base { get; set; }
        public string[]? Includes { get; set; }
        public string[]? Excludes { get; set; }
        public Dictionary<string, object>? Options { get; set; }
    }
}