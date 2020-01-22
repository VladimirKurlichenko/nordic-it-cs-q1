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
            var contractorSender = new Contractor("Иванов И. И.", addressSender, "Управляющий");
            var contractorReceiver = new Contractor("Петров П.П.", addressReceiver, "Управляющий");
            var documentStatus = new DocumentStatus(contractorSender, contractorReceiver, document, "Отправлено", DateTimeOffset.UtcNow);

            using var context = new OnlineStoreContext();
            context.Database.EnsureCreated();

            context.DocumentStatuses.Add(documentStatus);
            context.SaveChanges();
            Console.WriteLine("Completed");


        }
    }
}
