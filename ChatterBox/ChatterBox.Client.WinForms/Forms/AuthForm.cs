using System;
using System.Windows.Forms;
using ChatterBox.Client.WinForms.Helpers;

namespace ChatterBox.Client.WinForms.Forms
{
    public partial class AuthForm : Form
    {
        private readonly AuthSerializationHelper _authSerializationHelper;

        public AuthForm()
        {
            InitializeComponent();
            ActiveControl = authControl;
            authControl.StartFocus();
            authControl.Controls["loginTextBox"].KeyDown += AuthForm_KeyDown;
            authControl.Controls["passwordTextBox"].KeyDown += AuthForm_KeyDown;
            _authSerializationHelper = new AuthSerializationHelper();
            try
            {
                var info = _authSerializationHelper.Load();
                authControl.Controls["loginTextBox"].Text = info.Login;
                authControl.Controls["passwordTextBox"].Text = info.Password;
            }
            catch
            {
                // ignored
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                var user = DataBaseHelper.SignIn(authControl.Login, authControl.Password);
                _authSerializationHelper.Save(authControl.Login, authControl.Password);
                MessageBox.Show($"Добро пожаловать, {user.Name}!", "Добро пожаловать", MessageBoxButtons.OK);
                new MainViewForm(user.Id, this).Show();
                Hide();
            }
            catch (Exception ex)
            {
                DataBaseHelper.ExceptionHandler(ex.Message);
            }
            Cursor = Cursors.Default;
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            var reg = new RegisterForm();
            var result = reg.ShowDialog();
            if (result == DialogResult.OK)
            {
                new MainViewForm(reg.User.Id, this).Show();
                Hide();
            }
        }

        private void AuthForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton.Focus();
                Login_Click(sender, null);
            }
        }
    }
}
