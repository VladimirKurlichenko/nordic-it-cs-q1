namespace NameAndAge
{
    class Personage
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int AgeAfterFourYears
            => Age + 4;
        public string Description
            => $"Name: {Name}, age in 4 years: {AgeAfterFourYears}.";
    }
}
