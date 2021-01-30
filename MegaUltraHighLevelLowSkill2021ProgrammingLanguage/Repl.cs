using System;
using System.Collections.Generic;

namespace MegaUltraHighLevelLowSkill2021ProgrammingLanguage
{
    public class Repl
    {
        private const string PROMPT = "> ";

        public void Run()
        {
            while (true)
            {
                Console.Write(PROMPT);
                var input = Console.ReadLine();
                if (input is null) return;

                var lexer = new Lexer(input);
                var parser = new Parser(lexer);

                var program = parser.ParseCode();
                if (parser.Errors.Count != 0)
                {
                    PrintParserErrors(parser.Errors);
                    continue;
                }

                Console.WriteLine(program.Str());
            }
        }

        private static void PrintParserErrors(List<string> errors)
        {
            foreach (var error in errors)
            {
                // TODO: add makaque
                Console.WriteLine(error);
            }
        }
    }
}