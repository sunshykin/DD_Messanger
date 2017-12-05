using System;
using System.Collections.Generic;
using System.Security.Cryptography;

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
        /// Аватар чата
        /// </summary>
        public byte[] Picture { get; set; }
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
