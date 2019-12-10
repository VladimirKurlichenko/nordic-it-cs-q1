using System;

namespace Reminder.Storage
{

    public class ReminderItem
    {
        public Guid Id { get; }
        public string ContactId { get; private set; }
        public string Message { get; private set; }
        public DateTimeOffset MessageDate { get; private set; }
        public ReminderItemStatus Status { get; private set; }

        public ReminderItem(
            Guid id,
            string contactId,
            string message,
            DateTimeOffset messageDate,
            ReminderItemStatus status = ReminderItemStatus.Created)
        {
            if(id == default)
            {
                throw new ArgumentException("Индификатор пустой", nameof(id));
            };

            if (contactId == default)
            {
                throw new ArgumentException("Индификатор контакта пустой", nameof(contactId));
            };

            if (message == default)
            {
                throw new ArgumentException("Сообщение пустое", nameof(message));
            };

            if (messageDate == default)
            {
                throw new ArgumentException("Дата сообщения не задана", nameof(messageDate));
            };
            if (messageDate == default)
            {
                throw new ArgumentException("Дата сообщения не задана", nameof(messageDate));
            };

            Id = id;
            ContactId = contactId;
            Message = message;
            MessageDate = messageDate;
            Status = status;
        }

        public void ReadyToSend(ReminderItem item)
        {
            if(Status == ReminderItemStatus.Created)
            {
                throw new InvalidOperationException("Некорректный статус");
            }

            Status = ReminderItemStatus.Ready;
        }
    }
}
