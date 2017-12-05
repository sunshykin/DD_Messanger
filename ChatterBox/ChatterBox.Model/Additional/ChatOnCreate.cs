using System;
using System.Collections.Generic;

namespace ChatterBox.Model.Additional
{
    public class ChatOnCreate
    {
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
        public IEnumerable<Guid> Members { get; set; }
    }
}