using System;
using System.Collections.Generic;

namespace Parentheses
{
    class Program
    {
        static bool Qualifier(string line)
        {
            Stack<char> brackets = new Stack<char>();

            foreach (var item in line)
            {
                if (item == '(' || item == '[')
                {
                    brackets.Push(item);
                }
                else
                {
                    if (item == ')' || item == ']')
                    {
                        if (brackets.Count == 0)
                        {
                            return false;
                        }
                        if (item == ')' && brackets.Peek() == '(')
                            brackets.Pop();
                        if (item == ']' && brackets.Peek() == '[')
                            brackets.Pop();
                    }
                }
            }
            return brackets.Count == 0;
        }

        static void Main(string[] args)
        {

            string input;
            do
            {
                Console.WriteLine("Enter a string containing parenthese. For exemple '(', ')'; '[', ']'");
                input = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(input));

            Console.WriteLine(Qualifier(input));
        }
    }
}
