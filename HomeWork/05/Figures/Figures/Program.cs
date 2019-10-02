using System;

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
       
        static void Main(string[] args)
        {
            GetFigures();

            int typeFigures = default;
            bool a = true;
            while (a)
            {
                try
                {
                    Console.Write("Select shape: ");
                    typeFigures = int.Parse(Console.ReadLine());

                    if (typeFigures < 1)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    if (typeFigures > 3)
                    {
                        throw new ArgumentOutOfRangeException();
                    }

                    a = false;

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

            double result;
             switch (typeFigures)
             {
                 case 1:
                     {
                        double radius = default;
                        a = true;
                        while (a)
                        {
                            try
                            {
                                Console.Write("Enter radius : ");
                                radius = double.Parse(Console.ReadLine());

                                if (radius < 0)
                                {
                                    throw new ArgumentOutOfRangeException();
                                }
                                a = false;
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

                        result = 2 * Math.PI * radius;

                        Console.WriteLine($"Circle perimeter = {result} ");


                        break;
                     }
                 case 2:
                     {

                         break;
                     }
                 case 3:
                     {

                         break;
                     }

             }

            Console.ReadKey();
        }


        static string EnterFigures(int number)
        {
            number = default;
            bool a = true;
            while (a)
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

                    a = false;

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
            return default;
        }
        static void GetFigures()
        {
            var values = (Figures[])Enum.GetValues(typeof(Figures));

            Console.WriteLine("List of Shapes:");

            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine($"{(int)values[i]} - {values[i]}");
            }
        }
    }
}
