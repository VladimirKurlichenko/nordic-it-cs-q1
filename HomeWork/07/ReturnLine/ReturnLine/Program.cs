using System;
using System.Text;

namespace ReturnLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = default;

            do
            {
                Console.Write("Enter not an empty string: ");
                words = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(words))
                    Console.WriteLine("Field cannot be empty !!");

            } while (string.IsNullOrWhiteSpace(words));

            char[] temporaryStorage = words.ToCharArray();
            var returnLine = new StringBuilder();
            for (int i = temporaryStorage.Length - 1; i >= 0; i--)
            {
                returnLine.Append(char.ToLower(temporaryStorage[i]));
            }
            Console.WriteLine(returnLine);
            Console.WriteLine("Press ane key to exit");
            Console.ReadKey();
        }
    }
}
