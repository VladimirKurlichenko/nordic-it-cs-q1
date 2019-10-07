using System;

namespace EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = default;
            int index = default;
            int enterNumbers;

            while (true)
            {
                try
                {
                    Console.Write("Enter a positive natural number of no more than 2 billion: ");
                    numbers = int.Parse(Console.ReadLine());
                    if (numbers < 0)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    break;
                }
                catch (FormatException formateXception)
                {
                    Console.WriteLine(formateXception.Message);
                }
                catch (ArgumentOutOfRangeException argumenteXception)
                {
                    Console.WriteLine(argumenteXception.Message);
                }
                catch (OverflowException overException)
                {
                    Console.WriteLine(overException.Message);
                }
            }

            enterNumbers = numbers;

            while (numbers != 0)
            {
                if (numbers % 2 == 0)
                {
                    index++;
                    numbers /= 10;
                }
                else
                {
                    numbers /= 10;
                }
            }

            Console.WriteLine($"The number of even digits indicated in {enterNumbers} is {index}.");
        }
    }
}
