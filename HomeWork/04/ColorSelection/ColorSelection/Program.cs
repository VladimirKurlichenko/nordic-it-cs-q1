using System;

namespace ColorSelection
{
    [Flags]
    enum Colors
    {
        Black = 1,
        Blue = 2,
        Cyan = 4,
        Grey = 8,
        Green = 16,
        Magenta = 32,
        Red = 64,
        White = 128,
        Yellow = 256
    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Color list: \n");

            
            for (int i = 0; i < 9; i++)
            {
                double index =Math.Pow(2, i);
                Console.WriteLine($"{(Colors)index} - {index}");
            }

            Colors favoriteColors = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"\nChoose {i+1} color you like: ");
                favoriteColors = favoriteColors | (Colors)int.Parse(Console.ReadLine());
            }

            Colors noFavoriteColors = 0;
            for (int i = 0; i < 9; i++)
            {
                double mark = Math.Pow(2, i);
                if ((favoriteColors & (Colors)mark) != (Colors)mark)
                {
                    noFavoriteColors = noFavoriteColors | (Colors)mark; 
                }
            }

            Console.WriteLine($"Favorite colors: {favoriteColors}\nUnlived colors: {noFavoriteColors}");

            Console.ReadKey();
        }
    }
}
