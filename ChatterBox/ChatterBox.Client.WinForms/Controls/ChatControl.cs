using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatterBox.Client.WinForms.Helpers;
using ChatterBox.Model;
using Message = ChatterBox.Model.Message;

namespace ChatterBox.Client.WinForms.Controls
{
    public partial class ChatControl : UserControl
    {
        private Guid _id;
        private IEnumerable<Message> _messages;
        private bool _clicked;

        public IEnumerable<Message> Messages { get { return _messages ?? new List<Message>(); } }
        public Guid Id { get { return _id; } }
        public bool Clicked { get { return _clicked; } set { _clicked = value; } }

        public ChatControl()
        {
            InitializeComponent();
        }

        public ChatControl(Chat chat) : this()
        {
            _clicked = false;
            UpdateView(chat);
        }

        private void ChatControl_MouseEnter(object sender, EventArgs e)
        {
            if (!_clicked)
                BackColor = ControlPaint.Light(Color.PaleGreen, 0.8f);
        }

        private void ChatControl_MouseLeave(object sender, EventArgs e)
        {
            if (!_clicked)
                BackColor = Color.White;
        }

        private void ChatControl_Click(object sender, EventArgs e)
        {
            if (_messages == null)
            {
                try
                {
                    _messages = DataBaseHelper.ChatMessages(_id);
                }
                catch (Exception ex)
                {
                    _messages = new List<Message>();
                    DataBaseHelper.ExceptionHandler(ex.Message);
                }
            }
        }

        public void SetClickHandler(EventHandler ev)
        {
            Click += ev;
            mainLayoutPanel.Click += ev;
            textLayoutPanel.Click += ev;
            avatarBox.Click += ev;
            chatTitleLabel.Click += ev;
            messageLabel.Click += ev;
        }

        public void RefreshMessages(string key = null)
        {
            try
            {
                if (key == null)
                    _messages = DataBaseHelper.ChatMessages(_id);
                else
                {
                    var list = DataBaseHelper.ChatMessages(_id).Where(m => m.Text.ToLower().Contains(key));
                    _messages = list.Count() == 0 ? new List<Message>() : list.ToList();

                }
            }
            catch (Exception ex)
            {
                _messages = new List<Message>();
                DataBaseHelper.ExceptionHandler(ex.Message);
            }
        }

        public void UpdateView(Chat chat)
        {
            _id = chat.Id;
            chatTitleLabel.Text = chat.Title;
            messageLabel.Text = chat.Messages.Count() != 0 ?
                chat.Messages.OrderByDescending(m => m.Date).ElementAt(0).Text : "Нет сообщений";
            try
            {
                avatarBox.Image = DataBaseHelper.DeserializeImage(chat.Picture);
            }
            catch
            {
                avatarBox.Image = Properties.Resources.DefaultImage;
            }
        }
    }
}
