using System;

namespace ConsoleApp1
{
    class Program
    {

        delegate double Formulars(double x);

        static void Main(string[] args)
        {
            //Написал не используя метод Circle
            //double x = 1.5;
            //Formulars perimeter = (x) => x = 2 * Math.PI * x;
            //Formulars squers = (x) => x = Math.PI * Math.Pow(x, 2);
            //Formulars diametr = (x) => x *= 2;
            //Console.WriteLine($"For the circle with radius 1.5\n" +
            //    $"Perimeter is {perimeter(x)}\n" +
            //    $"Squers is {squers(x)}\n" +
            //    $"Diametr is {diametr(x)}");

            Circle circle = new Circle(1.5);
            Console.WriteLine($"For the circle with radius 1.5\n" +
                $"Perimeter is {circle.Calculate(radius => 2 * Math.PI * radius)}\n" +
                $"Squers is {circle.Calculate(radius => Math.PI * Math.Pow(radius, 2))}\n" +
                $"Diametr is {circle.Calculate(radius => radius * 2)}");



            Console.ReadKey();
        }
    }
}
