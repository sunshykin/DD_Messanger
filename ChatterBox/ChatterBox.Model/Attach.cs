using System;

namespace ChatterBox.Model
{
    public class Attach
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Имя файла
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// Файл
        /// </summary>
        public byte[] FileData { get; set; }
        /// <summary>
        /// Пользователь, загрузивший файл
        /// </summary>
        public User Sender { get; set; }
    }
}
