using System;

namespace ChatterBox.Model.Additional
{
    public class SearchInfo
    {
        /// <summary>
        /// Id пользователя
        /// </summary>
        public Guid UserId { get; set; }
        /// <summary>
        /// Ключевое слово для поиска
        /// </summary>
        public string KeyWord { get; set; }
    }
}