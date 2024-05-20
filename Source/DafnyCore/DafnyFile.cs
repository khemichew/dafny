#nullable enable

using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;
using DafnyCore;
using DafnyCore.Options;
namespace MutateCSharp
{
    internal class Schemata268
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT268");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_8(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static int ReplaceNumericConstant_6(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.DafnyFile argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, Microsoft.Dafny.DafnyOptions argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
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

        internal static bool ReplaceBinExprOp_2(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBooleanConstant_9(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.DafnyFile.HandleExtension argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, System.Uri argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{
    public class DafnyFile
    {
        public const string DafnyFileExtension = ".dfy";
        public string FilePath => CanonicalPath;
        public string Extension { get; private set; }
        public string CanonicalPath { get; }
        public string BaseName { get; private set; }
        public bool ShouldNotVerify { get; private set; }
        public bool ShouldNotCompile { get; private set; }
        public DafnyOptions FileOptions { get; private set; }
        public Func<TextReader> GetContent { get; set; }
        public Uri Uri { get; private set; }
        public IToken? Origin { get; }

        private static readonly Dictionary<Uri, Uri> ExternallyVisibleEmbeddedFiles = new();

        static DafnyFile()
        {
            DooFile.RegisterLibraryCheck(UnsafeDependencies, OptionCompatibility.OptionLibraryImpliesLocalError);
        }

        public static Uri ExposeInternalUri(string externalName, Uri internalUri)
        {
            var externalUri = new Uri(MutateCSharp.Schemata268.ReplaceStringConstant_0(1L, "dafny:") + externalName);
            ExternallyVisibleEmbeddedFiles[externalUri] = internalUri;
            return externalUri;
        }

        public delegate IAsyncEnumerable<DafnyFile> HandleExtension(DafnyOptions options, IFileSystem
          fileSystem, ErrorReporter reporter, Uri uri, IToken origin, bool asLibrary);

        private static readonly Dictionary<string, HandleExtension> ExtensionHandlers = new();

        public static void RegisterExtensionHandler(string extension, HandleExtension handler)
        {
            ExtensionHandlers[extension] = handler;
        }

        public static async IAsyncEnumerable<DafnyFile> CreateAndValidate(IFileSystem fileSystem,
          ErrorReporter reporter,
          DafnyOptions options, Uri uri, IToken? uriOrigin,
          bool asLibrary = false, string? errorOnNotRecognized = null)
        {

            var embeddedFile = ExternallyVisibleEmbeddedFiles.GetValueOrDefault(uri);
            if (MutateCSharp.Schemata268.ReplaceBinExprOp_1(2L, embeddedFile, null))
            {
                var embeddedResults = CreateAndValidate(fileSystem, reporter, options, embeddedFile, uriOrigin, asLibrary, errorOnNotRecognized);
                await foreach (var result in embeddedResults)
                {
                    result.Uri = uri;
                    yield return result;
                }
                yield break;
            }

            uriOrigin ??= Token.NoToken;

            string extension;
            if (uri.IsFile)
            {
                extension = Path.GetExtension(uri.LocalPath).ToLower();
            }
            else if (MutateCSharp.Schemata268.ReplaceBinExprOp_2(4L, uri.Scheme, MutateCSharp.Schemata268.ReplaceStringConstant_0(3L, "dllresource")))
            {
                extension = Path.GetExtension(uri.LocalPath).ToLower();
            }
            else
            {
                extension = DafnyFileExtension;
            }

            if (MutateCSharp.Schemata268.ReplaceBinExprOp_3(16L, () => MutateCSharp.Schemata268.ReplaceBinExprOp_3(8L, () => MutateCSharp.Schemata268.ReplaceBinExprOp_2(6L, uri.Scheme, MutateCSharp.Schemata268.ReplaceStringConstant_0(5L, "untitled")), () => MutateCSharp.Schemata268.ReplaceBinExprOp_2(7L, extension, DafnyFileExtension)), () => MutateCSharp.Schemata268.ReplaceBinExprOp_2(15L, extension, MutateCSharp.Schemata268.ReplaceStringConstant_0(14L, ".dfyi"))))
            {
                var file = HandleDafnyFile(fileSystem, reporter, options, uri, uriOrigin, asLibrary);
                if (MutateCSharp.Schemata268.ReplaceBinExprOp_4(22L, file, null))
                {
                    yield return file;
                }
                yield break;
            }

            if (MutateCSharp.Schemata268.ReplaceBinExprOp_2(23L, extension, DooFile.Extension))
            {
                await foreach (var dooResult in HandleDooFile(fileSystem, reporter, options, uri, uriOrigin, asLibrary))
                {
                    yield return dooResult;
                }
                yield break;
            }

            if (MutateCSharp.Schemata268.ReplaceBinExprOp_2(25L, extension, MutateCSharp.Schemata268.ReplaceStringConstant_0(24L, ".dll")))
            {
                var dllResult = HandleDll(options, uri, uriOrigin);
                if (MutateCSharp.Schemata268.ReplaceBinExprOp_4(26L, dllResult, null))
                {
                    yield return dllResult;
                }
                yield break;
            }

            var handler = ExtensionHandlers.GetValueOrDefault(extension);
            if (MutateCSharp.Schemata268.ReplaceBinExprOp_5(27L, handler, null))
            {
                await foreach (var result in handler(options, fileSystem, reporter, uri, uriOrigin, asLibrary))
                {
                    yield return result;
                }
                yield break;
            }
            if (errorOnNotRecognized != null)
            {
                reporter.Error(MessageSource.Project, Token.Cli, errorOnNotRecognized);
            }

            yield break;
        }

        public static readonly Option<bool> UnsafeDependencies = new(MutateCSharp.Schemata268.ReplaceStringConstant_0(28L, "--dont-verify-dependencies"),
      MutateCSharp.Schemata268.ReplaceStringConstant_0(29L, "Allows Dafny to accept dependencies that may not have been previously verified, which can be useful during development."));

        public static DafnyFile? HandleDafnyFile(IFileSystem fileSystem,
          ErrorReporter reporter,
          DafnyOptions options,
          Uri uri, IToken origin, bool asLibrary = false, bool warnLibrary = true)
        {
            string canonicalPath;
            string baseName;
            if (uri.IsFile)
            {
                baseName = Path.GetFileName(uri.LocalPath);
                // Normalizing symbolic links appears to be not
                // supported in .Net APIs, because it is very difficult in general
                // So we will just use the absolute path, lowercased for all file systems.
                // cf. IncludeComparer.CompareTo
                canonicalPath = Canonicalize(uri.LocalPath).LocalPath;
            }
            else
            {
                canonicalPath = "";
                baseName = "";
            }

            var filePath = uri.LocalPath;
            if (!fileSystem.Exists(uri))
            {
                if (MutateCSharp.Schemata268.ReplaceBinExprOp_7(34L, MutateCSharp.Schemata268.ReplaceNumericConstant_6(30L, 0), options.VerifySnapshots))
                {
                    // For snapshots, we first create broken DafnyFile without content,
                    // then look for the real files and create DafnuFiles for them.
                    return new DafnyFile(DafnyFileExtension, canonicalPath, baseName, null!, uri, origin, null!);
                }

                reporter.Error(MessageSource.Project, origin, $"file {options.GetPrintPath(filePath)} not found");
                return null;
            }

            if (MutateCSharp.Schemata268.ReplaceBinExprOp_8(45L, () => MutateCSharp.Schemata268.ReplaceBinExprOp_8(39L, () => !options.Get(UnsafeDependencies), () => asLibrary), () => warnLibrary))
            {
                reporter.Warning(MessageSource.Project, "", origin,
                  $"The file '{options.GetPrintPath(filePath)}' was passed to --library. " +
                  $"Verification for that file might have used options incompatible with the current ones, or might have been skipped entirely. " +
                  $"Use a .doo file to enable Dafny to check that compatible options were used");
            }

            return new DafnyFile(DafnyFileExtension, canonicalPath, baseName, () => fileSystem.ReadFile(uri), uri, origin, options)
            {
                ShouldNotCompile = asLibrary,
                ShouldNotVerify = asLibrary,
            };
        }

        public static DafnyFile HandleStandardInput(DafnyOptions options, IToken origin)
        {
            return new DafnyFile(DafnyFileExtension, MutateCSharp.Schemata268.ReplaceStringConstant_0(51L, "<stdin>"), MutateCSharp.Schemata268.ReplaceStringConstant_0(52L, "<stdin>"), () => options.Input, new Uri(MutateCSharp.Schemata268.ReplaceStringConstant_0(53L, "stdin:///")), origin, options)
            {
                ShouldNotCompile = MutateCSharp.Schemata268.ReplaceBooleanConstant_9(54L, false),
                ShouldNotVerify = MutateCSharp.Schemata268.ReplaceBooleanConstant_9(55L, false),
            };
        }

        /// <summary>
        /// Technically only for C#, this is for backwards compatability
        /// </summary>
        private static DafnyFile? HandleDll(DafnyOptions parseOptions, Uri uri, IToken origin)
        {

            string baseName;
            string canonicalPath;
            if (uri.IsFile)
            {
                baseName = Path.GetFileName(uri.LocalPath);
                // Normalizing symbolic links appears to be not
                // supported in .Net APIs, because it is very difficult in general
                // So we will just use the absolute path, lowercased for all file systems.
                // cf. IncludeComparer.CompareTo
                canonicalPath = Canonicalize(uri.LocalPath).LocalPath;
            }
            else
            {
                canonicalPath = "";
                baseName = "";
            }

            var filePath = uri.LocalPath;
            var sourceText = GetDafnySourceAttributeText(filePath);
            if (sourceText == null)
            {
                return null;
            }

            return new DafnyFile(MutateCSharp.Schemata268.ReplaceStringConstant_0(56L, ".dll"), canonicalPath, baseName,
              () => new StringReader(sourceText), uri, origin, parseOptions)
            {
                ShouldNotCompile = MutateCSharp.Schemata268.ReplaceBooleanConstant_9(57L, true),
                ShouldNotVerify = MutateCSharp.Schemata268.ReplaceBooleanConstant_9(58L, true),
            };
        }

        public delegate Task<int> Executor(TextWriter outputWriter, TextWriter errorWriter, string[] arguments);

        public static async IAsyncEnumerable<DafnyFile> HandleDooFile(IFileSystem fileSystem,
          ErrorReporter reporter,
          DafnyOptions options,
          Uri uri, IToken origin, bool asLibrary)
        {
            DooFile dooFile;
            var filePath = uri.LocalPath;

            if (MutateCSharp.Schemata268.ReplaceBinExprOp_2(60L, uri.Scheme, MutateCSharp.Schemata268.ReplaceStringConstant_0(59L, "dllresource")))
            {
                var assembly = Assembly.Load(uri.Host);
                // Skip the leading "/"
                var resourceName = uri.LocalPath[1..];
                await using var stream = assembly.GetManifestResourceStream(resourceName);
                if (stream is null)
                {
                    throw new Exception($"Cannot find embedded resource: {resourceName}");
                }

                dooFile = await DooFile.Read(stream);
            }
            else
            {
                if (!fileSystem.Exists(uri))
                {
                    reporter.Error(MessageSource.Project, origin, $"file {options.GetPrintPath(filePath)} not found");
                    yield break;
                }

                try
                {
                    dooFile = await DooFile.Read(filePath);
                }
                catch (InvalidDataException)
                {
                    reporter.Error(MessageSource.Project, origin, $"malformed doo file {options.GetPrintPath(filePath)}");
                    yield break;
                }
                catch (ArgumentException e)
                {
                    reporter.Error(MessageSource.Project, origin, e.Message);
                    yield break;
                }
            }

            var validDooOptions = dooFile.Validate(reporter, uri, options, origin);
            if (MutateCSharp.Schemata268.ReplaceBinExprOp_10(61L, validDooOptions, null))
            {
                yield break;
            }

            // For now it's simpler to let the rest of the pipeline parse the
            // program text back into the AST representation.
            // At some point we'll likely want to serialize a program
            // more efficiently inside a .doo file, at which point
            // the DooFile class should encapsulate the serialization logic better
            // and expose a Program instead of the program text.
            yield return new DafnyFile(DooFile.Extension, Canonicalize(uri.LocalPath).LocalPath, Path.GetFileName(uri.LocalPath),
              () => new StringReader(dooFile.ProgramText), uri, origin, validDooOptions)
            {
                ShouldNotCompile = asLibrary,
                ShouldNotVerify = MutateCSharp.Schemata268.ReplaceBooleanConstant_9(62L, true),
            };
        }

        protected DafnyFile(string extension, string canonicalPath, string baseName,
          Func<TextReader> getContent, Uri uri, IToken? origin, DafnyOptions fileOptions)
        {
            Extension = extension;
            CanonicalPath = canonicalPath;
            BaseName = baseName;
            GetContent = getContent;
            Uri = uri;
            Origin = origin;
            FileOptions = fileOptions;
        }

        // Returns a canonical string for the given file path, namely one which is the same
        // for all paths to a given file and different otherwise. The best we can do is to
        // make the path absolute -- detecting case and canonicalizing symbolic and hard
        // links are difficult across file systems (which may mount parts of other filesystems,
        // with different characteristics) and is not supported by .Net libraries
        public static Uri Canonicalize(string? filePath)
        {
            if (MutateCSharp.Schemata268.ReplaceBinExprOp_3(64L, () => filePath == null, () => !filePath.StartsWith(MutateCSharp.Schemata268.ReplaceStringConstant_0(63L, "file:"))))
            {
                return new Uri(Path.GetFullPath(filePath!));
            }

            if (Uri.IsWellFormedUriString(filePath, UriKind.RelativeOrAbsolute))
            {
                return new Uri(filePath);
            }

            var potentialPrefixes = new List<string>() { MutateCSharp.Schemata268.ReplaceStringConstant_0(70L, "file:\\"), MutateCSharp.Schemata268.ReplaceStringConstant_0(71L, "file:/"), MutateCSharp.Schemata268.ReplaceStringConstant_0(72L, "file:") };
            foreach (var potentialPrefix in potentialPrefixes)
            {
                if (filePath.StartsWith(potentialPrefix))
                {
                    var withoutPrefix = filePath.Substring(potentialPrefix.Length);
                    var tentativeURI = MutateCSharp.Schemata268.ReplaceStringConstant_0(73L, "file:///") + withoutPrefix.Replace(MutateCSharp.Schemata268.ReplaceStringConstant_0(74L, "\\"), MutateCSharp.Schemata268.ReplaceStringConstant_0(75L, "/"));
                    if (Uri.IsWellFormedUriString(tentativeURI, UriKind.RelativeOrAbsolute))
                    {
                        return new Uri(tentativeURI);
                    }
                    // Recovery mechanisms for the language server
                    return new Uri(filePath.Substring(potentialPrefix.Length));
                }
            }
            return new Uri(filePath.Substring(MutateCSharp.Schemata268.ReplaceStringConstant_0(76L, "file:").Length));
        }
        public static List<string> FileNames(IReadOnlyList<DafnyFile> dafnyFiles)
        {
            var sourceFiles = new List<string>();
            foreach (DafnyFile f in dafnyFiles)
            {
                sourceFiles.Add(f.FilePath);
            }
            return sourceFiles;
        }

        private static string? GetDafnySourceAttributeText(string dllPath)
        {
            if (!File.Exists(dllPath))
            {
                return null;
            }
            using var dllFs = new FileStream(dllPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            using var dllPeReader = new PEReader(dllFs);
            var dllMetadataReader = dllPeReader.GetMetadataReader();

            foreach (var attrHandle in dllMetadataReader.CustomAttributes)
            {
                var attr = dllMetadataReader.GetCustomAttribute(attrHandle);
                try
                {
                    /* The cast from EntityHandle to MemberReferenceHandle is overriden, uses private members, and throws
                     * an InvalidCastException if it fails. We have no other option than to use it and catch the exception.
                     */
                    var constructor = dllMetadataReader.GetMemberReference((MemberReferenceHandle)attr.Constructor);
                    var attrType = dllMetadataReader.GetTypeReference((TypeReferenceHandle)constructor.Parent);
                    if (MutateCSharp.Schemata268.ReplaceBinExprOp_2(78L, dllMetadataReader.GetString(attrType.Name), MutateCSharp.Schemata268.ReplaceStringConstant_0(77L, "DafnySourceAttribute")))
                    {
                        var decoded = attr.DecodeValue(new StringOnlyCustomAttributeTypeProvider());
                        return decoded.FixedArguments[MutateCSharp.Schemata268.ReplaceNumericConstant_6(79L, 0)].Value as string;
                    }
                }
                catch (InvalidCastException)
                {
                    // Ignore - the Handle casts are handled as custom explicit operators,
                    // and there's no way I can see to test if the cases will succeed ahead of time.
                }
            }

            return null;
        }

    }
}