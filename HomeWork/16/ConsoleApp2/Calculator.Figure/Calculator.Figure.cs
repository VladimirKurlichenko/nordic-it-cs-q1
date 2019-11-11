using System;

namespace Calculator.Figure
{
    public class Circle
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double Calculate(Func<double, double> operation) =>
            operation(_radius);
    }

    public class Square
    {
        private double _firstSide;
        private double _secondSide;

        public Square(double firstSide, double secondSide)
        {
            _firstSide = firstSide;
            _secondSide = secondSide;
        }

        public double Calculate(Func<double, double, double> operation) =>
            operation(_firstSide, _secondSide);
    }

}
