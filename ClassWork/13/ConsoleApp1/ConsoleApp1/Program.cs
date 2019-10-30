using System;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var first = new Plane(1200,4);
            Console.WriteLine("Upper");
            first.TakeUpper(20);
            first.WriteProperties();
            Console.WriteLine("Lower");
            first.TakeLower(50);
            first.WriteProperties();

            var second = new Helicopter(2000, 4);
            Console.WriteLine("Upper");
            second.TakeUpper(40);
            second.WriteProperties();
            Console.WriteLine("Lower");
            second.TakeLower(20);
            second.WriteProperties();

            Console.ReadKey();
        }
    }
}
