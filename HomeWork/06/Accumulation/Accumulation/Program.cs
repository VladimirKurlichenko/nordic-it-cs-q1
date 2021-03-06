﻿using System;

namespace Accumulation
{
    class Program
    {
        static decimal CheckAndWrite(string words)
        {
            decimal number;

            while (true)
            {
                try
                {
                    Console.Write(words);
                    number = decimal.Parse(Console.ReadLine());

                    if(number < 0)
                    {
                        throw new IndexOutOfRangeException();
                    }

                    return number;

                }
                catch (FormatException formatException)
                {
                    Console.WriteLine(formatException.Message);
                }
                catch (OverflowException overException)
                {
                    Console.WriteLine(overException.Message);
                }
                catch (IndexOutOfRangeException indexExceptoin)
                {
                    Console.WriteLine(indexExceptoin.Message);
                }
            }
           
        }

        static void Main(string[] args)
        {
            string wordsPayment = "Enter the amount of the down payment in rubles: ";
            decimal payment = default;
            payment = CheckAndWrite(wordsPayment);

            string wordsPercent = "Enter the daily percentage of income as a decimal (1% = 0.01): ";
            decimal percentIncomes = default;
            percentIncomes = CheckAndWrite(wordsPercent);
            
            string wordsAccumulation = "Enter the desired amount of savings in rubles: ";
            decimal accumulationAmount = default;
            accumulationAmount = CheckAndWrite(wordsAccumulation);

            int days = default;
            while (payment < accumulationAmount)
            {
                payment *= (1 + percentIncomes);
                days++;
            }
            Console.WriteLine($"The requires number of days to accumulate the desire amount: {days}");

        }
    }
}
