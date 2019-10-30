using System;

namespace ConsoleApp1
{
    class Pet
    {
        public string Kind;
        public string Name;
        public char Sex;
        public DateTime DateOfBirth;

        public Pet(string kind, string name)
        {
            Kind = kind;
            Name = name;
        }
        public byte GetAge()
        {
            TimeSpan difference = DateTime.Now - DateOfBirth;
            return (byte)Math.Floor(difference.TotalDays / 365);
        }

        public string Description
        {
            get
            {
                return $"The pet kind of {Kind}, has name {Name}, age {GetAge()}, sex {Sex}.";
            }
        }

        public string Description2
        {
            get
            {
                return $"The pet kind of {Kind}, has name {Name}.";
            }
        }

        public void Display(char index)
        {
            switch (index)
            {
                case 'f':
                    {
                        Console.WriteLine(Description);
                        break;
                    }
                case 's':
                    {
                        Console.WriteLine(Description2);
                        break;
                    }
            }
        }
    }
}
