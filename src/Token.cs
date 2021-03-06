namespace Scripty
{
    using System.Collections.Generic;

    public class Token
    {
        public const string Illegal = "ILLEGAL";
        public const string Eof = "EOF";

        // identifiers
        public const string Ident = "IDENT";
        public const string Int = "INT";
        public const string String = "STRING";
        public const string Float = "FLOAT";

        //operators
        public const string Assign = "=";
        public const string Plus = "+";
        public const string Minus = "-";
        public const string Bang = "!";
        public const string Slash = "/";
        public const string Asterisk = "*";
        public const string Gt = ">";
        public const string Lt = "<";
        public const string Eq = "==";
        public const string NotEq = "!=";
        public const string And = "&&";
        public const string Or = "||";

        // delimiters
        public const string Dot = ".";
        public const string Comma = ",";
        public const string Semicolon = ";";
        public const string Colon = ":";
        public const string Lparen = "(";
        public const string Rparen = ")";
        public const string Lbrace = "{";
        public const string Rbrace = "}";
        public const string Lbracket = "[";
        public const string Rbracket = "]";

        // keywords
        public const string Function = "FUNCTION";
        public const string Let = "LET";
        public const string True = "TRUE";
        public const string False = "FALSE";
        public const string If = "IF";
        public const string Else = "ELSE";
        public const string Return = "RETURN";

        private readonly Dictionary<string, string> _keywords = new()
        {
            {"fun", Function},
            {"let", Let},
            {"true", True},
            {"false", False},
            {"if", If},
            {"else", Else},
            {"return", Return}
        };

        public string Type { get; set; }
        public string Literal { get; set; }

        public string LookUpIdent(string ident) => _keywords.TryGetValue(ident, out var tok) ? tok : Ident;
    }
}