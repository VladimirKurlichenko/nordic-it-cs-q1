using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter F or S ");
            char index = char.ToLower(char.Parse(Console.ReadLine()));

            var pet1 = new Pet("Cat", "Tom");
            pet1.Sex = 'M';
            pet1.DateOfBirth = new DateTime(1999, 5, 21);
            pet1.Display(index);

            var pet2 = new Pet("Dog", "Sem")
            {
                Sex = 'W',
                DateOfBirth = new DateTime(2006, 1, 15)
            };
            pet2.Display(index);


            Console.ReadKey();
        }
    }
}
