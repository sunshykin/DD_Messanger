using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatterBox.Model;
using Message = ChatterBox.Model.Message;

namespace ChatterBox.Client.WinForms.Controls
{
    public partial class ChatControl : UserControl
    {
        private Guid _id;
        public IEnumerable<Message> Messages;
        public Guid Id { get { return _id; } }

        public ChatControl()
        {
            InitializeComponent();
        }

        public ChatControl(Chat chat) : this()
        {
            _id = chat.Id;
            var t = mainLayoutPanel.Controls["textLayoutPanel"];
            t.Controls["chatTitleLabel"].Text = chat.Title;
            t.Controls["messageLabel"].Text = chat.Messages.Count() != 0 ? 
                chat.Messages.OrderByDescending(m => m.Date).ElementAt(0).Text : "Нет сообщений";
            ((PictureBox)mainLayoutPanel.Controls["avatarBox"]).Image = Properties.Resources.DefaultImage;
        }

        private void ChatControl_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.LightBlue;
        }

        private void ChatControl_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void ChatControl_Click(object sender, EventArgs e)
        {
            if (Messages == null)
            {
                try
                {
                    Messages = Methods.ChatMessages(_id);
                }
                catch (Exception ex)
                {
                    Messages = new List<Message>();
                    //Обработать ошибку
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

        public void RefreshMessages()
        {
            try
            {
                Messages = Methods.ChatMessages(_id);
            }
            catch (Exception ex)
            {
                Messages = new List<Message>();
                //Обработать ошибку
            }
        }
    }
}
