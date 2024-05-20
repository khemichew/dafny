using System;
using System.Linq;
using OmniSharp.Extensions.LanguageServer.Protocol;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;
namespace MutateCSharp
{
    internal class Schemata335
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT335");
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
    public static class DiagnosticUtil
    {
        public static Diagnostic ToLspDiagnostic(this DafnyDiagnostic dafnyDiagnostic)
        {
            return new Diagnostic
            {
                Code = dafnyDiagnostic.ErrorId,
                Severity = ToSeverity(dafnyDiagnostic.Level),
                Message = dafnyDiagnostic.Message,
                Range = dafnyDiagnostic.Token.GetLspRange(),
                Source = dafnyDiagnostic.Source.ToString(),
                RelatedInformation = dafnyDiagnostic.RelatedInformation.Select(r =>
                  new DiagnosticRelatedInformation
                  {
                      Location = CreateLocation(r.Token),
                      Message = r.Message
                  }).ToList(),
                CodeDescription = dafnyDiagnostic.ErrorId == null
                ? null
                : new CodeDescription { Href = new Uri(MutateCSharp.Schemata335.ReplaceStringConstant_0(1L, "https://dafny.org/dafny/HowToFAQ/Errors#") + dafnyDiagnostic.ErrorId) },
            };
        }

        public static Location CreateLocation(IToken token)
        {
            var uri = DocumentUri.Parse(token.Uri.AbsoluteUri);
            return new Location
            {
                Range = token.GetLspRange(),
                // During parsing, we store absolute paths to make reconstructing the Uri easier
                // https://github.com/dafny-lang/dafny/blob/06b498ee73c74660c61042bb752207df13930376/Source/DafnyLanguageServer/Language/DafnyLangParser.cs#L59 
                Uri = uri
            };
        }

        private static DiagnosticSeverity ToSeverity(ErrorLevel level)
        {
            return level switch
            {
                ErrorLevel.Error => DiagnosticSeverity.Error,
                ErrorLevel.Warning => DiagnosticSeverity.Warning,
                ErrorLevel.Info => DiagnosticSeverity.Hint,
                _ => throw new ArgumentException($"unknown error level {level}", nameof(level))
            };
        }
    }
}