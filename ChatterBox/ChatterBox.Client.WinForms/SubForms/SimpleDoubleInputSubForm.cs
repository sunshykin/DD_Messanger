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
    public partial class SimpleDoubleInputSubForm : Form
    {
        public string Item1 { get { return item1TextBox.Text; } }
        public string Item2 { get { return item2TextBox.Text; } }

        public SimpleDoubleInputSubForm()
        {
            InitializeComponent();
        }

        public SimpleDoubleInputSubForm(string param, string title1, string title2, bool bothPassword = false) : this()
        {
            titleLabel.Text = $"Изменить {param}";
            item1Label.Text = title1;
            item2Label.Text = title2;

            if (bothPassword)
                item1TextBox.PasswordChar = '•';
        }
    }
}
