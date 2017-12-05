using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatterBox.Client.WinForms.Helpers;
using ChatterBox.Model;

namespace ChatterBox.Client.WinForms.SubForms
{
    public partial class ChatInfoSubForm : Form
    {
        public enum Option
        {
            ChatMembersClick,
            LeaveChatClick,
            DeleteChatClick
        }

        public ChatInfoSubForm()
        {
            InitializeComponent();
        }

        public ChatInfoSubForm(Chat chat) : this()
        {
            chatTitleLabel.Text = chat.Title;
            try
            {
                chatPictureBox.Image = DataBaseHelper.DeserializeImage(chat.Picture);
            }
            catch
            {
                chatPictureBox.Image = Properties.Resources.DefaultImage;
            }
            int membersCount = chat.Members.Count();
            string memberCountPostfix;
            switch (membersCount % 10)
            {
                case 1:
                    memberCountPostfix = membersCount % 100 == 11 ? "ов" : "";
                    break;
                case 2:
                case 3:
                case 4:
                    memberCountPostfix =
                        membersCount % 100 > 10 && membersCount % 100 < 15 ? "ов" : "а";
                    break;
                default:
                    memberCountPostfix = "ов";
                    break;
            }
            membersLabel.Text = $"{membersCount} участник{memberCountPostfix}";
            leaveChatLabel.Text = "Покинуть данный чат";
            deleteChatLabel.Text = "Удалить данный чат";
        }

        private void ChatInfo_MouseEnter(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = ControlPaint.Light(Color.PaleGreen, 0.8f);
        }

        private void ChatInfo_MouseLeave(object sender, EventArgs e)
        {
            ((Control) sender).BackColor = Color.White;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SetEvent(Option option, EventHandler ev)
        {
            switch (option)
            {
                case Option.ChatMembersClick:
                    membersLabel.Click += ev;
                    break;
                case Option.LeaveChatClick:
                    leaveChatLabel.Click += ev;
                    break;
                case Option.DeleteChatClick:
                    deleteChatLabel.Click += ev;
                    break;
            }
        }
    }
}
