using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DafnyCore.Options;
using Microsoft.Dafny.LanguageServer.Workspace;
using Microsoft.Extensions.FileSystemGlobbing.Abstractions;
namespace MutateCSharp
{
    internal class Schemata86
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT86");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

namespace Microsoft.Dafny
{
    public interface IFileSystem
    {
        TextReader ReadFile(Uri uri);

        public bool Exists(Uri path);
        DirectoryInfoBase GetDirectoryInfoBase(string root);
    }

    public class InMemoryFileSystem : IFileSystem
    {
        private readonly IReadOnlyDictionary<Uri, string> files;

        public InMemoryFileSystem(IReadOnlyDictionary<Uri, string> files)
        {
            this.files = files;
        }

        public TextReader ReadFile(Uri uri)
        {
            if (files.TryGetValue(uri, out var entry))
            {
                return new StringReader(entry);
            }

            return OnDiskFileSystem.Instance.ReadFile(uri);
        }

        public bool Exists(Uri path)
        {
            return MutateCSharp.Schemata86.ReplaceBinExprOp_0(1L, () => files.ContainsKey(path), () => OnDiskFileSystem.Instance.Exists(path));
        }

        public DirectoryInfoBase GetDirectoryInfoBase(string root)
        {
            var inMemoryFiles = files.Keys.Select(openFileUri => openFileUri.LocalPath);
            var inMemory = new InMemoryDirectoryInfoFromDotNet8(root, inMemoryFiles);
            return new CombinedDirectoryInfo(new[] { inMemory, OnDiskFileSystem.Instance.GetDirectoryInfoBase(root) });
        }
    }

    public class OnDiskFileSystem : IFileSystem
    {
        public static readonly IFileSystem Instance = new OnDiskFileSystem();

        private OnDiskFileSystem()
        {
        }

        public TextReader ReadFile(Uri uri)
        {
            return new StreamReader(uri.LocalPath);
        }

        public bool Exists(Uri path)
        {
            return File.Exists(path.LocalPath);
        }

        public DirectoryInfoBase GetDirectoryInfoBase(string root)
        {
            return new CustomDirectoryInfoWrapper(new DirectoryInfo(root!));
        }
    }
}