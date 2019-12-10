using System;
using System.Threading;
using Reminder.Storage;

namespace Reminder.Domain
{
    public class CreateReminderModel
    {
        public string ContactId { get; set; }
        public string Message { get; set; }
        public DateTimeOffset MessageDate { get; set; }
    }
    public class ReminderService
    {
        private readonly Timer _createdItemTimer;

        private readonly Timer _readyItemTimer;

        private readonly IReminderStorage _storage;

        public ReminderService (IReminderStorage storage)
        {
            _storage = storage;
            _createdItemTimer = new Timer(OnCreatedTimeTick, null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
            _readyItemTimer = new Timer(OnReadyItemTimeTick, null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
        }

        public void Create(CreateReminderModel model)
        {
            var item = new ReminderItem(
                Guid.NewGuid(),
                model.ContactId,
                model.Message,
                model.MessageDate);

            _storage.Create(item);
        }

        private void OnCreatedTimeTick(object state)
        {
            var dateTime = DateTimeOffset.Now;
            var filter = new ReminderItemFilter()
                .At(DateTimeOffset.Now)
                .Created();
            var items = _storage.FindBy(filter);
            foreach (var item in items)
            {
                item.ReadyToSend();
                _storage.Update(item);
            }
        }

        private void OnReadyItemTimeTick(object state)
        {
            var filter = new ReminderItemFilter()
                .Ready();
            var items = _storage.FindBy(filter);
            foreach (var item in items)
            {

            }
        }
        

        public void Start()
        {

        }
    }
}
