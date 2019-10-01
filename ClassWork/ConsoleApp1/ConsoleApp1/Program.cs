using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {



            //   |-variant

            /*
            Console.Write("Enter number: ");
            int mun = int.Parse(Console.ReadLine());

            if(mun < 100)
            {
                Console.WriteLine("The number is more than one hundred");
            }

            else
            {
                Console.WriteLine("The number less than one hundred");
            }

            Console.ReadKey();
            */

            //  ||-variant 

            /*   
            Console.Write("Enter number: ");
            int mun = int.Parse(Console.ReadLine());

            var masssage = (mun > 100 && mun < 1000)
                ? "Number greater than 100 and less than 1000"
                : "The number does not satisfy the conditions";
            Console.WriteLine(masssage);
            */

            // |||-variant

            /*
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            int second = num / 10;
            int list = num % 10;

            switch(list)
            {
                case 1 when second > 1:
                    Console.WriteLine($"{num} - {num} год");
                    break;
                case 2:
                case 3:
                case 4:
                    Console.WriteLine($"{num} - {num} годa");
                    break;
                default: 
                    Console.WriteLine($"{num} - {num} лет");
                    break;
            }

            Console.ReadKey();
            */
        }
    }
}
