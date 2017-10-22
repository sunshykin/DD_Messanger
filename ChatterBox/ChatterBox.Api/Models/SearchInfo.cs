using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatterBox.Api.Models
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