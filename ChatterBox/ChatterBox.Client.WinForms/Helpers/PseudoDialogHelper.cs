using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatterBox.Client.WinForms.Controls;
using ChatterBox.Client.WinForms.Forms;
using ChatterBox.Client.WinForms.SubForms;
using ChatterBox.Extentions;
using ChatterBox.Model;
using ChatterBox.Model.Additional;

namespace ChatterBox.Client.WinForms.Helpers
{
    public class PseudoDialogHelper
    {
        private readonly MainViewForm _main;
        private readonly Form _parent;
        private Form _current;
        private Panel _backGround;
        
        /// <summary>
        /// Перечисление типов диалогового окна
        /// </summary>
        public enum Pseudo
        {
            Input,
            DoubleInput,
            FileLoad,
            ChatInfo,
            UserSettings,
            YesNo,
            UserList,
            FileList
        }

        /// <summary>
        /// Перечисление дополнительного параметра отображения для диалогового окна
        /// </summary>
        public enum Parameter
        {
            Null,
            ChatTitle,
            ChatPicture,
            UserName,
            UserLogin,
            UserPassword,
            UserPicture,
            LeaveChat,
            DeleteChat,
            UserContacts,
            NewChat,
            ChatMembers,
            UsersAdd,
            MessageAttachs,
            ChatAttachs
        }

        public PseudoDialogHelper(Form main, Form parent = null)
        {
            _main = main as MainViewForm;
            _parent = parent;
        }

