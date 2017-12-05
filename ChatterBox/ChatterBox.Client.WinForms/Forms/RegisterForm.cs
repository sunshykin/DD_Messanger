using System;
using System.Windows.Forms;
using ChatterBox.Client.WinForms.Helpers;
using ChatterBox.Model;
using ChatterBox.Model.Additional;

namespace ChatterBox.Client.WinForms.Forms
{
    public partial class RegisterForm : Form
    {
        public User User;

        public RegisterForm()
        {
            InitializeComponent();
            registerControl.Focus();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                User = DataBaseHelper.SignUp(new UserOnCreate()
                {
                    Name = registerControl.UserName,
                    Login = registerControl.Login,
                    Password = registerControl.Password,
                    Picture = registerControl.Picture== null ? new byte[]{} : DataBaseHelper.SerializeImage(registerControl.Picture)
                });
                MessageBox.Show("Ваш аккаунт успешно зарегистрирован!", "Регистрация", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                DataBaseHelper.ExceptionHandler(ex.Message);
            }
        }
    }
}
