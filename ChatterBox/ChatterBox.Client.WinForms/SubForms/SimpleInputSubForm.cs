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
    public partial class SimpleInputSubForm : Form
    {
        public string Result { get { return itemTextBox.Text; } }

        public SimpleInputSubForm()
        {
            InitializeComponent();
        }

        public SimpleInputSubForm(string param, string value) : this()
        {
            titleLabel.Text = $"Изменить {param}:";
            itemTextBox.Text = value;
        }
    }
}
