using System;
using System.Drawing;
using System.Windows.Forms;
using ChatterBox.Client.WinForms.Forms;

namespace ChatterBox.Client.WinForms.SubForms
{
    public partial class SearchSubForm : Form
    {
        public string SearchText { get { return searchBox.Text.Trim(' ').ToLower(); } }

        public SearchSubForm()
        {
            InitializeComponent();
        }

        public void SetTextChangedEvent(EventHandler ev)
        {
            searchBox.TextChanged += ev;
        }

        public void Clear()
        {
            searchBox.Text = String.Empty;
        }
    }
}
