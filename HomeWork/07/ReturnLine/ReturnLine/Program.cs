using System;

namespace ReturnLine
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter not an empty string: ");
                    var words = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(words))
                    {
                        throw new Exception();
                    }

                    char[] temporaryStorage = words.ToCharArray();
                    string returnLine = default;
                    for (int i = temporaryStorage.Length - 1; i >= 0; i--)
                    {
                        returnLine += char.ToString(char.ToLower(temporaryStorage[i]));
                    }
                    Console.WriteLine(returnLine);
                    Console.WriteLine("Press ane key to exit");
                    Console.ReadKey();
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Field cannot be empty !!");
                }
            }
        }
    }
}
