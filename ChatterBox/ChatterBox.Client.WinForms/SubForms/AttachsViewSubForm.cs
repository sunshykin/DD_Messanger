using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatterBox.Client.WinForms.Controls;
using ChatterBox.Client.WinForms.Helpers;
using ChatterBox.Model.Additional;

namespace ChatterBox.Client.WinForms.SubForms
{
    public partial class AttachsViewSubForm : Form
    {

        public AttachsViewSubForm()
        {
            InitializeComponent();
        }

        public AttachsViewSubForm(string title, IEnumerable<File> files) : this()
        {
            titleLabel.Text = title;
            downloadLabel.Text = "Загрузить все файлы";
            foreach (var f in files)
            {
                attachsLargeLayoutPanel.Controls.Add(new AttachLargeControl(f));
            }
        }

        private void ClickButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void UpdateDownloadButton()
        {
            var selected = attachsLargeLayoutPanel.Controls.OfType<AttachLargeControl>().Where(a => a.Selected).ToList();
            switch (selected.Count)
            {
                case 0:
                    downloadLabel.Text = "Загрузить все файлы";
                    break;
                case 1:
                    downloadLabel.Text = "Загрузить 1 файл";
                    break;
                case 2:
                case 3:
                case 4:
                    downloadLabel.Text = $"Загрузить {selected.Count} файла";
                    break;
                default:
                    downloadLabel.Text = $"Загрузить {selected.Count} файлов";
                    break;
            }
        }

        private void DownloadButton_MouseEnter(object sender, EventArgs e)
        {
            downloadLabel.BackColor = ControlPaint.Light(Color.PaleGreen, 0.8f);
        }

        private void DownloadButton_MouseLeave(object sender, EventArgs e)
        {
            downloadLabel.BackColor = Color.White;
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            var selected = attachsLargeLayoutPanel.Controls.OfType<AttachLargeControl>().Where(a => a.Selected).ToList();
            if (selected.Count == 0)
            {
                DataBaseHelper.DeserializeFiles(attachsLargeLayoutPanel.Controls.OfType<AttachLargeControl>().Select(c => c.File));
            }
            else
            {
                DataBaseHelper.DeserializeFiles(selected.Select(c => c.File));
            }
            Close();
        }
    }
}
