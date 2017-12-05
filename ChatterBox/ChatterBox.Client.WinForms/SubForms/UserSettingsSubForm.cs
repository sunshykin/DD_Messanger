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
    public partial class UserSettingsSubForm : Form
    {
        public enum Option
        {
            ChangeUserNameClick,
            ChangeLoginClick,
            ChangePasswordClick,
            ChangePictureClick,
            LogOutClick
        }

        private User _user;

        public UserSettingsSubForm()
        {
            InitializeComponent();
        }

        public UserSettingsSubForm(Guid id) : this()
        {
            try
            {
                _user = DataBaseHelper.GetUser(id);
                userNameLabel.Text = _user.Name;
                userPictureBox.Image = DataBaseHelper.DeserializeImage(_user.Picture);
            }
            catch
            {
                // ignored
            }
            changeNameLabel.Text = "Сменить имя пользователя";
            changeLoginLabel.Text = "Сменить логин";
            changePasswordLabel.Text = "Сменить пароль";
            changePictureLabel.Text = "Сменить аватар";
            logOutLabel.Text = "Выйти из аккаунта";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
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
                case Option.ChangeUserNameClick:
                    changeNameLabel.Click += ev;
                    break;
                case Option.ChangeLoginClick:
                    changeLoginLabel.Click += ev;
                    break;
                case Option.ChangePasswordClick:
                    changePasswordLabel.Click += ev;
                    break;
                case Option.ChangePictureClick:
                    changePictureLabel.Click += ev;
                    break;
                case Option.LogOutClick:
                    logOutLabel.Click += ev;
                    break;
            }
        }

        public void UpdateInfo()
        {
            try
            {
                _user = DataBaseHelper.GetUser(_user.Id);
                userNameLabel.Text = _user.Name;
                userPictureBox.Image = DataBaseHelper.DeserializeImage(_user.Picture);
            }
            catch (Exception ex)
            {
                DataBaseHelper.ExceptionHandler(ex.Message);
            }
        }
    }
}
