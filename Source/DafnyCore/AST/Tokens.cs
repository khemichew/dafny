
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Text;
namespace MutateCSharp
{
    internal class Schemata181
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT181");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplaceBinExprOp_5(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_2(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static int ReplacePostfixUnaryExprOp_11(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
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

        internal static int ReplaceBinExprOp_12(long mutantId, int argument1, int argument2)
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

        internal static string ReplaceStringConstant_4(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_0(long mutantId, System.Uri argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.IToken argument1, Microsoft.Dafny.Token argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 <= argument2;
        }

        internal static bool ReplaceBinExprOp_14(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
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
    public interface IToken : Microsoft.Boogie.IToken, IComparable<IToken>
    {
        public RangeToken To(IToken end) => new RangeToken(this, end);

        /*
        int kind { get; set; }
        int pos { get; set; }
        int col { get; set; }
        int line { get; set; }
        string val { get; set; }
        bool IsValid { get; }*/
        string Boogie.IToken.filename { get => MutateCSharp.Schemata181.ReplaceBinExprOp_0(1L, Uri, null) ? null : Path.GetFileName(Uri.LocalPath);
    set => throw new NotSupportedException(); }

        public string ActualFilename => Uri.LocalPath;
        string Filepath => Uri.LocalPath;

        Uri Uri { get; set; }

        /// <summary>
        /// TrailingTrivia contains everything after the token,
        /// until and including two newlines between which there is no commment
        /// All the remaining trivia is for the LeadingTrivia of the next token
        ///
        /// ```
        /// const /*for const*/ x /*for x*/ := /* for := */ 1/* for 1 */
        /// // for 1 again
        /// // for 1 again
        ///
        /// // Two newlines, now all the trivia is for var y
        /// // this line as well.
        /// var y := 2
        /// ```
        /// </summary>
        string TrailingTrivia { get; set; }
        string LeadingTrivia { get; set; }
        IToken Next { get; set; }
        IToken Prev { get; set; }

        public IToken WithVal(string val);  // create a new token by setting the given val.
    }

    /// <summary>
    /// Has one-indexed line and column fields
    /// </summary>
    public class Token : IToken
    {

        public Token peekedTokens; // Used only internally by Coco when the scanner "peeks" tokens. Normally null at the end of parsing
        public static readonly Token NoToken = new();
        public static readonly Token Cli = new(MutateCSharp.Schemata181.ReplaceNumericConstant_1(2L, 1), MutateCSharp.Schemata181.ReplaceNumericConstant_1(6L, 1));
        public static readonly Token Ide = new(MutateCSharp.Schemata181.ReplaceNumericConstant_1(10L, 1), MutateCSharp.Schemata181.ReplaceNumericConstant_1(14L, 1));
        public Token() : this(MutateCSharp.Schemata181.ReplaceNumericConstant_1(18L, 0), MutateCSharp.Schemata181.ReplaceNumericConstant_1(22L, 0)) { }

        public Token(int linenum, int colnum)
        {
            this.line = linenum;
            this.col = colnum;
            this.val = "";
        }

        public int kind { get; set; }

        public string ActualFilename => Filepath;
        public string Filepath => Uri?.LocalPath;
        public Uri Uri { get; set; }
        public int pos { get; set; }

        /// <summary>
        /// One-indexed
        /// </summary>
        public int col { get; set; }

        /// <summary>
        /// One-indexed
        /// </summary>
        public int line { get; set; }
        public string val { get; set; }
        public string LeadingTrivia { get; set; } = "";

        public string TrailingTrivia { get; set; } = "";

        public IToken Next { get; set; }
        public IToken Prev { get; set; }

        public bool IsValid => this.ActualFilename != null;

        public IToken WithVal(string newVal)
        {
            return new Token
            {
                pos = pos,
                col = col,
                line = line,
                Prev = Prev,
                Next = Next,
                Uri = Uri,
                kind = kind,
                val = newVal
            };
        }

        public int CompareTo(Boogie.IToken other)
        {
            if (MutateCSharp.Schemata181.ReplaceBinExprOp_2(26L, line, other.line))
            {
                return line.CompareTo(other.line);
            }
            return col.CompareTo(other.col);
        }

        public override int GetHashCode()
        {
            return pos;
        }

        public override string ToString()
        {
            return $"'{val}': {Path.GetFileName(Filepath)}@{pos} - @{line}:{col}";
        }

        public int CompareTo(IToken other)
        {
            if (MutateCSharp.Schemata181.ReplaceBinExprOp_2(31L, line, other.line))
            {
                return line.CompareTo(other.line);
            }
            return col.CompareTo(other.col);
        }
    }

    public abstract class TokenWrapper : IToken
    {

        public readonly IToken WrappedToken;
        protected TokenWrapper(IToken wrappedToken)
        {
            Contract.Requires(wrappedToken != null);
            WrappedToken = wrappedToken;
        }

        public abstract IToken WithVal(string newVal);

        public virtual int col
        {
            get { return WrappedToken.col; }
            set { WrappedToken.col = value; }
        }

        public string ActualFilename => WrappedToken.ActualFilename;

        public virtual string Filepath => WrappedToken.Filepath;

        public Uri Uri { get => WrappedToken.Uri;
    set => WrappedToken.Uri = value; }

        public bool IsValid
        {
            get { return WrappedToken.IsValid; }
        }

        public int kind
        {
            get { return WrappedToken.kind; }
            set { WrappedToken.kind = value; }
        }

        public virtual int line
        {
            get { return WrappedToken.line; }
            set { WrappedToken.line = value; }
        }

        public virtual int pos
        {
            get { return WrappedToken.pos; }
            set { WrappedToken.pos = value; }
        }

        public virtual string val
        {
            get { return WrappedToken.val; }
            set { WrappedToken.val = value; }
        }

        public virtual string LeadingTrivia
        {
            get { return WrappedToken.LeadingTrivia; }
            set { throw new NotSupportedException(); }
        }

        public virtual string TrailingTrivia
        {
            get { return WrappedToken.TrailingTrivia; }
            set { throw new NotSupportedException(); }
        }

        public virtual IToken Next
        {
            get { return WrappedToken.Next; }
            set { throw new NotSupportedException(); }
        }

        public virtual IToken Prev
        {
            get { return WrappedToken.Prev; }
            set { throw new NotSupportedException(); }
        }

        public int CompareTo(IToken other)
        {
            return WrappedToken.CompareTo(other);
        }

        public int CompareTo(Boogie.IToken other)
        {
            return WrappedToken.CompareTo(other);
        }
    }

    public static class TokenExtensions
    {

        public static string TokenToString(this IToken tok, DafnyOptions options)
        {
            if (MutateCSharp.Schemata181.ReplaceBinExprOp_3(36L, tok, Token.Cli))
            {
                return MutateCSharp.Schemata181.ReplaceStringConstant_4(37L, "CLI");
            }

            if (MutateCSharp.Schemata181.ReplaceBinExprOp_0(38L, tok.Uri, null))
            {
                return $"({tok.line},{MutateCSharp.Schemata181.ReplaceBinExprOp_5(43L, tok.col, MutateCSharp.Schemata181.ReplaceNumericConstant_1(39L, 1))})";
            }

            var currentDirectory = Directory.GetCurrentDirectory();
            string filename = tok.Uri.Scheme switch
            {
                "stdin" => MutateCSharp.Schemata181.ReplaceStringConstant_4(52L, "<stdin>"),
                "transcript" => Path.GetFileName(tok.Filepath),
                _ => options.UseBaseNameForFileName
                  ? Path.GetFileName(tok.Filepath)
                  : (tok.Filepath.StartsWith(currentDirectory) ? Path.GetRelativePath(currentDirectory, tok.Filepath) : tok.Filepath)
            };

            return $"{filename}({tok.line},{MutateCSharp.Schemata181.ReplaceBinExprOp_5(57L, tok.col, MutateCSharp.Schemata181.ReplaceNumericConstant_1(53L, 1))})";
        }

        public static RangeToken ToRange(this IToken token)
        {
            if (token is BoogieRangeToken boogieRangeToken)
            {
                return new RangeToken(boogieRangeToken.StartToken, boogieRangeToken.EndToken);
            }

            if (token is NestedToken nestedToken)
            {
                return ToRange(nestedToken.Outer);
            }
            return token as RangeToken ?? new RangeToken(token, token);
        }
    }

    public class RangeToken : TokenWrapper
    {
        public IToken StartToken => WrappedToken;

        public IToken EndToken => endToken ?? StartToken;

        public bool InclusiveEnd => MutateCSharp.Schemata181.ReplaceBinExprOp_6(66L, endToken, null);

        public DafnyRange ToDafnyRange(bool includeTrailingWhitespace = false)
        {
            var startLine = MutateCSharp.Schemata181.ReplaceBinExprOp_5(71L, StartToken.line, MutateCSharp.Schemata181.ReplaceNumericConstant_1(67L, 1));
            var startColumn = MutateCSharp.Schemata181.ReplaceBinExprOp_5(84L, StartToken.col, MutateCSharp.Schemata181.ReplaceNumericConstant_1(80L, 1));
            var endLine = MutateCSharp.Schemata181.ReplaceBinExprOp_5(97L, EndToken.line, MutateCSharp.Schemata181.ReplaceNumericConstant_1(93L, 1));
            int whitespaceOffset = MutateCSharp.Schemata181.ReplaceNumericConstant_1(106L, 0);
            if (includeTrailingWhitespace)
            {
                string trivia = EndToken.TrailingTrivia;
                // Don't want to remove newlines or comments -- just spaces and tabs
                while (MutateCSharp.Schemata181.ReplaceBinExprOp_10(131L, () => MutateCSharp.Schemata181.ReplaceBinExprOp_7(110L, whitespaceOffset, trivia.Length), () => (MutateCSharp.Schemata181.ReplaceBinExprOp_9(125L, () => MutateCSharp.Schemata181.ReplaceBinExprOp_8(115L, trivia[whitespaceOffset], ' '), () => MutateCSharp.Schemata181.ReplaceBinExprOp_8(120L, trivia[whitespaceOffset], '\t')))))
                {
                    MutateCSharp.Schemata181.ReplacePostfixUnaryExprOp_11(137L, ref whitespaceOffset);
                }
            }

            var endColumn = MutateCSharp.Schemata181.ReplaceBinExprOp_5(164L, MutateCSharp.Schemata181.ReplaceBinExprOp_12(151L, MutateCSharp.Schemata181.ReplaceBinExprOp_12(142L, EndToken.col, (InclusiveEnd ? EndToken.val.Length : MutateCSharp.Schemata181.ReplaceNumericConstant_1(138L, 0))), whitespaceOffset), MutateCSharp.Schemata181.ReplaceNumericConstant_1(160L, 1));
            return new DafnyRange(
              new DafnyPosition(startLine, startColumn),
              new DafnyPosition(endLine, endColumn));
        }

        public RangeToken(IToken startToken, IToken endToken) : base(startToken)
        {
            this.endToken = endToken;
        }

        public string PrintOriginal()
        {
            var token = StartToken;
            var originalString = new StringBuilder();
            originalString.Append(token.val);
            while (MutateCSharp.Schemata181.ReplaceBinExprOp_10(179L, () => MutateCSharp.Schemata181.ReplaceBinExprOp_6(173L, token.Next, null), () => MutateCSharp.Schemata181.ReplaceBinExprOp_7(174L, token.pos, EndToken.pos)))
            {
                originalString.Append(token.TrailingTrivia);
                token = token.Next;
                originalString.Append(token.LeadingTrivia);
                originalString.Append(token.val);
            }

            return originalString.ToString();
        }

        public int Length()
        {
            return MutateCSharp.Schemata181.ReplaceBinExprOp_5(185L, EndToken.pos, StartToken.pos);
        }

        public RangeToken MakeAutoGenerated()
        {
            return new RangeToken(new AutoGeneratedToken(StartToken), EndToken);
        }

        public RangeToken MakeRefined(ModuleDefinition module)
        {
            return new RangeToken(new RefinementToken(StartToken, module), EndToken);
        }

        // TODO rename to Generated, and Token.NoToken to Token.Generated, and remove AutoGeneratedToken.
        public static RangeToken NoToken = new(Token.NoToken, Token.NoToken);
        private readonly IToken endToken;

        public override IToken WithVal(string newVal)
        {
            throw new NotImplementedException();
            return default;
        }

        public BoogieRangeToken ToToken()
        {
            return new BoogieRangeToken(StartToken, EndToken, null);
        }

        public bool Contains(int position)
        {
            return MutateCSharp.Schemata181.ReplaceBinExprOp_10(211L, () => MutateCSharp.Schemata181.ReplaceBinExprOp_13(194L, StartToken.pos, position), () => (MutateCSharp.Schemata181.ReplaceBinExprOp_9(205L, () => MutateCSharp.Schemata181.ReplaceBinExprOp_14(199L, EndToken, null), () => MutateCSharp.Schemata181.ReplaceBinExprOp_13(200L, position, EndToken.pos))));
        }

        public bool Intersects(RangeToken other)
        {
            return !(MutateCSharp.Schemata181.ReplaceBinExprOp_9(245L, () => MutateCSharp.Schemata181.ReplaceBinExprOp_13(226L, MutateCSharp.Schemata181.ReplaceBinExprOp_12(217L, other.EndToken.pos, other.EndToken.val.Length), StartToken.pos
        ), () => MutateCSharp.Schemata181.ReplaceBinExprOp_13(240L, MutateCSharp.Schemata181.ReplaceBinExprOp_12(231L, EndToken.pos, EndToken.val.Length), other.StartToken.pos)));
        }
    }

    public class BoogieRangeToken : TokenWrapper
    {
        // The wrapped token is the startTok
        public IToken StartToken { get; }
        public IToken EndToken { get; }

        /// <summary>
        /// If only a single position is used to refer to this piece of code, this position is the best
        /// </summary>
        public IToken Center { get; }

        // Used for range reporting
        public override string val => new(' ', Math.Max(MutateCSharp.Schemata181.ReplaceBinExprOp_5(260L, MutateCSharp.Schemata181.ReplaceBinExprOp_12(251L, EndToken.pos, EndToken.val.Length), pos), MutateCSharp.Schemata181.ReplaceNumericConstant_1(269L, 1)));

        public BoogieRangeToken(IToken startTok, IToken endTok, IToken center) : base(
          center ?? startTok)
        {
            StartToken = startTok;
            EndToken = endTok;
            Center = center;
        }

        public override IToken WithVal(string newVal)
        {
            return this;
        }

        public string PrintOriginal()
        {
            return new RangeToken(StartToken, EndToken).PrintOriginal();
        }
    }

    public class NestedToken : TokenWrapper
    {
        public NestedToken(IToken outer, IToken inner, string message = null)
          : base(outer)
        {
            Contract.Requires(outer != null);
            Contract.Requires(inner != null);
            Inner = inner;
            this.Message = message;
        }
        public IToken Outer
        {
            get { return WrappedToken; }
        }

        public readonly IToken Inner;
        public readonly string Message;

        public override IToken WithVal(string newVal)
        {
            return this;
        }
    }

    /// <summary>
    /// A token wrapper used to produce better type checking errors
    /// for quantified variables. See QuantifierVar.ExtractSingleRange()
    /// </summary>
    public class QuantifiedVariableDomainToken : TokenWrapper
    {
        public QuantifiedVariableDomainToken(IToken wrappedToken)
          : base(wrappedToken)
        {
            Contract.Requires(wrappedToken != null);
        }

        public override string val
        {
            get { return WrappedToken.val; }
            set { WrappedToken.val = value; }
        }

        public override IToken WithVal(string newVal)
        {
            return new QuantifiedVariableDomainToken((WrappedToken.WithVal(newVal)));
        }
    }

    /// <summary>
    /// A token wrapper used to produce better type checking errors
    /// for quantified variables. See QuantifierVar.ExtractSingleRange()
    /// </summary>
    public class QuantifiedVariableRangeToken : TokenWrapper
    {
        public QuantifiedVariableRangeToken(IToken wrappedToken)
          : base(wrappedToken)
        {
            Contract.Requires(wrappedToken != null);
        }

        public override string val
        {
            get { return WrappedToken.val; }
            set { WrappedToken.val = value; }
        }

        public override IToken WithVal(string newVal)
        {
            return new QuantifiedVariableRangeToken(WrappedToken.WithVal(newVal));
        }
    }
}
