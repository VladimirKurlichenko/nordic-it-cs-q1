using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two number.\n");

            Console.WriteLine("Enter variable first operand ");
            var firstOperand = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter variable second operand ");
            var secondOperand = double.Parse(Console.ReadLine());

            Console.WriteLine("\nCalculation result:");
            Console.WriteLine($"{firstOperand} + {secondOperand} = {firstOperand + secondOperand}");

            Console.WriteLine($"{firstOperand} - {secondOperand} = {firstOperand - secondOperand}");

            Console.WriteLine($"{firstOperand} * {secondOperand} = {firstOperand * secondOperand}");

            Console.ReadKey();

        }
    }
}
