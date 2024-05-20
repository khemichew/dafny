// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#nullable enable
using System;
using System.Collections.Generic;
using System.IO;
namespace MutateCSharp
{
    internal class Schemata85
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT85");
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

        internal static int ReplaceNumericConstant_2(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
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

    }
}

namespace Microsoft.Extensions.FileSystemGlobbing.Abstractions
{
    /// <summary>
    /// Wraps an instance of <see cref="System.IO.DirectoryInfo" /> and provides implementation of
    /// <see cref="DirectoryInfoBase" />.
    /// </summary>
    public class CustomDirectoryInfoWrapper : DirectoryInfoBase
    {
        private readonly DirectoryInfo _directoryInfo;
        private readonly bool _isParentPath;

        /// <summary>
        /// Initializes an instance of <see cref="CustomDirectoryInfoWrapper" />.
        /// </summary>
        /// <param name="directoryInfo">The <see cref="DirectoryInfo" />.</param>
        public CustomDirectoryInfoWrapper(DirectoryInfo directoryInfo)
            : this(directoryInfo, isParentPath: MutateCSharp.Schemata85.ReplaceBooleanConstant_0(1L, false)) { }

        private CustomDirectoryInfoWrapper(DirectoryInfo directoryInfo, bool isParentPath)
        {
            _directoryInfo = directoryInfo;
            _isParentPath = isParentPath;
        }

        /// <inheritdoc />
        public override IEnumerable<FileSystemInfoBase> EnumerateFileSystemInfos()
        {
            if (_directoryInfo.Exists)
            {
                IEnumerable<FileSystemInfo> fileSystemInfos;
                try
                {
                    fileSystemInfos = _directoryInfo.EnumerateFileSystemInfos(MutateCSharp.Schemata85.ReplaceStringConstant_1(2L, "*"), new EnumerationOptions
                    {
                        MatchType = MatchType.Win32,
                        AttributesToSkip = 0,
                        IgnoreInaccessible = MutateCSharp.Schemata85.ReplaceBooleanConstant_0(3L, true),
                        RecurseSubdirectories = MutateCSharp.Schemata85.ReplaceBooleanConstant_0(4L, false
          )
                    });
                }
                catch (DirectoryNotFoundException)
                {
                    yield break;
                }

                foreach (FileSystemInfo fileSystemInfo in fileSystemInfos)
                {
                    if (fileSystemInfo is DirectoryInfo directoryInfo)
                    {
                        yield return new CustomDirectoryInfoWrapper(directoryInfo);
                    }
                    else
                    {
                        yield return new FileInfoWrapper((FileInfo)fileSystemInfo);
                    }
                }
            }

            yield break;
        }

        /// <summary>
        /// Returns an instance of <see cref="DirectoryInfoBase" /> that represents a subdirectory.
        /// </summary>
        /// <remarks>
        /// If <paramref name="name" /> equals '..', this returns the parent directory.
        /// </remarks>
        /// <param name="name">The directory name</param>
        /// <returns>The directory</returns>
        public override DirectoryInfoBase? GetDirectory(string name)
        {
            bool isParentPath = string.Equals(name, MutateCSharp.Schemata85.ReplaceStringConstant_1(5L, ".."), StringComparison.Ordinal);

            if (isParentPath)
            {
                return new CustomDirectoryInfoWrapper(
                    new DirectoryInfo(Path.Combine(_directoryInfo.FullName, name)),
                    isParentPath);
            }
            else
            {
                DirectoryInfo[] dirs = _directoryInfo.GetDirectories(name);

                if (MutateCSharp.Schemata85.ReplaceBinExprOp_3(10L, dirs.Length, MutateCSharp.Schemata85.ReplaceNumericConstant_2(6L, 1)))
                {
                    return new CustomDirectoryInfoWrapper(dirs[MutateCSharp.Schemata85.ReplaceNumericConstant_2(15L, 0)], isParentPath);
                }
                else if (MutateCSharp.Schemata85.ReplaceBinExprOp_3(23L, dirs.Length, MutateCSharp.Schemata85.ReplaceNumericConstant_2(19L, 0)))
                {
                    return null;
                }
                else
                {
                    // This shouldn't happen. The parameter name isn't supposed to contain wild card.
                    throw new InvalidOperationException(
                        $"More than one sub directories are found under {_directoryInfo.FullName} with name {name}.");
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override FileInfoBase GetFile(string name)
            => new FileInfoWrapper(new FileInfo(Path.Combine(_directoryInfo.FullName, name)));

        /// <inheritdoc />
        public override string Name => _isParentPath ? MutateCSharp.Schemata85.ReplaceStringConstant_1(28L, "..") : _directoryInfo.Name;

        /// <summary>
        /// Returns the full path to the directory.
        /// </summary>
        /// <remarks>
        /// Equals the value of <seealso cref="System.IO.FileSystemInfo.FullName" />.
        /// </remarks>
        public override string FullName => _directoryInfo.FullName;

        /// <summary>
        /// Returns the parent directory.
        /// </summary>
        /// <remarks>
        /// Equals the value of <seealso cref="System.IO.DirectoryInfo.Parent" />.
        /// </remarks>
        public override DirectoryInfoBase ParentDirectory
            => new CustomDirectoryInfoWrapper(_directoryInfo.Parent!);
    }
}