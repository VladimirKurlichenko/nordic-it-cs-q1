using System;

namespace NameAge
{
    class Program
    {
        static string Input(string[] inputDate, string valueType)
        {
            
            for (int i = 0; i < inputDate.Length; i++)
            {
                int numbering = i+1;
                Console.Write($"Enter {numbering} {valueType}: ");
                inputDate[i] = Console.ReadLine();
            }
            return null;
        }
        static void Output(string[] first, string[] second)
        {
            for(int i = 0; i < first.Length; i++)
            {
                Console.Write($"Name: {first[i]}, age: {second[i]}.\n");
            }
        }

        static void Main(string[] args)
        {
            string[] name = new string[3];
            string typeName = "Name";
            Input(name, typeName);

            string typeAge = "Age";
            string[] age = new string[3];
            Input(age, typeAge);

            Output(name, age);

            Console.ReadKey();
        }
    }
}
