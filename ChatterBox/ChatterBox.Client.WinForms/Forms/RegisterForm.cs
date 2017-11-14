using System;
using System.Windows.Forms;
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

        private void ok_Click(object sender, EventArgs e)
        {
            try
            {
                User = Methods.SignUp(new UserOnCreate()
                {
                    Name = registerControl.UserName,
                    Login = registerControl.Login,
                    Password = registerControl.Password
                });
                MessageBox.Show("Ваш аккаунт успешно зарегистрирован!", "Регистрация", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                Methods.ExceptionHandler(ex.Message);
            }
        }
    }
}
