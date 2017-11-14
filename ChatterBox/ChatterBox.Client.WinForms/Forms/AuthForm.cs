using System;
using System.Windows.Forms;

namespace ChatterBox.Client.WinForms.Forms
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
            authControl.Focus();
        }

        private void login_Click(object sender, EventArgs e)
        {
            try
            {
                var user = Methods.SignIn(authControl.Login, authControl.Password);
                MessageBox.Show($"Добро пожаловать, {user.Name}!", "Добро пожаловать", MessageBoxButtons.OK);
                new MainViewForm(user.Id).Show();
                Hide();
            }
            catch (Exception ex)
            {
                Methods.ExceptionHandler(ex.Message);
            }
        }

        private void signup_Click(object sender, EventArgs e)
        {
            var reg = new RegisterForm();
            var result = reg.ShowDialog();
            if (result == DialogResult.OK)
            {
                new MainViewForm(reg.User.Id).Show();
                Hide();
            }
        }
    }
}
