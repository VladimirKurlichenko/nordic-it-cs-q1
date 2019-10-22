using System;

namespace NameAndAge
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new Personage[3];
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new Personage();

                do
                {
                    Console.Write($"Enter name {i}: ");
                    people[i].Name = Console.ReadLine();

                } while (string.IsNullOrWhiteSpace(people[i].Name));
                do
                {
                    Console.Write($"Enter age {i}: ");
                    people[i].Age = int.Parse(Console.ReadLine());
                } while (people[i].Age < 0);
            }

            foreach (var person in people)
            {
                Console.WriteLine(person.Description);
            }

            Console.ReadKey();
        }
    }
}
