using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatterBox.Model
{
    public class User
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Аватарка пользователя
        /// </summary>
        public byte[] Picture { get; set; }
        /// <summary>
        /// Информация для входа в систему
        /// </summary>
        public Auth LogInfo { get; set; }
    }
}
