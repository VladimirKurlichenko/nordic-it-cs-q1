using NUnit.Framework;
using System;

namespace Reminder.Storage.Memory.Tests
{
    public class ReminderItemTest
    {
        [Test]
        public void WhenDefine_IfIdIsDefault_ThrowException()
        {
            Assert.Catch<ArgumentException>(() =>
                new ReminderItem(
                   default,
                    "test1",
                    "test2",
                    DateTimeOffset.Now)
                );
        }

        [Test]
        public void WhenDefine_IfCondactIdIsDefault_ThrowException()
        {
            Assert.Catch<ArgumentException>(() =>
                new ReminderItem(
                   Guid.NewGuid(),
                    null,
                    "test2",
                    DateTimeOffset.Now)
                );
        }

        [Test]
        public void WhenDefine_IfMessageIsDefault_ThrowException()
        {
            Assert.Catch<ArgumentException>(() =>
                new ReminderItem(
                   Guid.NewGuid(),
                    "test1",
                    null,
                    DateTimeOffset.Now)
                );
        }

        [Test]
        public void WhenDefine_IfDateTimeIsDefault_ThrowException()
        {
            Assert.Catch<ArgumentException>(() =>
                new ReminderItem(
                   Guid.NewGuid(),
                    "test1",
                    "test2",
                    default)
                );
        }
    }
}