using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace ChatterBox.Model.Additional
{
    public class MessageOnCreate
    {
        /// <summary>
        /// Текст сообщения
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// Id отправителя
        /// </summary>
        public Guid UserId { get; set; }
        /// <summary>
        /// Id чата
        /// </summary>
        public Guid ChatId { get; set; }
        /// <summary>
        /// Прикрепленные к сообщению файлы
        /// </summary>
        public IEnumerable<File> Files { get; set; }
        /// <summary>
        /// Состояние самоуничтожения сообщения
        /// </summary>
        public bool SelfDestruction { get; set; }
        /// <summary>
        /// Время самоуничтожения письма
        /// </summary>
        public string DestructionTime { get; set; }
    }
}