        public void Show(Pseudo num, Parameter par = Parameter.Null)
        {
            DarkerBackGround();
            string text = String.Empty, value = String.Empty, item1 = String.Empty, item2 = String.Empty;
            switch (par)
            {
                case Parameter.ChatTitle:
                    text = "название чата";
                    value = DataBaseHelper.GetChat(_main.ChatId).Title;
                    break;
                case Parameter.ChatPicture:
                    text = "аватар чата";
                    break;
                case Parameter.UserName:
                    text = "имя пользователя";
                    value = DataBaseHelper.GetUser(_main.UserId).Name;
                    break;
                case Parameter.UserLogin:
                    text = "логин пользователя";
                    item1 = "Введите логин:";
                    item2 = "Введите пароль:";
                    break;
                case Parameter.UserPassword:
                    text = "пароль пользователя";
                    item1 = "Введите текущий пароль:";
                    item2 = "Введите новый пароль:";
                    break;
                case Parameter.UserPicture:
                    text = "новый аватар пользователя";
                    break;
                case Parameter.LeaveChat:
                    text = "покинуть данный чат";
                    break;
                case Parameter.DeleteChat:
                    text = "удалить данный чат";
                    break;
                case Parameter.UsersAdd:
                    text = "Добавить пользователей";
                    value = "Добавить";
                    break;
                case Parameter.UserContacts:
                    text = "Контакты";
                    value = "Добавить новый контакт";
                    break;
                case Parameter.ChatMembers:
                case Parameter.NewChat:
                    text = "Пользователи чата";
                    value = "Добавить пользователей";
                    break;
                case Parameter.MessageAttachs:
                    text = "Вложения";
                    //value = "Загрузить все файлы";
                    break;
                case Parameter.ChatAttachs:
                    text = "Материалы чата";
                    //value = "Загрузить все файлы";
                    break;
            }
            switch (num)
            {
                case Pseudo.Input:
                    var inputDialog = new SimpleInputSubForm(text, value);
                    if (inputDialog.ShowDialog(_main) == DialogResult.OK)
                    {
                        switch (par)
                        {
                            case Parameter.ChatTitle:
                                DataBaseHelper.ChangeTitle(_main.ChatId, inputDialog.Result);
                                _main.Chat_Update();
                                break;
                            case Parameter.UserName:
                                DataBaseHelper.ChangeName(_main.UserId, inputDialog.Result);
                                break;
                        }
                    }
                    break;
                case Pseudo.DoubleInput:
                    var doubleInputDialog = new SimpleDoubleInputSubForm(text, item1, item2, par == Parameter.UserPassword);
                    if (doubleInputDialog.ShowDialog(_main) == DialogResult.OK)
                    {
                        try
                        {
                            switch (par)
                            {
                                case Parameter.UserLogin:
                                    DataBaseHelper.ChangeLogin(_main.UserId, doubleInputDialog.Item1,
                                        doubleInputDialog.Item2);
                                    break;
                                case Parameter.UserPassword:
                                    DataBaseHelper.ChangePassword(_main.UserId, doubleInputDialog.Item1,
                                        doubleInputDialog.Item2);
                                    break;
                            }
                        }
                        catch (Exception ex)
                        {
                            DataBaseHelper.ExceptionHandler(ex.Message);
                        }
                    }
                    break;
                case Pseudo.FileLoad:
                    var fileLoadDialog = new SimpleFileLoadSubForm(text);
                    if (fileLoadDialog.ShowDialog(_main) == DialogResult.OK)
                    {
                        switch (par)
                        {
                            case Parameter.UserPicture:
                                DataBaseHelper.ChangeUserPicture(_main.UserId, Image.FromFile(fileLoadDialog.Result));
                                break;
                            case Parameter.ChatPicture:
                                DataBaseHelper.ChangeChatPicture(_main.ChatId, Image.FromFile(fileLoadDialog.Result));
                                _main.Chat_Update();
                                break;
                        }
                    }
                    break;
                case Pseudo.ChatInfo:
                    var chatInfoDialog = new ChatInfoSubForm(DataBaseHelper.GetChat(_main.ChatId));
                    chatInfoDialog.SetEvent(ChatInfoSubForm.Option.ChatMembersClick, ChatMembers_Click);
                    chatInfoDialog.SetEvent(ChatInfoSubForm.Option.LeaveChatClick, LeaveChat_Click);
                    chatInfoDialog.SetEvent(ChatInfoSubForm.Option.DeleteChatClick, DeleteChat_Click);
                    chatInfoDialog.ShowDialog(_main);
                    break;
                case Pseudo.YesNo:
                    var yesNoDialog = new SimpleYesNoSubForm(text);
                    if (yesNoDialog.ShowDialog() == DialogResult.Yes)
                    {
                        switch (par)
                        {
                            case Parameter.LeaveChat:
                                _main.LeaveChat();
                                break;
                            case Parameter.DeleteChat:
                                _main.DeleteChat();
                                break;
                        }

                    }
                    break;
                case Pseudo.UserSettings:
                    var userSettingsDialog = new UserSettingsSubForm(_main.UserId);
                    userSettingsDialog.SetEvent(UserSettingsSubForm.Option.ChangeUserNameClick, ChangeUserName_Click);
                    userSettingsDialog.SetEvent(UserSettingsSubForm.Option.ChangeLoginClick, ChangeLogin_Click);
                    userSettingsDialog.SetEvent(UserSettingsSubForm.Option.ChangePasswordClick, ChangePassword_Click);
                    userSettingsDialog.SetEvent(UserSettingsSubForm.Option.ChangePictureClick, ChangePicture_Click);
                    userSettingsDialog.SetEvent(UserSettingsSubForm.Option.LogOutClick, LogOut_Click);

                    _current = userSettingsDialog;
                    userSettingsDialog.ShowDialog(_main);
                    break;
                case Pseudo.UserList:
                    IEnumerable<User> userList = new List<User>();
                    UserInfoControl.ButtonType bType = UserInfoControl.ButtonType.Empty;
                    var userListDialog = new UserListSubForm();
                    switch (par)
                    {
                        case Parameter.UserContacts:
                            userList = DataBaseHelper.GetUserContacts(_main.UserId);
                            bType = UserInfoControl.ButtonType.Delete;
                            userListDialog.SetEvent(UserListSubForm.Option.UserActionButtonClick, DeleteUserContact_Click);
                            userListDialog.AllowMultipleSelect = false;
                            break;
                        case Parameter.UsersAdd:
                            var contacts = DataBaseHelper.GetUserContacts(_main.UserId);
                            var members = DataBaseHelper.GetChatMembers(_main.ChatId);
                            userList = contacts.Where(c => members.All(m => m.Id != c.Id));
                            bType = UserInfoControl.ButtonType.Empty;
                            userListDialog.AllowMultipleSelect = true;
                            userListDialog.SetEvent(UserListSubForm.Option.ActionButtonClick, AddChatMembers_Click);
                            break;
                        case Parameter.NewChat:
                            userList = DataBaseHelper.GetUserContacts(_main.UserId);
                            bType = UserInfoControl.ButtonType.Empty;
                            userListDialog.AllowMultipleSelect = true;
                            userListDialog.SetEvent(UserListSubForm.Option.ActionButtonClick, AddNewChat_click);
                            break;
                        case Parameter.ChatMembers:
                            userList = DataBaseHelper.GetChatMembers(_main.ChatId);
                            bType = UserInfoControl.ButtonType.Delete;
                            userListDialog.SetEvent(UserListSubForm.Option.ActionButtonClick, SelectAddChatMembers_Click);
                            userListDialog.SetEvent(UserListSubForm.Option.UserActionButtonClick, DeleteChatMember_Click);
                            break;
                    }
                    userListDialog.Size = new Size(userListDialog.Size.Width, _main.ClientRectangle.Height - 30);
                    userListDialog.Fill(_main.UserId, userList, text, value, bType);
                    userListDialog.ShowDialog(_main);
                    break;
                case Pseudo.FileList:
                    IEnumerable<File> fileList = new List<File>();
                    switch (par)
                    {
                        case Parameter.MessageAttachs:
                            fileList = DataBaseHelper.GetMessage(_main.MessageId).Attachs.ToFileList();
                            break;
                        case Parameter.ChatAttachs:
                            fileList = DataBaseHelper.GetChatAttachs(_main.ChatId).ToFileList();
                            break;
                    }
                    var attachViewDialog = new AttachsViewSubForm(text, fileList);
                    attachViewDialog.ShowDialog(_main);

                    break;
            }
            LighterBackGround();
        }

