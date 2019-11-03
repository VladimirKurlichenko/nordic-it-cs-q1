using System;

namespace WordsOnA
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = default;
            string input;

            do
            {
                Console.Write("Please enter string from a few words:");
                input = Console.ReadLine();
                foreach (var item in input)
                    if (char.IsDigit(item))
                    {
                        Console.WriteLine("The text contains numbers.");
                        break;
                    }

            } while (string.IsNullOrWhiteSpace(input));

            var words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in words)
            {
                
                if (words.Length > 1)
                {
                    if (Char.ToUpper(item[0]) == 'A')
                    {
                        index++;
                    }
                }
                else
                    Console.WriteLine("You have entered too few words");
            }

            Console.WriteLine($"Numbers of words beginning with a lette 'А': {index}");
            Console.Write("Press any key to exit");
            Console.ReadKey();
        }
    }
}
