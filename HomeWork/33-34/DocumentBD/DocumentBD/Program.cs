using System;

namespace DocumentBD
{
    class Program
    {
        static void Main(string[] args)
        {
            var addressSender = new Address("Москва", "ул. Третьяковская, д.21");
            var addressReceiver = new Address("Москва", "ул. Сенная, д.30");
            var document = new Document("Книга", "Война и Мир т.1 ", 666);
            var contractorSender = new Contractor("Иванов Иван Иванович", addressSender, "Управляющий");
            var contractorReceiver = new Contractor("Петров Петр Петрович", addressReceiver, "Управляющий");
            var documentStatus = new DocumentStatus(contractorSender, contractorReceiver, document, "Доставлено", DateTimeOffset.UtcNow);

            using var context = new OnlineStoreContext();
            context.Database.EnsureCreated();

            context.DocumentStatuses.Add(documentStatus);
            context.SaveChanges();
            Console.WriteLine("Completed");


        }
    }
}
