using System;
using System.Collections.Generic;

namespace ChatterBox.Model
{
    public class Message
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Текст сообщения
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// Дата отправки сообщения
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Состояние самоуничтожения сообщения
        /// </summary>
        public bool SelfDestruction { get; set; }
        /// <summary>
        /// Время самоуничтожения письма
        /// </summary>
        public DateTime SelfDestructionDate { get; set; }
        /// <summary>
        /// Пользователь, отправивший сообщение
        /// </summary>
        public User Sender { get; set; }
        /// <summary>
        /// Прикрепленные к сообщению файлы
        /// </summary>
        public IEnumerable<Attach> Attachs { get; set; }
        /// <summary>
        /// Чат, в который было отправлено сообщение
        /// </summary>
        public Chat Chat { get; set; }
    }
}
