using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata116
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT116");
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

    }
}

namespace Microsoft.Dafny
{

    /// <summary>
    /// Represents "module name as path [ = compilePath];", where name is a identifier and path is a possibly qualified name.
    /// Used to be called ModuleFacadeDecl -- renamed to be like LiteralModuleDecl, AliasModuleDecl
    /// </summary>
    public class AbstractModuleDecl : ModuleDecl, ICanFormat
    {
        public readonly ModuleQualifiedId QId;
        public readonly List<IToken> Exports; // list of exports sets
        public ModuleDecl CompileRoot;
        public ModuleSignature OriginalSignature;

        public AbstractModuleDecl(Cloner cloner, AbstractModuleDecl original, ModuleDefinition parent)
          : base(cloner, original, parent)
        {
            Exports = original.Exports;
            QId = new ModuleQualifiedId(cloner, original.QId);
        }

        public AbstractModuleDecl(DafnyOptions options, RangeToken rangeToken, ModuleQualifiedId qid, Name name,
          ModuleDefinition parent, bool opened, List<IToken> exports, Guid cloneId)
          : base(options, rangeToken, name, parent, opened, MutateCSharp.Schemata116.ReplaceBooleanConstant_0(1L, false), cloneId)
        {
            Contract.Requires(qid != null && qid.Path.Count > 0);
            Contract.Requires(exports != null);

            QId = qid;
            Exports = exports;
        }

        public override object Dereference() { return this; }
        public bool SetIndent(int indentBefore, TokenNewIndentCollector formatter)
        {
            foreach (var token in OwnedTokens)
            {
                switch (token.val)
                {
                    case "import":
                        {
                            formatter.SetOpeningIndentedRegion(token, indentBefore);
                            break;
                        }

                        break;
                    case ":":
                        {
                            break;
                        }

                        break;
                }
            }

            return MutateCSharp.Schemata116.ReplaceBooleanConstant_0(2L, true);
        }
    }
}