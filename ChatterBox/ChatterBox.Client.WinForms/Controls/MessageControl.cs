using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Message = ChatterBox.Model.Message;

namespace ChatterBox.Client.WinForms.Controls
{
    public partial class MessageControl : UserControl
    {
        public MessageControl()
        {
            InitializeComponent();
        }

        public MessageControl(Message message) : this()
        {
            var b = mainLayoutPanel.Controls["bodyLayoutPanel"];
            b.Controls["userNameLabel"].Text = message.Sender.Name;
            b.Controls["messageTextLabel"].Text = message.Text;
            var d = mainLayoutPanel.Controls["dateLayoutPanel"];
            d.Controls["dateLabel"].Text = message.Date.ToString("HH:mm:ss");
            ((PictureBox)mainLayoutPanel.Controls["avatarBox"]).Image = Properties.Resources.DefaultImage;
        }
    }
}
