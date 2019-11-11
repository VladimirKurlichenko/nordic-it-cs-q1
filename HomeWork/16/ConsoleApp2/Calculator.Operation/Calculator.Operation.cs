using System;
using Calculator.Figure;

namespace Calculator.Operation
{
    public class CircleOperation
    {
        public static  double Perimeter(double radius)
        {
            var perimeter = Math.PI * Math.Pow(radius, 2);
            return perimeter;

        }
        public static double Squers(double radius)
        {
            var squers = Math.PI * Math.Pow(radius, 2);
            return squers;


        }
        public static double Diameter(double radius)
        {
            var diametr = radius * 2;
            return diametr;
        }
    }
}
