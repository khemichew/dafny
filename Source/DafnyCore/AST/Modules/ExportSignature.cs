using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata122
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT122");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
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
    public class ExportSignature : TokenNode, IHasUsages
    {
        public readonly IToken ClassIdTok;
        public readonly bool Opaque;
        public readonly string ClassId;
        public readonly string Id;

        [FilledInDuringResolution] public Declaration Decl;

        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(Tok != null);
            Contract.Invariant(Id != null);
            Contract.Invariant((ClassId != null) == (ClassIdTok != null));
        }

        public ExportSignature(IToken prefixTok, string prefix, IToken idTok, string id, bool opaque)
        {
            Contract.Requires(prefixTok != null);
            Contract.Requires(prefix != null);
            Contract.Requires(idTok != null);
            Contract.Requires(id != null);
            tok = idTok;
            ClassIdTok = prefixTok;
            ClassId = prefix;
            Id = id;
            Opaque = opaque;
            OwnedTokensCache = new List<IToken>() { Tok, prefixTok };
        }

        public ExportSignature(IToken idTok, string id, bool opaque)
        {
            Contract.Requires(idTok != null);
            Contract.Requires(id != null);
            tok = idTok;
            Id = id;
            Opaque = opaque;
            OwnedTokensCache = new List<IToken>() { Tok };
        }

        public ExportSignature(Cloner cloner, ExportSignature original)
        {
            tok = cloner.Tok(original.Tok);
            Id = original.Id;
            Opaque = original.Opaque;
            ClassId = original.ClassId;
            ClassIdTok = cloner.Tok(original.ClassIdTok);
            OwnedTokensCache = new List<IToken>() { Tok };
        }

        public override string ToString()
        {
            if (ClassId != null)
            {
                return ClassId + MutateCSharp.Schemata122.ReplaceStringConstant_0(1L, ".") + Id;
            }
            return Id;
        }

        public IToken NameToken => Tok;
        public override IEnumerable<INode> Children => Enumerable.Empty<Node>();
        public override IEnumerable<INode> PreResolveChildren => Enumerable.Empty<Node>();
        public IEnumerable<IDeclarationOrUsage> GetResolvedDeclarations()
        {
            return new[] { Decl };
        }
    }
}