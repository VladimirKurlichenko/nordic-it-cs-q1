using System;

namespace ColorSelection
{
    [Flags]
    enum Colors: short
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
                favoriteColors = favoriteColors | (Colors)short.Parse(Console.ReadLine());
            }

            Colors noFavoriteColors = 0;

            noFavoriteColors = (Colors)(~(short)favoriteColors ^ 65024);

            Console.WriteLine($"Favorite colors: {favoriteColors}\nUnloved colors: {noFavoriteColors}");

            Console.ReadKey();
        }
    }
}
