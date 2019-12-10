using System;

namespace Reminder.Domain
{
    public class CreateReminderModel
    {
        public string ContactId { get; set; }
        public string Message { get; set; }
        public DateTimeOffset MessageDate { get; set; }
    }
}
