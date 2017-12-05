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
    public partial class SimpleYesNoSubForm : Form
    {
        public SimpleYesNoSubForm()
        {
            InitializeComponent();
        }

        public SimpleYesNoSubForm(string question) : this()
        {
            infoTextLabel.Text = $"Вы действительно хотите {question}?";
            yesButton.Text = "Да";
            noButton.Text = "Нет";
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = ControlPaint.Light(Color.PaleGreen, 0.8f);
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {

            ((Control)sender).BackColor = Color.White;
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();

        }
    }
}
