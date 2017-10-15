using System;

namespace ChatterBox.Model
{
    public class Attach
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Путь до файла
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// Пользователь, загрузивший файл
        /// </summary>
        public User Sender { get; set; }
    }
}
