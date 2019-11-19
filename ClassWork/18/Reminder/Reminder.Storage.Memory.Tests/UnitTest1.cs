using NUnit.Framework;
using System;

namespace Reminder.Storage.Memory.Tests
{
    public class ReminderStorageTest
    {
        [Test]
        public void WhereCreate_IfEmptyStorage_ShouldFindItemById()
        {
            var item = new ReminderItem(
                Guid.NewGuid(),
                "123",
                "Some text",
                DateTimeOffset.Now);
            var storage = new ReminderStorage();

            storage.Create(item);

            var result = storage.FinById(item.Id);
            Assert.AreEqual(item.Id, result.Id);

        }
        [Test]
        public void WhereCreate_IfNullspecified_ShouldThrowException()
        {
            var storage = new ReminderStorage();
            Assert.Catch<ArgumentNullException>(() =>
                storage.Create(null));


        }

        [Test]
        public void Test1()
        {
            var item = new ReminderItem(
               Guid.NewGuid(),
               "123",
               "Some text",
               DateTimeOffset.Now);
            var storage = new ReminderStorage(item);

            Assert.Catch<ArgumentException>(() => storage.Create(item));
        }
    }
}