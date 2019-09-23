using System;
namespace calculatorV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two number. \n");

            Console.WriteLine("Enter variable x ");
            var x = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter variable y ");
            var y = double.Parse(Console.ReadLine());

            Console.WriteLine("\nSelect operation: \n" + "+\n" + "-\n" + "*\n" + 
                              "/\n" + "%\n" + "^\n");

            Console.WriteLine("Your choice: ");
            string op = Console.ReadLine();
            Console.WriteLine("\nResult: ");
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

            Console.ReadKey();
        }
    }
}
