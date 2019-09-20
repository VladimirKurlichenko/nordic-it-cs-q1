using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа:\n");

            Console.WriteLine("Введите переменную x ");
            var x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите переменную y ");
            var y = double.Parse(Console.ReadLine());

            Console.WriteLine("\nРезультат вычислений:");
            Console.WriteLine($"{x} + {y} = {x + y}");

            Console.WriteLine($"{x} - {y} = {x - y}");

            Console.WriteLine($"{x} * {y} = {x * y}");

        }
    }
}
