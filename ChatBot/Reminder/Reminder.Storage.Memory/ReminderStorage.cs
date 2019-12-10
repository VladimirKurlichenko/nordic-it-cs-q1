﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Reminder.Storage.Memory.Tests")]


namespace Reminder.Storage.Memory
{
    public class ReminderStorage : IReminderStorage
    {
        private readonly Dictionary<Guid, ReminderItem> _map =
            new Dictionary<Guid, ReminderItem>();

        internal ReminderStorage(params ReminderItem[] items)
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
            {
                throw new ArgumentNullException(nameof(item));
            }

            if (_map.ContainsKey(item.Id))
            {
                throw new ArgumentException($"Уже существует элемент с идентификатором {item.Id}");
            }


            _map[item.Id] = item;
             
        }

        public List<ReminderItem> FindBy(ReminderItemFilter filter)
        {
            if (filter == null)
            {
                throw new ArgumentNullException(nameof(filter));
            }

            var result = _map.Values.AsEnumerable();

            if (filter.Status.HasValue)
            {
                result = result.Where(item => item.Status == filter.Status.Value);
            }

            if (filter.DateTime.HasValue)
            {
                result = result.Where(item => item.MessageDate < filter.DateTime.Value);
            }

            return result.ToList();
        }

        public ReminderItem FindById(Guid id)
        {
            if (_map.ContainsKey(id))
            {
                return _map[id];
            }
            else
            {
                throw new ArgumentException($"Не найдет элемент с ключем {id}", nameof(id));
            }
        }

        public void Update(ReminderItem item)
        {
            _map[item.Id] = item;
        }
    }
}
