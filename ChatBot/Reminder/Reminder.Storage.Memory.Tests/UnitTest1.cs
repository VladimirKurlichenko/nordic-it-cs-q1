using NUnit.Framework;
using Reminder.Storage;
using System;

namespace Reminder.Storage.Memory.Tests
{
    public class ReminderStoregeTests
    {
        [Test]
        public void Create_IfEmptyStorage_ShouldReturnItemByI()
        {
            var item = new ReminderItem(
                Guid.NewGuid(),
                "123",
                "text",
                DateTimeOffset.Now);

            var storege = new ReminderStorage();

            storege.Create(item);

            var result = storege.FindById(item.Id);

            Assert.AreEqual(item.Id, result.Id);

        }

        [Test]
        public void WhenCreate_IfNullSpecified_ShouldThrowException()
        {
            var storage = new ReminderStorage();


            Assert.Catch<ArgumentNullException>(() =>
                storage.Create(null)
            );
        }

        [Test]
        public void WhenCreate_IfExistsElementWithKey_ShouldThrowException()
        {
            var item = CreateReminderItem();
            var storage = new ReminderStorage(
                item
            );

            Assert.Catch<ArgumentException>(() =>
                storage.Create(item)
            );
        }

        private ReminderItem CreateReminderItem(
            Guid? id = default,
            string contactId = default,
            string message = default,
            DateTimeOffset? messageDate = default)
        {
            if (!id.HasValue)
            {
                id = Guid.NewGuid();
            }
            if (contactId == null)
            {
                contactId = "123";
            }
            if (message == null)
            {
                message = "Some text";
            }
            if (!messageDate.HasValue)
            {
                messageDate = DateTimeOffset.UtcNow;
            }
            return new ReminderItem(id.Value, contactId, message, messageDate.Value);
        }
    }
}