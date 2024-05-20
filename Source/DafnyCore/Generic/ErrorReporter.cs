using System;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata306
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT306");
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

        internal static int ReplaceNumericConstant_1(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
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

        internal static bool ReplaceBinExprOp_2(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public abstract class ErrorReporter
    {
        public DafnyOptions Options { get; }

        protected ErrorReporter(DafnyOptions options)
        {
            this.Options = options;
        }

        public bool ErrorsOnly { get; set; }

        public bool FailCompilation => FailCompilationMessage != null;

        public string FailCompilationMessage
        {
            get
            {
                if (HasErrors)
                {
                    return MutateCSharp.Schemata306.ReplaceStringConstant_0(1L, "errors were found");
                }

                if (MutateCSharp.Schemata306.ReplaceBinExprOp_3(11L, () => MutateCSharp.Schemata306.ReplaceBinExprOp_2(6L, WarningCount, MutateCSharp.Schemata306.ReplaceNumericConstant_1(2L, 0)), () => Options.FailOnWarnings))
                {
                    return MutateCSharp.Schemata306.ReplaceStringConstant_0(17L, "warnings were found and --allow-warnings was not specified");
                }
                return null;
            }
        }

        public int ErrorCount => Count(ErrorLevel.Error);

        public bool HasErrors => MutateCSharp.Schemata306.ReplaceBinExprOp_2(22L, ErrorCount, MutateCSharp.Schemata306.ReplaceNumericConstant_1(18L, 0));
        public int WarningCount => Count(ErrorLevel.Warning);

        public int ErrorCountUntilResolver => CountExceptVerifierAndCompiler(ErrorLevel.Error);

        public bool Message(MessageSource source, ErrorLevel level, string errorId, IToken tok, string msg)
        {
            return MessageCore(source, level, errorId, tok, msg);
        }

        protected abstract bool MessageCore(MessageSource source, ErrorLevel level, string errorId, IToken tok, string msg);

        public void Error(MessageSource source, IToken tok, string msg)
        {
            Error(source, ParseErrors.ErrorId.none, tok, msg);
        }
        public virtual void Error(MessageSource source, string errorId, IToken tok, string msg)
        {
            Contract.Requires(tok != null);
            Contract.Requires(msg != null);
            Message(source, ErrorLevel.Error, errorId, tok, msg);
        }

        public abstract int Count(ErrorLevel level);
        public abstract int CountExceptVerifierAndCompiler(ErrorLevel level);

        // This method required by the Parser
        internal void Error(MessageSource source, Enum errorId, Uri uri, int line, int col, string msg)
        {
            var tok = new Token(line, col);
            tok.Uri = uri;
            Error(source, errorId, tok, msg);
        }

        public void Error(MessageSource source, IToken tok, string format, params object[] args)
        {
            Contract.Requires(tok != null);
            Contract.Requires(format != null);
            Contract.Requires(args != null);
            Error(source, ParseErrors.ErrorId.none, tok, format, args);
        }

        public void Error(MessageSource source, Enum errorId, IToken tok, string format, params object[] args)
        {
            Contract.Requires(tok != null);
            Contract.Requires(format != null);
            Contract.Requires(args != null);
            Error(source, errorId.ToString(), tok, string.Format(format, args));
        }

        public void Error(MessageSource source, Enum errorId, IToken tok, string msg)
        {
            Contract.Requires(tok != null);
            Contract.Requires(msg != null);
            Error(source, errorId.ToString(), tok, msg);
        }

        public void Error(MessageSource source, Declaration d, string format, params object[] args)
        {
            Contract.Requires(d != null);
            Contract.Requires(format != null);
            Contract.Requires(args != null);
            Error(source, ParseErrors.ErrorId.none, d.tok, format, args);
        }

        public void Error(MessageSource source, Enum errorId, Declaration d, string msg, params object[] args)
        {
            Contract.Requires(d != null);
            Contract.Requires(msg != null);
            Contract.Requires(args != null);
            Error(source, errorId, d.tok, msg, args);
        }

        public void Error(MessageSource source, Enum errorId, Statement s, string format, params object[] args)
        {
            Contract.Requires(s != null);
            Contract.Requires(format != null);
            Contract.Requires(args != null);
            Error(source, errorId, s.Tok, format, args);
        }

        public void Error(MessageSource source, Statement s, string format, params object[] args)
        {
            Contract.Requires(s != null);
            Contract.Requires(format != null);
            Contract.Requires(args != null);
            Error(source, ParseErrors.ErrorId.none, s.Tok, format, args);
        }

        public void Error(MessageSource source, INode v, string format, params object[] args)
        {
            Contract.Requires(v != null);
            Contract.Requires(format != null);
            Contract.Requires(args != null);
            Error(source, ParseErrors.ErrorId.none, v.Tok, format, args);
        }

        public void Error(MessageSource source, Enum errorId, INode v, string format, params object[] args)
        {
            Contract.Requires(v != null);
            Contract.Requires(format != null);
            Contract.Requires(args != null);
            Error(source, errorId, v.Tok, format, args);
        }

        public void Error(MessageSource source, Enum errorId, Expression e, string format, params object[] args)
        {
            Contract.Requires(e != null);
            Contract.Requires(format != null);
            Contract.Requires(args != null);
            Error(source, errorId, e.tok, format, args);
        }

        public void Error(MessageSource source, Expression e, string format, params object[] args)
        {
            Contract.Requires(e != null);
            Contract.Requires(format != null);
            Contract.Requires(args != null);
            Error(source, ParseErrors.ErrorId.none, e.tok, format, args);
        }

        public void Warning(MessageSource source, Enum errorId, IToken tok, string format, params object[] args)
        {
            Contract.Requires(tok != null);
            Contract.Requires(format != null);
            Contract.Requires(args != null);
            Warning(source, errorId, tok, String.Format(format, args));
        }

        public void Warning(MessageSource source, Enum errorId, IToken tok, string msg)
        {
            Contract.Requires(tok != null);
            Contract.Requires(msg != null);
            Message(source, ErrorLevel.Warning, errorId.ToString(), tok, msg);
        }

        public void Warning(MessageSource source, string errorId, IToken tok, string msg)
        {
            Contract.Requires(tok != null);
            Contract.Requires(msg != null);
            Message(source, ErrorLevel.Warning, errorId, tok, msg);
        }

        public void Deprecated(MessageSource source, string errorId, IToken tok, string msg)
        {
            Contract.Requires(tok != null);
            Contract.Requires(msg != null);
            if (MutateCSharp.Schemata306.ReplaceBinExprOp_4(31L, Options.DeprecationNoise, MutateCSharp.Schemata306.ReplaceNumericConstant_1(27L, 0)))
            {
                Warning(source, errorId, tok, msg);
            }
            else
            {
                Info(source, tok, msg, errorId);
            }
        }

        public void Deprecated(MessageSource source, Enum errorId, IToken tok, string msg)
        {
            Contract.Requires(tok != null);
            Contract.Requires(msg != null);
            if (MutateCSharp.Schemata306.ReplaceBinExprOp_4(40L, Options.DeprecationNoise, MutateCSharp.Schemata306.ReplaceNumericConstant_1(36L, 0)))
            {
                Warning(source, errorId, tok, msg);
            }
            else
            {
                Info(source, tok, msg, errorId);
            }
        }

        public void Deprecated(MessageSource source, Enum errorId, IToken tok, string format, params object[] args)
        {
            Contract.Requires(tok != null);
            Contract.Requires(format != null);
            Contract.Requires(args != null);
            if (MutateCSharp.Schemata306.ReplaceBinExprOp_4(49L, Options.DeprecationNoise, MutateCSharp.Schemata306.ReplaceNumericConstant_1(45L, 0)))
            {
                Warning(source, errorId, tok, String.Format(format, args));
            }
        }

        public void Info(MessageSource source, IToken tok, string msg, object errorId = null)
        {
            Contract.Requires(tok != null);
            Contract.Requires(msg != null);
            Message(source, ErrorLevel.Info, errorId?.ToString(), tok, msg);
        }

        public void Info(MessageSource source, IToken tok, string msg, params object[] args)
        {
            Contract.Requires(tok != null);
            Contract.Requires(msg != null);
            Contract.Requires(args != null);
            Info(source, tok, String.Format(msg, args));
        }

        public string ErrorToString(ErrorLevel header, IToken tok, string msg)
        {
            return $"{tok.TokenToString(Options)}: {header.ToString()}: {msg}";
        }
    }
}