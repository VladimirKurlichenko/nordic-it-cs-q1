using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two number.\n");

            Console.WriteLine("Enter variable x ");
            var x = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter variable y ");
            var y = double.Parse(Console.ReadLine());

            Console.WriteLine("\nCalculation result:");
            Console.WriteLine($"{x} + {y} = {x + y}");

            Console.WriteLine($"{x} - {y} = {x - y}");

            Console.WriteLine($"{x} * {y} = {x * y}");

            Console.ReadKey();

        }
    }
}
