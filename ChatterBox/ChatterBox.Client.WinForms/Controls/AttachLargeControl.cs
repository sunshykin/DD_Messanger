using System.Drawing;
using System.Windows.Forms;
using ChatterBox.Client.WinForms.Helpers;
using ChatterBox.Client.WinForms.SubForms;
using ChatterBox.Extentions;
using ChatterBox.Model;
using ChatterBox.Model.Additional;

namespace ChatterBox.Client.WinForms.Controls
{
    public partial class AttachLargeControl : UserControl
    {
        private bool _selected;
        private File _file;

        public bool Selected { get { return _selected; } }
        public File File { get { return _file; } }

        public AttachLargeControl()
        {
            InitializeComponent();
        }
        public AttachLargeControl(File file) : this()
        {
            _selected = false;
            _file = file;
            fileNameLabel.Text = _file.FileName;
            try
            {
                filePictureBox.Image = DataBaseHelper.DeserializeImage(_file.FileData);
            }
            catch
            {
                filePictureBox.Image = Properties.Resources.File;
            }
        }

        private void File_Click(object sender, System.EventArgs e)
        {
            if (!_selected)
            {
                ColorBack(ControlPaint.Light(Color.LawnGreen, 0.8f), sender);
            }
            else
            {
                ColorBack(Color.White, sender);
            }
            _selected = !_selected;

            var ctrl = sender as Control;
            while (ctrl.GetType() != typeof(AttachsViewSubForm))
                ctrl = ctrl.Parent;
            (ctrl as AttachsViewSubForm).UpdateDownloadButton();
        }

        private void File_DoubleClick(object sender, System.EventArgs e)
        {
            File_Click(sender, e);
            DataBaseHelper.DeserializeFile(_file);
        }

        private void File_MouseEnter(object sender, System.EventArgs e)
        {
            if (!_selected)
                ColorBack(ControlPaint.Light(Color.PaleGreen, 0.8f), sender);
        }

        private void File_MouseLeave(object sender, System.EventArgs e)
        {
            if (!_selected)
                ColorBack(Color.White, sender);
        }

        private void ColorBack(Color col, object sender)
        {
            Control ctrl = sender as Control;
            while (ctrl.Name != "mainLayoutPanel")
                ctrl = ctrl.Parent;
            ctrl.BackColor = col;
            foreach (Control c in ctrl.Controls)
                c.BackColor = col;
        }
    }
}
