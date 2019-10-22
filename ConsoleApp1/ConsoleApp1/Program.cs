using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<char> parentheses = new Queue<char>();


            var variable = Console.ReadLine();
            char[] sa = variable.ToCharArray();

            for (int i = 0; i < sa.Length; i++)
            {
                parentheses.Enqueue(sa[i]);
            }

            int index = default;
            int index2 = default;
            char q1 = '(';
            char q2 = ')';
            bool akkl = AAA(index, index2,q1, q2, parentheses);
            Console.WriteLine(akkl);
        }

        static bool AAA(int index, int index2,char q1,char q2, Queue<char> a)
        {
            bool ak = true;
            bool you = false;
            while (a.Count > 0)
            {
                if (a.Peek() == q1 && you == false)
                {
                    index++;
                }
                else
                    if (a.Peek() == q2)
                {
                    you = true;
                    index2++;
                }

                a.Dequeue();
            }

            if (index == index2)
            {
                ak = true;
                Console.WriteLine("True");
            }
            else
            {
                ak = false;
                Console.WriteLine("False");
            }
            return ak;
        }
    }
}
