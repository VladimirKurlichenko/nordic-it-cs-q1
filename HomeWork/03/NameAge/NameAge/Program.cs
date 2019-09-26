using System;

namespace NameAge
{
    class Program
    {
        static bool CheckName(string[] testName, int index)
        {
            if (string.IsNullOrWhiteSpace(testName[index]))
            {
                return true;
            }
            return false;
        }
        static string EnterName(string[] inputName)
        {
            
            for (int i = 0; i < inputName.Length; i++)
            {
                while(CheckName(inputName, i))
                {
                    Console.Write($"Enter {i + 1} name: ");
                    inputName[i] = Console.ReadLine();

                    if(CheckName(inputName, i))
                    {
                        Console.WriteLine("NO NAME ENTERED!!!!");
                    }
                   
                }
            }
            return null;
        }

        static bool CheckAge(int[] testAge, int mark)
        {
            if(testAge[mark] <= 0)
            {
                return true;
            }
            return false;
        }
        static string EnterAge(int[] inputAge)
        {

            for (int i = 0; i < inputAge.Length; i++)
            {
                while (CheckAge(inputAge, i))
                {
                    Console.Write($"Enter {i + 1} age: ");
                    int.TryParse(Console.ReadLine(), out inputAge[i]);

                    if (CheckAge(inputAge, i))
                    {
                        Console.WriteLine("NO NAME ENTERED!!!!");
                    }

                }
            }
            return null;
        }

        static void WriteResult(string[] first, int[] second)
        {
            for(int i = 0; i < first.Length; i++)
            {
                Console.Write($"Name: {first[i]}, age in 4 years: {second[i] + 4}.\n");
            }
        }

        static void Main(string[] args)
        {
            string[] name = new string[3];
            EnterName(name);

            int[] age = new int[3];
            EnterAge(age);

            WriteResult(name, age);

            Console.ReadKey();
        }
    }
}
