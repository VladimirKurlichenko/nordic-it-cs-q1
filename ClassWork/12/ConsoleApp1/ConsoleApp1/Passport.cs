using System;

namespace ConsoleApp1
{
    class Passport : BaseDocument
    {
        public Passport(string number, DateTimeOffset issueDate):
            base("Passport", number, issueDate)
        {
        }
        public string Country { get; set; }
        public string PersonName { get; set; }

        public override string Description =>
            $"{base.Description}"+
            $"PersonName {PersonName}" +
            $"Country {Country},";

    }
}
