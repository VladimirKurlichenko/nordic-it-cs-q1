using System;
namespace calculatorV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа: \n");

            Console.WriteLine("Введите переменную x ");
            var x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите переменную y ");
            var y = double.Parse(Console.ReadLine());

            Console.WriteLine("\nВыберите операцию: \n" + "+ - Сложение\n" + "- - Вычитание\n" + "* - Умножение\n" + 
                              "/ - Деление\n" + "% - Остаток от деления\n" + "^ - Возвести в степень\n");

            Console.WriteLine("Ваш выбор: ");
            string op = Console.ReadLine();
            Console.WriteLine("\nРезультат: ");
            switch (op)
            {
                case "+":
                    Console.WriteLine($"{x} + {y} = {x + y}");
                    break;

                case "-":
                    Console.WriteLine($"{x} - {y} = {x - y}");
                    break;

                case "*":
                    Console.WriteLine($"{x} * {y} = {x * y}");
                    break;

                case "/":
                    Console.WriteLine($"{x} / {y} = {x / y}");
                    break;

                case "%":
                    Console.WriteLine($"{x} % {y} = {x % y}");
                    break;

                case "^":
                    Console.WriteLine($"{x} ^ {y} = {Math.Pow(x, y)}");
                    break;

            }
        }
    }
}
