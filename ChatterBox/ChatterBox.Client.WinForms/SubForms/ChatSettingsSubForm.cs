using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatterBox.Client.WinForms.SubForms
{
    public partial class ChatSettingsSubForm : Form
    {
        public enum Option
        {
            ChangeTitleClick,
            ChangePictureClick,
            ShowAttachsClick
        }

        public ChatSettingsSubForm()
        {
            InitializeComponent();
            changeTitleLabel.Text = "Изменить название чата";
            changePictureLabel.Text = "Изменить аватар чата";
            showAttachsLabel.Text = "Показать вложения";
        }

        private void SettingsItem_MouseEnter(object sender, EventArgs e)
        {
            Control ctrl = sender as Control;
            ctrl.BackColor = ControlPaint.Light(Color.PaleGreen, 0.8f);
        }

        private void SettingsItem_MouseLeave(object sender, EventArgs e)
        {
            Control ctrl = sender as Control;
            ctrl.BackColor = Color.White;
        }

        public void SetEvent(Option option, EventHandler ev)
        {
            switch (option)
            {
                case Option.ChangeTitleClick:
                    changeTitleLabel.Click += ev;
                    break;
                case Option.ChangePictureClick:
                    changePictureLabel.Click += ev;
                    break;
                case Option.ShowAttachsClick:
                    showAttachsLabel.Click += ev;
                    break;
            }
        }
    }
}
