using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ChatterBox.Client.WinForms.Controls;
using ChatterBox.Model;
using ChatterBox.Model.Additional;

namespace ChatterBox.Client.WinForms.Forms
{
    public partial class MainViewForm : Form
    {
        /// <summary>
        /// Номер первого чата на странице
        /// </summary>
        private int firstChat = 0;
        
        /// <summary>
        /// Уникальный идентификатор текущего пользователя
        /// </summary>
        private Guid _userId;
        /// <summary>
        /// Уникальный идентификатор текущего чата
        /// </summary>
        private Guid _chatId;

        /// <summary>
        /// Список всех чатов пользователя
        /// </summary>
        private List<ChatControl> _chats;

        /// <summary>
        /// Максимальное количество чатов умещающихся на экране
        /// </summary>
        private int maxChatCount { get { return chatsLayoutPanel.Height / new ChatControl().Height; } }

        /// <summary>
        /// Предыдущее количество чатов, отображаемых на экране
        /// </summary>
        internal int prevMaxChatCount;

        public MainViewForm(Guid userId)
        {
            InitializeComponent();
            _userId = userId;
            _chatId = Guid.Empty;
            _chats = new List<ChatControl>();
            try
            {
                var chats = Methods.UserChats(_userId);
                foreach (var c in chats)
                {
                    var cont = new ChatControl(c);
                    cont.SetClickHandler(Chat_Click);
                    _chats.Add(cont);
                }
            }
            catch (Exception e)
            {
                //Обработать ошибку
            }
            customDrawChats();
        }

        private void chats_MouseEnter(object sender, EventArgs e)
        {
            chatsLayoutPanel.Focus();
        }

        private void customDrawChats()
        {
            prevMaxChatCount = maxChatCount;
            chatsLayoutPanel.Controls.Clear();
            for (int i = 0; i < maxChatCount && firstChat + i < _chats.Count; i++)
                chatsLayoutPanel.Controls.Add(_chats.ElementAt(firstChat + i));
        }

        private void chats_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                if (firstChat - 1 >= 0)
                {
                    firstChat -= 1;
                    customDrawChats();
                }
            }
            else
            {
                if (firstChat + 1 <= _chats.Count - maxChatCount)
                {
                    firstChat += 1;
                    customDrawChats();
                }
            }
        }

        private void Chat_Click(object sender, EventArgs e)
        {
            Control cont = (Control)sender;
            while (cont.GetType() != typeof(ChatControl))
                cont = cont.Parent;
            if (_chatId != Guid.Empty)
                _chats.First(c => c.Id == _chatId).BackColor = Color.White;
            var chat = (ChatControl) cont;
            chat.BackColor = Color.LightSkyBlue;
            _chatId = chat.Id;
            MessagesRefresh(false);
        }

        private void MessagesRefresh(bool refresh)
        {
            var chat = _chats.First(c => c.Id == _chatId);
            if (refresh)
                chat.RefreshMessages();
            var messages = chat.Messages;
            messageShowLayoutPanel.Controls.Clear();
            foreach (var m in messages.OrderBy(m => m.Date))
                messageShowLayoutPanel.Controls.Add(new MessageControl(m));
        }

        private void Form_ResizeEnd(object sender, EventArgs e)
        {
            if (prevMaxChatCount != maxChatCount)
            {
                customDrawChats();
                MessagesRefresh(false);
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                Methods.SendMessage(new MessageOnCreate()
                {
                    ChatId = _chatId,
                    UserId = _userId,
                    Text = messageTextBox.Text
                });
                MessagesRefresh(true);
                messageTextBox.Clear();
            }
            catch (Exception ex)
            {
                //Обработать ошибку
            }
        }
    }
}