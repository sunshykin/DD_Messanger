using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatterBox.Client.WinForms.Forms;
using ChatterBox.Client.WinForms.SubForms;

namespace ChatterBox.Client.WinForms.Helpers
{
    public class PseudoDropDownHelper
    {
        private readonly MainViewForm _main;
        private readonly ChatSettingsSubForm _chatSettings;
        private readonly SearchSubForm _search;
        private readonly CommonSettingsSubForm _commonSettings;
        private Form _current;

        public enum Pseudo
        {
            ChatSettings,
            Search,
            CommonSettings
        }

        public enum Parameter
        {
            ChatTitle,
            ChatPicture
            
        }

        public PseudoDropDownHelper(Form parent)
        {
            _main = parent as MainViewForm;
            _chatSettings = new ChatSettingsSubForm();
            _chatSettings.SetEvent(ChatSettingsSubForm.Option.ChangeTitleClick, ChatSettings_ChangeTitleClicked);
            _chatSettings.SetEvent(ChatSettingsSubForm.Option.ChangePictureClick, ChatSettings_ChangeChatPictureClicked);
            _chatSettings.SetEvent(ChatSettingsSubForm.Option.ShowAttachsClick, ChatSettings_ShowChatAttachsClicked);
            _chatSettings.Deactivate += Pseudo_Deactivate;
            _search = new SearchSubForm();
            _search.SetTextChangedEvent(Search_TextChanged);
            _search.Deactivate += Pseudo_Deactivate;
            _commonSettings = new CommonSettingsSubForm();
            _commonSettings.SetEvent(CommonSettingsSubForm.Option.UserSettingsClick, CommonSettings_UserSettingsClicked);
            _commonSettings.SetEvent(CommonSettingsSubForm.Option.UserContactsClick, CommonSettings_UserContactsClicked);
            _commonSettings.SetEvent(CommonSettingsSubForm.Option.NewChatClick, CommonSettings_NewChatClicked);
            _commonSettings.Deactivate += Pseudo_Deactivate;
        }

        public void Show(Pseudo num)
        {
            Control layout = _main.Controls["mainLayoutPanel"];
            int pointX = 0;
            switch (num)
            {
                case Pseudo.ChatSettings:
                    _current = _chatSettings;
                    layout = layout.Controls["chatInfoLayoutPanel"];
                    pointX = _main.Location.X + _main.Width - _current.Width - 8;
                    break;
                case Pseudo.Search:
                    _current = _search;
                    layout = layout.Controls["chatInfoLayoutPanel"];
                    pointX = _main.Location.X + _main.Width - _current.Width - 8;
                    break;
                case Pseudo.CommonSettings:
                    _current = _commonSettings;
                    layout = layout.Controls["commonLayoutPanel"];
                    pointX = _main.Location.X + 8;
                    break;
            }
            int pointY = _main.Location.Y + layout.Height + 30;
            _current.Show();
            _current.Location = new Point(pointX, pointY);
            _current.Focus();
        }

        private void Pseudo_Deactivate(Object sender, EventArgs e)
        {
            if (_current == null)
                return;
            if (_current.GetType() == typeof(SearchSubForm))
            {
                (_current as SearchSubForm)?.Clear();
                _main.Search = false;
            }
            _current.Hide();
            _current = null;
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            var text = _search.SearchText;
            if (text.Length > 1)
                _main.SearchMessages(text);
            else
                _main.SearchMessages(null);
        }

        private void ChatSettings_ChangeTitleClicked(object sender, EventArgs e)
        {
            _main.PseudoDialog(PseudoDialogHelper.Pseudo.Input, PseudoDialogHelper.Parameter.ChatTitle);
            _main.ChatViewRefresh();
        }

        private void ChatSettings_ChangeChatPictureClicked(object sender, EventArgs e)
        {
            _main.PseudoDialog(PseudoDialogHelper.Pseudo.FileLoad, PseudoDialogHelper.Parameter.ChatPicture);
            _main.ChatViewRefresh();
        }

        private void ChatSettings_ShowChatAttachsClicked(object sender, EventArgs e)
        {
            _main.PseudoDialog(PseudoDialogHelper.Pseudo.FileList, PseudoDialogHelper.Parameter.ChatAttachs);
        }

        private void CommonSettings_UserSettingsClicked(object sender, EventArgs e)
        {
            _main.PseudoDialog(PseudoDialogHelper.Pseudo.UserSettings);
        }

        private void CommonSettings_UserContactsClicked(object sender, EventArgs e)
        {
            _main.PseudoDialog(PseudoDialogHelper.Pseudo.UserList, PseudoDialogHelper.Parameter.UserContacts);
        }

        private void CommonSettings_NewChatClicked(object sender, EventArgs e)
        {
            _main.PseudoDialog(PseudoDialogHelper.Pseudo.UserList, PseudoDialogHelper.Parameter.NewChat);
        }
    }
}
