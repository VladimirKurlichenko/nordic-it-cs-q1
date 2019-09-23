using System;
namespace calculatorV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two number. \n");

            Console.WriteLine("Enter variable first operand ");
            var firstOperand = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter variable second operand ");
            var secondOperand = double.Parse(Console.ReadLine());

            Console.WriteLine("\nSelect operation: \n" + "+\n" + "-\n" + "*\n" + 
                              "/\n" + "%\n" + "^\n");

            Console.WriteLine("Your choice: ");
            string operation = Console.ReadLine();
            Console.WriteLine("\nResult: ");
            switch (operation)
            {
                case "+":
                    Console.WriteLine($"{firstOperand} + {secondOperand} = {firstOperand + secondOperand}");
                    break;

                case "-":
                    Console.WriteLine($"{firstOperand} - {secondOperand} = {firstOperand - secondOperand}");
                    break;

                case "*":
                    Console.WriteLine($"{firstOperand} * {secondOperand} = {firstOperand * secondOperand}");
                    break;

                case "/":
                    Console.WriteLine($"{firstOperand} / {secondOperand} = {firstOperand / secondOperand}");
                    break;

                case "%":
                    Console.WriteLine($"{firstOperand} % {secondOperand} = {firstOperand % secondOperand}");
                    break;

                case "^":
                    Console.WriteLine($"{firstOperand} ^ {secondOperand} = {Math.Pow(firstOperand, secondOperand)}");
                    break;

            }

            Console.ReadKey();
        }
    }
}
