using System;
using System.Collections.Generic;

namespace Reminder.Storage
{
    /// <summary>
    /// Определяет основные методы хранилища напоминаний
    /// </summary>
    public interface IReminderStorege
    {
        /// <summary>
        /// Сохроняем новый элемент ReminderItem
        /// </summary>
        /// <param name="item">элемент ReminderItem</param>
        void Create(ReminderItem item);
        /// <summary>
        /// Обновляем данные элемента ReminderItem
        /// </summary>
        /// <param name="item">Элемент ReminderItem</param>
        void Update(ReminderItem item);
        /// <summary>
        /// Реализует поиск элемента ReminderItem по индификатору
        /// </summary>
        /// <param name="id">Индификатор элемента ReminderItem</param>
        /// <returns>Найденый элемент<see cref="ReminderItem"/></returns>
        ReminderItem FinById(Guid id);

        /// <summary>
        /// Возрощает все элементы <see cref="ReminderItem"/> не позднеее указаной даты
        /// </summary>
        /// <param name="dateTime">Дата элемента</param>
        /// <returns>Найденый элемент <see cref="ReminderItem"/> </returns>
        List<ReminderItem> FindByDateTime(DateTimeOffset dateTime);
    }
}
