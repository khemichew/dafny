#nullable enable
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Extensions.FileSystemGlobbing.Abstractions;
namespace MutateCSharp
{
    internal class Schemata301
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT301");
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

        internal static bool ReplaceBinExprOp_1(long mutantId, int argument1, int argument2)
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

namespace Microsoft.Dafny.LanguageServer.Workspace
{

    /// <summary>
    /// Merges multiple filesystems into a combined one.
    /// The order in which the filesystems are given matters,
    /// when multiple filesystem contain the same file, the first containing filesystem returns it.
    /// </summary>
    public class CombinedDirectoryInfo : DirectoryInfoBase
    {
        public DirectoryInfoBase[] Parts { get; }

        public CombinedDirectoryInfo(DirectoryInfoBase[] parts)
        {
            this.Parts = parts;
        }

        public override string Name => Parts[MutateCSharp.Schemata301.ReplaceNumericConstant_0(1L, 0)].Name;
        public override string FullName => Parts[MutateCSharp.Schemata301.ReplaceNumericConstant_0(5L, 0)].FullName;

        public override DirectoryInfoBase ParentDirectory =>
          new CombinedDirectoryInfo(Parts.Select(part => part.ParentDirectory).ToArray());

        public override IEnumerable<FileSystemInfoBase> EnumerateFileSystemInfos()
        {
            return Parts.SelectMany(part => part.EnumerateFileSystemInfos()).GroupBy(f => f.FullName).SelectMany(g =>
            {
                // Just like when reading file contents, give priority to the earlier Parts.
                var first = g.First();
                if (first is FileInfoBase)
                {
                    // Files can not be combined
                    return new[] { first };
                }

                // First is a directory, combine all directories
                var directories = g.OfType<DirectoryInfoBase>().ToArray();
                if (MutateCSharp.Schemata301.ReplaceBinExprOp_1(13L, directories.Length, MutateCSharp.Schemata301.ReplaceNumericConstant_0(9L, 1)))
                {
                    return new[] { directories[MutateCSharp.Schemata301.ReplaceNumericConstant_0(18L, 0)] };
                }
                return new[] { new CombinedDirectoryInfo(directories) };
            });
        }

        public override DirectoryInfoBase GetDirectory(string path)
        {
            return new CombinedDirectoryInfo(Parts.Select(part => part.GetDirectory(path)).ToArray());
        }

        public override FileInfoBase GetFile(string path)
        {
            Exception? lastException = null;
            foreach (var part in Parts)
            {
                try
                {
                    return part.GetFile(path);
                }
                catch (IOException e)
                {
                    lastException = e;
                }
            }

            throw lastException!;
            return default;
        }
    }
}