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
using ChatterBox.Extentions;
using ChatterBox.Model.Additional;
using Message = ChatterBox.Model.Message;

namespace ChatterBox.Client.WinForms.Controls
{
    public partial class MessageControl : UserControl
    {
        private bool _selected;
        private Guid _messageId;

        public Guid MessageId { get { return _messageId; } }

        public enum Option
        {
            DeleteClick,
            ShowButtonClick,
            ImageClick
        }

        public MessageControl()
        {
            InitializeComponent();
        }

        public MessageControl(Message message) : this()
        {
            _selected = false;
            _messageId = message.Id;
            userNameLabel.Text = message.Sender.Name;
            try
            {
                avatarBox.Image = DataBaseHelper.DeserializeImage(message.Sender.Picture);
            }
            catch
            {
                avatarBox.Image = Properties.Resources.DefaultImage;
            }
            if (message.Attachs.Any())
                ShowAttachs(message.Attachs.ToFileList());
            else
                HideAttachs();
            messageTextLabel.Text = message.Text;
            dateLabel.Text = message.Date.ToString("HH:mm:ss");
        }

        private void ColorBack(Color col, object sender)
        {
            mainLayoutPanel.BackColor = col;
            foreach (Control c in mainLayoutPanel.Controls)
                c.BackColor = col;
            foreach (Control c in bodyLayoutPanel.Controls)
                c.BackColor = col;
            foreach (Control c in imageLayoutPanel.Controls)
                c.BackColor = col;

        }

        private void ChangeDateDeleteStatus()
        {
            dateLabel.Visible = !dateLabel.Visible;
            deleteButton.Visible = !deleteButton.Visible;
        }

        private void DeleteButton_MouseEnter(object sender, EventArgs e)
        {
            Message_MouseEnter(sender, e);
        }

        private void DeleteButton_MouseLeave(object sender, EventArgs e)
        {
            ChangeDateDeleteStatus();
            Message_MouseLeave(sender, e);
        }

        private void Message_MouseEnter(object sender, EventArgs e)
        {
            if (!_selected)
                ColorBack(ControlPaint.Light(Color.PaleGreen, 0.8f), sender);
        }

        private void Message_MouseLeave(object sender, EventArgs e)
        {
            if (!_selected)
                ColorBack(Color.White, sender);
        }

        private void SelectingItem_MouseEnter(object sender, EventArgs e)
        {
            Message_MouseEnter(sender, e);
            (sender as Control).BackColor = ControlPaint.Light(Color.LawnGreen, 0.8f);
        }

        private void SelectingItem_MouseLeave(object sender, EventArgs e)
        {
            (sender as Control).BackColor = mainLayoutPanel.BackColor;
            Message_MouseLeave(sender, e);
        }

        private void Date_MouseEnter(object sender, EventArgs e)
        {
            ChangeDateDeleteStatus();
            Message_MouseEnter(sender, e);
        }

        private void Date_MouseLeave(object sender, EventArgs e)
        {
            Message_MouseLeave(sender, e);
        }

        private void HideAttachs()
        {
            bodyLayoutPanel.RowStyles[2].Height = 0;
            bodyLayoutPanel.RowStyles[3].Height = 0;
        }

        private void ShowAttachs(IEnumerable<File> files)
        {
            bodyLayoutPanel.RowStyles[2].Height = 20;
            bodyLayoutPanel.RowStyles[3].Height = 20;
            showAttachsLabel.Text = $"Посмотреть все файлы ({files.Count()})";
            var images = files.Where(f => DataBaseHelper.IsImage(f.FileData)).Select(i => DataBaseHelper.DeserializeImage(i.FileData));
            switch (images.Count())
            {
                case 1:
                    bodyLayoutPanel.RowStyles[3].Height = imageLayoutPanel.Width - 60;
                    imageLayoutPanel.ColumnStyles[1].Width = 100;
                    imageLayoutPanel.ColumnStyles[2].Width = 0;
                    imageLayoutPanel.ColumnStyles[3].Width = 0;
                    image1Box.Image = images.ElementAt(0);
                    break;
                case 2:
                    bodyLayoutPanel.RowStyles[3].Height = (imageLayoutPanel.Width - 60) / 2;
                    imageLayoutPanel.ColumnStyles[1].Width = 50;
                    imageLayoutPanel.ColumnStyles[2].Width = 50;
                    imageLayoutPanel.ColumnStyles[3].Width = 0;
                    image1Box.Image = images.ElementAt(0);
                    image2Box.Image = images.ElementAt(1);
                    break;
                case 3:
                    bodyLayoutPanel.RowStyles[3].Height = (imageLayoutPanel.Width - 60) / 3;
                    imageLayoutPanel.ColumnStyles[1].Width = 33.33f;
                    imageLayoutPanel.ColumnStyles[2].Width = 33.33f;
                    imageLayoutPanel.ColumnStyles[3].Width = 33.33f;
                    image1Box.Image = images.ElementAt(0);
                    image2Box.Image = images.ElementAt(1);
                    image3Box.Image = images.ElementAt(2);
                    break;
                default:
                    bodyLayoutPanel.RowStyles[3].Height = 0;
                    break;
            }
            if (bodyLayoutPanel.RowStyles[2].Height + bodyLayoutPanel.RowStyles[3].Height < 40)
            {
                Height -= 40 - (int)bodyLayoutPanel.RowStyles[2].Height - (int)bodyLayoutPanel.RowStyles[3].Height;
            }
        }


        public void SetEvent(Option option, EventHandler ev)
        {
            switch (option)
            {
                case Option.DeleteClick:
                    deleteButton.Click += ev;
                    break;
                case Option.ShowButtonClick:
                    showAttachsLabel.Click += ev;
                    break;
                case Option.ImageClick:
                    image1Box.Click += ev;
                    image2Box.Click += ev;
                    image3Box.Click += ev;
                    break;
            }
        }
    }
}
