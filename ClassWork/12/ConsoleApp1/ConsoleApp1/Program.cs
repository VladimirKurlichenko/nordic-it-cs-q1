using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            BaseDocument document1 = new BaseDocument("Document", "1242141", new DateTimeOffset(new DateTime(2019, 5, 5)));
            Passport passport = new Passport("1242141", new DateTimeOffset(new DateTime(2019, 5, 5)))
            {
                Country = "Russia",
                PersonName = "Vladimir"
            };

            document1.WriteToConsole();
            passport.WriteToConsole();

        }
    }
}
