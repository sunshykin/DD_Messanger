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
using ChatterBox.Model;

namespace ChatterBox.Client.WinForms.SubForms
{
    public partial class UserListSubForm : Form
    {
        private IEnumerable<User> _users;
        private bool _allowMultipleSelect;

        public bool AllowMultipleSelect {  set { _allowMultipleSelect = value; } }

        private Guid _selectedOne;
        private List<Guid> _selectedList;
        private EventHandler _userActionEvent;

        public List<Guid> Users
        {
            get
            {
                if (_allowMultipleSelect)
                    return _selectedList;
                else
                    return new List<Guid>() { _selectedOne };
            }
        }

        public enum Option
        {
            ActionButtonClick,
            UserActionButtonClick
        }

        public UserListSubForm()
        {
            InitializeComponent();
            _selectedList = new List<Guid>();
            _allowMultipleSelect = false;
            _userActionEvent = null;
        }

        public void Fill(Guid caller, IEnumerable<User> users, string title, string action,
            UserInfoControl.ButtonType type = UserInfoControl.ButtonType.Empty)
        {
            _users = users;
            titleLabel.Text = title;
            actionLabel.Text = action;
            userCardsLayoutPanel.Controls.Clear();
            foreach (var u in users)
            {
                var ui = new UserInfoControl(u.Id);
                ui.SetType(u.Id == caller ? UserInfoControl.ButtonType.Empty : type);
                if (_userActionEvent != null)
                    ui.SetEvent(UserInfoControl.Option.ActionButtonClick, _userActionEvent);
                userCardsLayoutPanel.Controls.Add(ui);
            }
            if (!userCardsLayoutPanel.VerticalScroll.Visible)
                Size = new Size()
                {
                    Height = Height,
                    Width = Width - 17
                };
        }

        private void ActionLabel_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            Control ctrl = sender as Control;
            ctrl.BackColor = ControlPaint.Light(Color.PaleGreen, 0.8f);
        }

        private void ActionLabel_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            Control ctrl = sender as Control;
            ctrl.BackColor = Color.White;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SetEvent(Option option, EventHandler ev)
        {
            switch (option)
            {
                case Option.ActionButtonClick:
                    actionLabel.Click += ev;
                    break;
                case Option.UserActionButtonClick:
                    _userActionEvent = ev;
                    break;
            }
        }

        public void AddSelected(Guid id)
        {
            if (!_allowMultipleSelect)
            {
                UnSelect(_selectedOne, false);
                _selectedOne = id;
            }
            else
            {
                _selectedList.Add(id);
            }
        }

        public void RemoveSelected(Guid id)
        {
            if (!_allowMultipleSelect)
            {
                _selectedOne = Guid.Empty;
                UnSelect(id, true);
            }
            else
            {
                _selectedList.Remove(id);
                UnSelect(id, false);
            }
        }

        private void UnSelect(Guid id, bool isActive)
        {
            foreach (UserInfoControl c in userCardsLayoutPanel.Controls)
                if (c.UserId == id)
                {
                    c.UnSelect(isActive);
                    break;
                }
        }

        public void DeleteUserFromView(Guid userId)
        {
            userCardsLayoutPanel.Controls.Remove(userCardsLayoutPanel.Controls.OfType<UserInfoControl>().First(u => u.UserId == userId));
            userCardsLayoutPanel.Update();
        }
    }
}
