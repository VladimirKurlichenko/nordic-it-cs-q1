using System;
using System.Collections.Generic;

namespace Reminder.Storage
{
    /// <summary>
    /// Определянет основные методы хранилища напониманий
    /// </summary>
    public interface IReminderStorage
    {
        /// <summary>
        /// Создает новый элемент ReminderItem
        /// </summary>
        /// <param name="item">Элемент ReminderItem</param>
        void Create(ReminderItem item);
        /// <summary>
        /// Обновляет данные элемента ReminderItem
        /// </summary>
        /// <param name="item">Элемент ReminderItem</param>
        void Update(ReminderItem item);

        /// <summary>
        /// Реализует поис элемента ReminderItem по индификатору
        /// </summary>
        /// <param name="id">Индификатор элемента</param>
        /// <returns> Найденый элемент</returns>
        ReminderItem FindById(Guid id);
        /// <summary>
        /// Возвращает все элеменеты <see cref="ReminderItem"/> удовлетворяющие условиям
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
         List<ReminderItem> FindBy(ReminderItemFilter filter);
    }
}
