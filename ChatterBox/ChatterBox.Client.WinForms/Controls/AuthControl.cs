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
    public partial class AuthControl : UserControl
    {
        public string Login { get { return loginTextBox.Text; } }
        public string Password { get { return passwordTextBox.Text; } }

        public AuthControl()
        {
            InitializeComponent();
        }
    }
}
