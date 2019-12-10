using System;
using System.Collections.Generic;

namespace Reminder.Storage
{
    /// <summary>
    /// Определяет основные методы хранилища напоминаний
    /// </summary>
    public interface IReminderStorage
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
        /// Возрощает все элементы <see cref="ReminderItem"/> по фильтру
        /// </summary>
        /// <param name="filter">параметры фильтрации</param>
        /// <returns>Найденый элемент <see cref="ReminderItem"/> </returns>
        List<ReminderItem> FindBy(ReminderItemFilter filter);
    }
}
