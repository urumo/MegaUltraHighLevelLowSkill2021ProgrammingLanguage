using System;
using Scripty.Interfaces;

namespace Scripty.Expressions
{
    public class IndexExpression : IExpression
    {
        public Token Token { get; set; }
        public IExpression Left { get; set; }
        public IExpression Index { get; set; }

        public string TokenLiteral() => Token.Literal;

        public string Str() => $"({Left.Str()}[{Index.Str()}])";

        public void ExpressionNode() => throw new NotImplementedException();
    }
}