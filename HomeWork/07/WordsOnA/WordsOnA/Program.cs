using System;

namespace WordsOnA
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = default;
            string input= default;
            while (string.IsNullOrWhiteSpace(input))
            {
                Console.Write("Please enter string from a few words:");
                input = Console.ReadLine();
            }

            var words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            try
            {
                foreach (var item in words)
                {
                    for (int i = 0; i < item.Length; i++)
                    {
                        if (char.IsDigit(item[i]))
                        {
                            throw new FormatException();
                        }
                    }
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
            }
            catch (FormatException formatException)
            {

                Console.WriteLine(formatException.Message);
            }

            Console.WriteLine($"Numbers of words beginning with a lette 'А': {index}");
            Console.Write("Press any key to exit");
            Console.ReadKey();
        }
    }
}
