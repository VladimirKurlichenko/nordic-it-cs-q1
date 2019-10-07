﻿using System;

namespace Figures
{
    [Flags]

    enum Figures
    {
        Circle = 1,
        EquilateralTriangle = 2,
        Rectangle = 3
    };
    class Program
    {
        static void GetFigures()
        {
            var values = (Figures[])Enum.GetValues(typeof(Figures));

            Console.WriteLine("List of Shapes:");

            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine($"{(int)values[i]} - {values[i]}");
            }
        }
        static void Main(string[] args)
        {
            GetFigures();

            int typeFigures = default;
            typeFigures = EnterFigures(typeFigures);

            double squareOfFigure = default;
            double perimeterOfFigure = default;
            switch (typeFigures)
            {
                case 1:
                    {
                        double circleDiameter = default;
                        string textDiameter = "Enter the diameter value: ";
                        circleDiameter = EnterVariable(circleDiameter, textDiameter);

                        squareOfFigure = Math.PI * Math.Pow(circleDiameter / 2d, 2);
                        perimeterOfFigure = Math.PI * circleDiameter;

                        break;
                    }
                case 2:
                    {
                        double sideOfTriangle = default;
                        string textTriangle = "Enter the value of the side of the triangle: ";
                        sideOfTriangle = EnterVariable(sideOfTriangle, textTriangle);

                        squareOfFigure = (Math.Pow(sideOfTriangle, 2) * Math.Pow(3d, 2)) / 4d;
                        perimeterOfFigure = sideOfTriangle * 3d;
                        
                        break;
                    }
                case 3:
                    {
                        double lengthOfRectangle = default;
                        string textLenght = "Enter the length of the rectangle: ";
                        lengthOfRectangle = EnterVariable(lengthOfRectangle, textLenght);

                        double widthOfRectangle = default;
                        string textWidth = "Enter the width of the rectangle: ";
                        widthOfRectangle = EnterVariable(widthOfRectangle, textWidth);

                        squareOfFigure = lengthOfRectangle * widthOfRectangle;
                        perimeterOfFigure = (lengthOfRectangle + widthOfRectangle) * 2;

                        break;
                    }
            }

            Console.WriteLine($"The surface area of the figure: {squareOfFigure}");
            Console.WriteLine($"The perimeter of the figure: {perimeterOfFigure}");
        }

        static int EnterFigures(int number)
        {
            while (true)
            {
                try
                {
                    Console.Write("Select shape: ");
                    number = int.Parse(Console.ReadLine());

                    if (number < 1)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    if (number > 3)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    return number;
                    break;
                }
                catch (FormatException formatException)
                {
                    Console.WriteLine(formatException.Message);
                }
                catch (ArgumentOutOfRangeException argumentExeption)
                {
                    Console.WriteLine(argumentExeption.Message);
                }
            }

        }

        static double EnterVariable(double number, string text)
        {
            while (true)
            {
                try
                {
                    Console.Write(text);
                    number = double.Parse(Console.ReadLine());

                    if (number < 0)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    return number;
                    break;
                }
                catch (FormatException formatException)
                {
                    Console.WriteLine(formatException.Message);
                }
                catch (ArgumentOutOfRangeException argumentExeption)
                {
                    Console.WriteLine(argumentExeption.Message);
                }
            }

        }
    }
}
