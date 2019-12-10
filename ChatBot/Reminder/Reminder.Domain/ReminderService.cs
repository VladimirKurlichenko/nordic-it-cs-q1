using Reminder.Storage;
using System;
using System.Threading;

namespace Reminder.Domain
{
    public class ReminderService
    {
        private readonly IReminderStorage _storage;
        private readonly Timer _createdItemTimer;
        private readonly Timer _readyItemTimer;

        public ReminderService(IReminderStorage storage)
        {
            _storage = storage;
            _createdItemTimer = new Timer(OnCreatedItemTimerTick, null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
            _readyItemTimer = new Timer(OnReadyItemTimerTick, null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
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

        private void OnCreatedItemTimerTick(object state)
        {
            var filter = new ReminderItemFilter()
                .At(DateTimeOffset.Now)
                .Created();


            var items = _storage.FindBy(filter);

            foreach (var item in items)
            {
                _storage.Update(item.ReadyToSend());
            }
        }

        private void OnReadyItemTimerTick(object state)
        {
            var filter = new ReminderItemFilter()
                .Ready();

            var items = _storage.FindBy(filter);

        }
    }
}
