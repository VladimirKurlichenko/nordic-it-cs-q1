using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new RandomDateGenerator();
            generator.RandomDateGeneratedHandler += Generator_RandomDateGeneratedHandler;

            generator.RandomDateGenereted += Generator_RandomDateGenereted;
            var date = generator.GetRandomDate(8, 3);
            Console.ReadKey();
        }

        private static void Generator_RandomDateGeneratedHandler(object sender, RandomDateGeneratedHandler e)
        {
            Console.WriteLine($"Generate {e.DateDone}, date of {e.TotalBytes}");
        }

        private static void Generator_RandomDateGenereted(object sender, EventArgs e)
        {
            Console.WriteLine("Date generated");
        }
    }
}