        private void DarkerBackGround()
        {
            Bitmap bmp = new Bitmap(_main.ClientRectangle.Width, _main.ClientRectangle.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
                g.CopyFromScreen(_main.PointToScreen(new Point(0, 0)), new Point(0, 0), _main.ClientRectangle.Size);
                double percent = 0.60;
                Color darken = Color.FromArgb((int)(255 * percent), Color.Black);
                using (Brush brsh = new SolidBrush(darken))
                {
                    g.FillRectangle(brsh, _main.ClientRectangle);
                }
            }

            _backGround = new Panel
            {
                Location = new Point(0, 0),
                Size = _main.ClientRectangle.Size,
                BackgroundImage = bmp
            };
            _main.Controls.Add(_backGround);
            _backGround.BringToFront();
        }

        private void LighterBackGround()
        {
            _backGround?.Dispose();
            _backGround = null;
        }

        private void ChatMembers_Click(object sender, EventArgs e)
        {
            new PseudoDialogHelper(_main).Show(Pseudo.UserList, Parameter.ChatMembers);
            ChatInfoSubForm_Close(sender);
        }

        private void LeaveChat_Click(object sender, EventArgs e)
        {
            new PseudoDialogHelper(_main).Show(Pseudo.YesNo, Parameter.LeaveChat);
            ChatInfoSubForm_Close(sender);
        }

        private void DeleteChat_Click(object sender, EventArgs e)
        {
            new PseudoDialogHelper(_main).Show(Pseudo.YesNo, Parameter.DeleteChat);
            ChatInfoSubForm_Close(sender);
        }

        private void ChatInfoSubForm_Close(object sender)
        {
            Control ctrl = (Control)sender;
            while (ctrl.GetType() != typeof(ChatInfoSubForm))
                ctrl = ctrl.Parent;
            (ctrl as ChatInfoSubForm)?.Close();
        }

        private void ChangeUserName_Click(object sender, EventArgs e)
        {
            new PseudoDialogHelper(_main).Show(Pseudo.Input, Parameter.UserName);
            (_current as UserSettingsSubForm)?.UpdateInfo();
        }

        private void ChangeLogin_Click(object sender, EventArgs e)
        {
            new PseudoDialogHelper(_main).Show(Pseudo.DoubleInput, Parameter.UserLogin);
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            new PseudoDialogHelper(_main).Show(Pseudo.DoubleInput, Parameter.UserPassword);
        }

        private void ChangePicture_Click(object sender, EventArgs e)
        {
            new PseudoDialogHelper(_main).Show(Pseudo.FileLoad, Parameter.UserPicture);
            (_current as UserSettingsSubForm)?.UpdateInfo();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            (_current as UserSettingsSubForm)?.Close();
            _main.LogOut();
        }

        private void SelectAddChatMembers_Click(object sender, EventArgs e)
        {
            new PseudoDialogHelper(_main).Show(Pseudo.UserList, Parameter.UsersAdd);
        }
        private void AddChatMembers_Click(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            while (ctrl.GetType() != typeof(UserListSubForm))
                ctrl = ctrl.Parent;
            try
            {
                DataBaseHelper.AddMembersToChat(_main.ChatId, (ctrl as UserListSubForm).Users);
                _main.Chat_Update();
                (ctrl as UserListSubForm).Close();
            }
            catch (Exception ex)
            {
                DataBaseHelper.ExceptionHandler(ex.Message);
            }
        }

        private void AddNewChat_click(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            while (ctrl.GetType() != typeof(UserListSubForm))
                ctrl = ctrl.Parent;

            DataBaseHelper.CreateChat(_main.UserId, (ctrl as UserListSubForm).Users);
            (ctrl as UserListSubForm).Close();
        }

        private void DeleteChatMember_Click(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            while (ctrl.GetType() != typeof(UserInfoControl))
                ctrl = ctrl.Parent;
            var id = (ctrl as UserInfoControl).UserId;
            try
            {
                DataBaseHelper.DeleteChatMembers(_main.ChatId, new Guid[] { id });

                while (ctrl.GetType() != typeof(UserListSubForm))
                    ctrl = ctrl.Parent;
                (ctrl as UserListSubForm).DeleteUserFromView(id);
                _main.Chat_Update();
            }
            catch (Exception ex)
            {
                DataBaseHelper.ExceptionHandler(ex.Message);
            }
        }

        private void DeleteUserContact_Click(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            while (ctrl.GetType() != typeof(UserInfoControl))
                ctrl = ctrl.Parent;
            var id = (ctrl as UserInfoControl).UserId;
            try
            {
                DataBaseHelper.DeleteUserContact(_main.UserId, id);

                while (ctrl.GetType() != typeof(UserListSubForm))
                    ctrl = ctrl.Parent;
                (ctrl as UserListSubForm).DeleteUserFromView(id);
                _main.Chat_Update();
            }
            catch (Exception ex)
            {
                DataBaseHelper.ExceptionHandler(ex.Message);
            }
        }

    }
}
