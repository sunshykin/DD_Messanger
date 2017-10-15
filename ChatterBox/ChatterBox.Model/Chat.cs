using System;
using System.Collections.Generic;

namespace ChatterBox.Model
{
    public class Chat
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Название чата
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Аватарка чата
        /// </summary>
        public string Picture { get; set; }
        /// <summary>
        /// Участники чата
        /// </summary>
        public IEnumerable<User> Members { get; set; }
        /// <summary>
        /// Сообщения чата
        /// </summary>
        public IEnumerable<Message> Messages { get; set; }
        /// <summary>
        /// Прикрепленные файлы
        /// </summary>
        public IEnumerable<Attach> Attachs { get; set; }
    }
}
