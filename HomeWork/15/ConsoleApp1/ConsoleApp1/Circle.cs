﻿using System;

namespace ConsoleApp1
{
    class Circle
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double Calculate(Func<double, double> operation )
        {
            return operation(_radius);
        }
    }
}
