using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two number.\n");

            Console.WriteLine("Enter variable fist operand ");
            var fistOperand = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter variable second operand ");
            var secondOperand = double.Parse(Console.ReadLine());

            Console.WriteLine("\nCalculation result:");
            Console.WriteLine($"{fistOperand} + {secondOperand} = {fistOperand + secondOperand}");

            Console.WriteLine($"{fistOperand} - {secondOperand} = {fistOperand - secondOperand}");

            Console.WriteLine($"{fistOperand} * {secondOperand} = {fistOperand * secondOperand}");

            Console.ReadKey();

        }
    }
}
