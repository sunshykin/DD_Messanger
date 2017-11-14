using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatterBox.Client.WinForms.Controls
{
    public partial class RegisterControl : UserControl
    {
        public string UserName { get { return nameTextBox.Text; } }
        public string Login { get { return loginTextBox.Text; } }
        public string Password { get { return passwordTextBox.Text; } }

        public RegisterControl()
        {
            InitializeComponent();
        }

        private void selectImage_Click(object sender, EventArgs e)
        {
            var result = selectFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectImageButton.Text = "Файл выбран";//selectFileDialog.SafeFileName;

            }

        }
    }
}
