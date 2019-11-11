using System;
using Calculator.Operation;
using Calculator.Figure;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(1.5);
            Console.WriteLine(circle.Calculate(CircleOperation.Perimeter));

        }
    }
}
