using System;

namespace ConsoleApp1
{
    class Program
    {
        public static double Perimeter(double x)
        {
            return x = 2 * Math.PI * x; 
        }

        public static double Squers(double x)
        {
            return x = Math.PI * Math.Pow(x,2);
        }
        static void Main(string[] args)
        {
            var IdName1 = new Account<int, string>(1, "Vova");
            IdName1.WriteProperties();

            var IdName2 = new Account<string, string>("2", "Kira");
            IdName2.WriteProperties();

            var IdName3 = new Account<Guid, string>(Guid.NewGuid(), "Vlad\n");
            IdName3.WriteProperties();

            Circle circle = new Circle(1.5);
            Console.WriteLine($"For the circle with radius 1.5\n" +
                $"Perimeter is {circle.Calculate(Perimeter)}\n" +
                $"Squers is {circle.Calculate(Squers)}");

            Console.ReadKey();
        }
    }
}
