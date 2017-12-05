using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatterBox.Client.WinForms.Helpers;
using ChatterBox.Client.WinForms.SubForms;
using ChatterBox.Model;

namespace ChatterBox.Client.WinForms.Controls
{
    public partial class UserInfoControl : UserControl
    {
        private readonly User _user;
        private Image _inactive;
        private Image _active;
        private ButtonType _type;

        private bool _selected;
        
        public Guid UserId
        {
            get
            {
                if (_user != null)
                    return _user.Id;
                else
                    return Guid.Empty;
            }
        }

        public enum ButtonType
        {
            Empty,
            Delete,
            Add
        }

        public enum Option
        {
            ActionButtonClick
        }

        public UserInfoControl()
        {
            InitializeComponent();
        }

        public UserInfoControl(Guid id) : this()
        {
            SetType(ButtonType.Empty);
            _selected = false;
            _user = DataBaseHelper.GetUser(id);
            userNameLabel.Text = _user.Name;
            actionButton.Image = _inactive;
            userPictureBox.Image = DataBaseHelper.DeserializeImage(_user.Picture);
        }

        private void UserInfoButton_MouseEnter(object sender, EventArgs e)
        {
            actionButton.Image = _active;
            UserInfo_MouseEnter(sender, EventArgs.Empty);
        }

        private void UserInfoButton_MouseLeave(object sender, EventArgs e)
        {
            actionButton.Image = _inactive;
            UserInfo_MouseLeave(sender, e);
        }

        public void SetType(ButtonType type)
        {
            _type = type;
            switch (type)
            {
                case ButtonType.Empty:
                    _inactive = null;
                    _active = null;
                    break;
                case ButtonType.Add:
                    _inactive = Properties.Resources.AddInactive;
                    _active = Properties.Resources.AddActive;
                    break;
                case ButtonType.Delete:
                    _inactive = Properties.Resources.DeleteInactive;
                    _active = Properties.Resources.DeleteActive;
                    break;
            }
            actionButton.Image = _inactive;
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

        private void UserInfo_MouseEnter(object sender, EventArgs e)
        {
            if (!_selected)
                ColorBack(ControlPaint.Light(Color.PaleGreen, 0.8f), sender);
            }

        private void UserInfo_MouseLeave(object sender, EventArgs e)
        {
            if (!_selected)
                ColorBack(Color.White, sender);
        }

        private void UserInfo_Click(object sender, EventArgs e)
        {
            var ctrl = sender as Control;
            while (ctrl.GetType() != typeof(UserListSubForm))
                ctrl = ctrl.Parent;
            var list = ctrl as UserListSubForm;
            if (!_selected)
            {
                _selected = true;
                list.AddSelected(UserId);
                ColorBack(ControlPaint.Light(Color.LawnGreen, 0.8f), sender);
            }
            else
            {
                _selected = false;
                list.RemoveSelected(UserId);
                ColorBack(ControlPaint.Light(Color.PaleGreen, 0.8f), sender);
            }
        }

        public void UnSelect(bool isActive)
        {
            _selected = false;
            if (isActive)
                ColorBack(ControlPaint.Light(Color.PaleGreen, 0.8f), mainLayoutPanel);
            else
                ColorBack(Color.White, mainLayoutPanel);
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            if (_type == ButtonType.Empty)
                UserInfo_Click(sender, e);
        }

        public void SetEvent(Option option, EventHandler ev)
        {
            switch (option)
            {
                case Option.ActionButtonClick:
                    actionButton.Click += ev;
                    break;
            }
        }
    }
}
