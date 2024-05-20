#nullable enable
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Extensions.FileSystemGlobbing.Abstractions;
namespace MutateCSharp
{
    internal class Schemata329
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT329");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplaceBinExprOp_3(long mutantId, int argument1, int argument2)
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

        internal static int ReplaceBinExprOp_2(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBooleanConstant_0(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static string ReplaceStringConstant_7(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static int ReplaceNumericConstant_1(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

    }
}

namespace DafnyCore.Options
{

    /// <summary>
    /// Contains a bugfix that's available in DotNet8
    /// https://github.com/dotnet/runtime/issues/88135
    /// </summary>
    public class InMemoryDirectoryInfoFromDotNet8 : DirectoryInfoBase
    {
        private static readonly char[] DirectorySeparators = new[] { Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar };
        private readonly IEnumerable<string> _files;

        /// <summary>
        /// Creates a new InMemoryDirectoryInfo with the root directory and files given.
        /// </summary>
        /// <param name="rootDir">The root directory that this FileSystem will use.</param>
        /// <param name="files">Collection of file names. If relative paths <paramref name="rootDir"/> will be prepended to the paths.</param>
        public InMemoryDirectoryInfoFromDotNet8(string rootDir, IEnumerable<string>? files)
          : this(rootDir, files, MutateCSharp.Schemata329.ReplaceBooleanConstant_0(1L, false))
        {
        }

        private InMemoryDirectoryInfoFromDotNet8(string rootDir, IEnumerable<string>? files, bool normalized)
        {
            if (string.IsNullOrEmpty(rootDir))
            {
                throw new ArgumentNullException(nameof(rootDir));
            }

            files ??= new List<string>();

            Name = Path.GetFileName(rootDir);
            if (normalized)
            {
                _files = files;
                FullName = rootDir;
            }
            else
            {
                var fileList = new List<string>(files.Count());

                // normalize
                foreach (string file in files)
                {
                    fileList.Add(Path.GetFullPath(file.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar)));
                }

                _files = fileList;

                FullName = Path.GetFullPath(rootDir.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar));
            }
        }

        /// <inheritdoc />
        public override string FullName { get; }

        /// <inheritdoc />
        public override string Name { get; }

        /// <inheritdoc />
        public override DirectoryInfoBase? ParentDirectory =>
          new InMemoryDirectoryInfoFromDotNet8(Path.GetDirectoryName(FullName)!, _files, MutateCSharp.Schemata329.ReplaceBooleanConstant_0(2L, true));

        /// <inheritdoc />
        public override IEnumerable<FileSystemInfoBase> EnumerateFileSystemInfos()
        {
            var dict = new Dictionary<string, List<string>>();
            foreach (string file in _files)
            {
                if (!IsRootDirectory(FullName, file))
                {
                    continue;
                }

                int endPath = file.Length;
                int beginSegment = MutateCSharp.Schemata329.ReplaceBinExprOp_2(7L, FullName.Length, MutateCSharp.Schemata329.ReplaceNumericConstant_1(3L, 1));
                int endSegment = file.IndexOfAny(DirectorySeparators, beginSegment, MutateCSharp.Schemata329.ReplaceBinExprOp_3(16L, endPath, beginSegment));

                if (MutateCSharp.Schemata329.ReplaceBinExprOp_4(29L, endSegment, MutateCSharp.Schemata329.ReplaceNumericConstant_1(25L, -1)))
                {
                    yield return new InMemoryFileInfo(file, this);
                }
                else
                {
                    string name = file.Substring(MutateCSharp.Schemata329.ReplaceNumericConstant_1(34L, 0), endSegment);
                    if (!dict.TryGetValue(name, out List<string>? list))
                    {
                        dict[name] = new List<string> { file };
                    }
                    else
                    {
                        list.Add(file);
                    }
                }
            }

            foreach (KeyValuePair<string, List<string>> item in dict)
            {
                yield return new InMemoryDirectoryInfoFromDotNet8(item.Key, item.Value, MutateCSharp.Schemata329.ReplaceBooleanConstant_0(38L, true));
            }

            yield break;
        }

        private static bool IsRootDirectory(string rootDir, string filePath)
        {
            int rootDirLength = rootDir.Length;

            return MutateCSharp.Schemata329.ReplaceBinExprOp_6(68L, () => filePath.StartsWith(rootDir, StringComparison.Ordinal), () => (MutateCSharp.Schemata329.ReplaceBinExprOp_5(62L, () => MutateCSharp.Schemata329.ReplaceBinExprOp_4(52L, rootDir[MutateCSharp.Schemata329.ReplaceBinExprOp_3(43L, rootDirLength, MutateCSharp.Schemata329.ReplaceNumericConstant_1(39L, 1))], Path.DirectorySeparatorChar), () => MutateCSharp.Schemata329.ReplaceBinExprOp_4(57L, filePath.IndexOf(Path.DirectorySeparatorChar, rootDirLength), rootDirLength))));
        }

        /// <inheritdoc />
        public override DirectoryInfoBase GetDirectory(string path)
        {
            if (string.Equals(path, MutateCSharp.Schemata329.ReplaceStringConstant_7(74L, ".."), StringComparison.Ordinal))
            {
                return new InMemoryDirectoryInfoFromDotNet8(Path.Combine(FullName, path), _files, MutateCSharp.Schemata329.ReplaceBooleanConstant_0(75L, true));
            }
            else
            {
                string normPath = Path.GetFullPath(path.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar));
                return new InMemoryDirectoryInfoFromDotNet8(normPath, _files, MutateCSharp.Schemata329.ReplaceBooleanConstant_0(76L, true));
            }

            return default;
        }

        /// <summary>
        /// Returns an instance of <see cref="FileInfoBase"/> that matches the <paramref name="path"/> given.
        /// </summary>
        /// <param name="path">The filename.</param>
        /// <returns>Instance of <see cref="FileInfoBase"/> if the file exists, null otherwise.</returns>
        public override FileInfoBase? GetFile(string path)
        {
            string normPath = Path.GetFullPath(path.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar));
            foreach (string file in _files)
            {
                if (string.Equals(file, normPath))
                {
                    return new InMemoryFileInfo(file, this);
                }
            }

            return null;
        }

        public sealed class InMemoryFileInfo : FileInfoBase
        {
            private readonly InMemoryDirectoryInfoFromDotNet8 _parent;

            public InMemoryFileInfo(string file, InMemoryDirectoryInfoFromDotNet8 parent)
            {
                FullName = file;
                Name = Path.GetFileName(file);
                _parent = parent;
            }

            public override string FullName { get; }
            public override string Name { get; }

            public override DirectoryInfoBase ParentDirectory => _parent;
        }
    }
}