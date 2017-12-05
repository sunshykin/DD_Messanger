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
    public partial class SimpleFileLoadSubForm : Form
    {
        public string Result;

        public SimpleFileLoadSubForm()
        {
            InitializeComponent();
        }

        public SimpleFileLoadSubForm(string title) : this()
        {
            titleLabel.Text = $"Загрузить {title}?";
        }

        private void LoadFile_Click(object sender, EventArgs e)
        {
            var result = loadFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                loadFileButton.Text = "Файл выбран";
                Result = loadFileDialog.FileName;
            }
        }
    }
}
