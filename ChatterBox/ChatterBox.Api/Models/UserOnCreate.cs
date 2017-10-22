using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatterBox.Api.Models
{
    public class UserOnCreate
    {
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Аватарка пользователя
        /// </summary>
        public string Picture { get; set; }
        /// <summary>
        /// Логин для входа в систему
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// Пароль для входа в систему
        /// </summary>
        public string Password { get; set; }
    }
}