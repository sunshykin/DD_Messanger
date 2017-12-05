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
    public partial class CommonSettingsSubForm : Form
    {
        public enum Option
        {
            UserSettingsClick,
            UserContactsClick,
            NewChatClick
        }

        public CommonSettingsSubForm()
        {
            InitializeComponent();
            newChatLabel.Text = "Добавить новый чат";
            contactsLabel.Text = "Список контактов";
            userSettingsLabel.Text = "Настройки";
        }

        private void CommonItem_MouseEnter(object sender, EventArgs e)
        {
            Control ctrl = sender as Control;
            ctrl.BackColor = ControlPaint.Light(Color.PaleGreen, 0.8f);
        }

        private void CommonItem_MouseLeave(object sender, EventArgs e)
        {
            Control ctrl = sender as Control;
            ctrl.BackColor = Color.White;
        }

        public void SetEvent(Option option, EventHandler ev)
        {
            switch (option)
            {
                case Option.UserSettingsClick:
                    userSettingsLabel.Click += ev;
                    break;
                case Option.UserContactsClick:
                    contactsLabel.Click += ev;
                    break;
                case Option.NewChatClick:
                    newChatLabel.Click += ev;
                    break;
            }

        }
    }
}
