using System;
using System.Collections.Generic;
using System.Linq;

using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Reminder.Storage.Memory.Tests")]
namespace Reminder.Storage.Memory
{
    public class ReminderStorage : IReminderStorege
    {
        private readonly Dictionary<Guid, ReminderItem> _map;

        internal ReminderStorage (params ReminderItem[] items)
        {
            _map = items.ToDictionary(item => item.Id);
        }
        public ReminderStorage()
        {
            _map = new Dictionary<Guid, ReminderItem>();
        }

        public void Create(ReminderItem item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            if (_map.ContainsKey(item.Id))
                throw new ArgumentException($"Уже существует элемен с индификатором {item.Id}", nameof(item));
            _map[item.Id] = item;
        }

        public ReminderItem FinById(Guid id)
        {
            if (!_map.ContainsKey(id))
            {
                throw new ArgumentException($"Не найден элемент с ключем {id}", nameof(id));
            }
            return _map[id];

        }

        public List<ReminderItem> FindByDateTime(DateTimeOffset dateTime)
        {
            var list = new List<ReminderItem>();

            foreach (var item in _map)
            {
                if(item.Value.MessageDate == dateTime)
                {
                    list.Add(item.Value);
                }
            }
            return list;
        }

        public void Update(ReminderItem item)
        {
            if (!_map.ContainsKey(item.Id))
            {   
                throw new ArgumentException($"Не найден элемент с ключем {item.Id}", nameof(item.Id));
            }
            else
            {
                _map[item.Id] = item;
            }
        }
    }
}
