using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatterBox.Client.WinForms.Controls;
using ChatterBox.Client.WinForms.Helpers;
using ChatterBox.Client.WinForms.SubForms;
using ChatterBox.Extentions;
using ChatterBox.Model;
using ChatterBox.Model.Additional;

namespace ChatterBox.Client.WinForms.Forms
{
    public partial class MainViewForm : Form
    {
        /// <summary>
        /// Номер первого чата на странице
        /// </summary>
        private int firstChat = 0;
        
        /// <summary>
        /// Уникальный идентификатор текущего пользователя
        /// </summary>
        private Guid _userId;

        public Guid UserId { get { return _userId; } }

        /// <summary>
        /// Уникальный идентификатор текущего чата
        /// </summary>
        private Guid _chatId;

        public Guid ChatId { get { return _chatId; } }

        private Guid _messageId;

        public Guid MessageId {  get { return _messageId; } }

        /// <summary>
        /// Список всех чатов пользователя
        /// </summary>
        private List<ChatControl> _chats;


        private PseudoDropDownHelper _dropdown;

        private PseudoDialogHelper _dialog;

        private AuthForm _auth;

        /// <summary>
        /// Показатель того, нужно ли изменять размеры поля ввода или нет
        /// </summary>
        private bool _resize = false;

        /// <summary>
        /// Максимальное количество чатов умещающихся на экране
        /// </summary>
        private int _maxChatCount { get { return chatsLayoutPanel.Height / new ChatControl().Height; } }

        /// <summary>
        /// Предыдущее количество чатов, отображаемых на экране
        /// </summary>
        private int prev_maxChatCount;
        
        private bool _update = true;

        private bool _additional;

        private bool _selfDestruction;

        private bool _attached;
        private List<string> _attachList;

        private bool _search;

        public bool Search { set { _search = value; } }

        public MainViewForm()
        {
            InitializeComponent();
        }

        public MainViewForm(Guid userId, AuthForm auth) : this()
        {
            // Скрываем панель доп тулов
            messageMainLayoutPanel.RowStyles[3].Height = 0;
            _additional = false;
            _selfDestruction = false;
            _attached = false;
            _attachList = new List<string>();
            _auth = auth;
            _userId = userId;
            _chatId = Guid.Empty;
            _chats = new List<ChatControl>();
            _dropdown = new PseudoDropDownHelper(this);
            _dialog = new PseudoDialogHelper(this);
            try
            {
                var chats = DataBaseHelper.UserChats(_userId);
                foreach (var c in chats)
                {
                    var cont = new ChatControl(c);
                    cont.SetClickHandler(СhatList_Click);
                    _chats.Add(cont);
                }
            }
            catch (Exception ex)
            {
                DataBaseHelper.ExceptionHandler(ex.Message);
            }
            СhatList_CustomDraw();
            ChatInfoClear();

            Thread autoUpdate = new Thread(() =>
            {
                while (_update)
                {
                    Thread.Sleep(1000);
                    try
                    {
                        // Отключаем обновление при поиске
                        if (!_search)
                        {
                            // Invoke как safe-call контрола формы
                            Invoke((Action)delegate
                            {
                                MessagesRefresh(true);
                                MessagesResize();
                                ChatViewRefresh();
                                ChatsRefresh();
                            });
                        }
                    }
                    catch { }
                }
            });
            autoUpdate.Start();
        }

        private void СhatList_MouseEnter(object sender, EventArgs e)
        {
            chatsLayoutPanel.Focus();
        }

        private void СhatList_CustomDraw()
        {
            prev_maxChatCount = _maxChatCount;
            chatsLayoutPanel.Controls.Clear();
            for (int i = 0; i < _maxChatCount && firstChat + i < _chats.Count; i++)
                chatsLayoutPanel.Controls.Add(_chats.ElementAt(firstChat + i));
        }

        private void СhatList_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                if (firstChat - 1 >= 0)
                {
                    firstChat -= 1;
                    СhatList_CustomDraw();
                }
            }
            else
            {
                if (firstChat + 1 <= _chats.Count - _maxChatCount)
                {
                    firstChat += 1;
                    СhatList_CustomDraw();
                }
            }
        }

        private void MessageDelete_Click(object sender, EventArgs e)
        {
            Control cont = (Control)sender;
            while (cont.GetType() != typeof(MessageControl))
                cont = cont.Parent;
            try
            {
                DataBaseHelper.DeleteMessage((cont as MessageControl).MessageId);
                MessagesRefresh(true);
                MessagesResize();
                ChatViewRefresh();
            }
            catch (Exception ex)
            {
                DataBaseHelper.ExceptionHandler(ex.Message);
            }
        }

        private void MessageShowAttachs_Click(object sender, EventArgs e)
        {
            var ctrl = sender as Control;
            while (ctrl.GetType() != typeof(MessageControl))
                ctrl = ctrl.Parent;
            _messageId = (ctrl as MessageControl).MessageId;
            _dialog.Show(PseudoDialogHelper.Pseudo.FileList, PseudoDialogHelper.Parameter.MessageAttachs);
        }

        private void MessageImage_Click(object sender, EventArgs e)
        {
            
        }
        

        private void СhatList_Click(object sender, EventArgs e)
        {
            Control cont = (Control)sender;
            while (cont.GetType() != typeof(ChatControl))
                cont = cont.Parent;
            if (_chatId != Guid.Empty)
            {
                var prevChat = _chats.First(c => c.Id == _chatId);
                prevChat.BackColor = Color.White;
                prevChat.Clicked = false;
            }
            var chat = (ChatControl) cont;
            chat.Clicked = true;
            chat.BackColor = ControlPaint.Light(Color.LawnGreen, 0.8f);
            _chatId = chat.Id;

            try
            {
                ChatInfoFill(DataBaseHelper.UserChats(_userId).First(c => c.Id == _chatId));
            }
            catch (Exception ex)
            {
                DataBaseHelper.ExceptionHandler(ex.Message);
            }

            MessagesRefresh(false);
            MessagesResize();
            ChatViewRefresh();
        }

        private void MessagesRefresh(bool refresh, string key = null)
        {
            if (_chatId == Guid.Empty)
                return;
            var chat = _chats.First(c => c.Id == _chatId);
            int prevCount = chat.Messages.Count();
            if (refresh)
            {
                var prev = new List<Model.Message>();
                prev.AddRange(chat.Messages);
                if (key == null)
                    chat.RefreshMessages();
                else
                    chat.RefreshMessages(key);
                if (prevCount == chat.Messages.Count() && 
                    !chat.Messages.Any(m => prev.All(msg => msg.Id != m.Id)))
                    return;
            }
            var messages = chat.Messages;
            messageShowLayoutPanel.Visible = false;
            messageShowLayoutPanel.Controls.Clear();
            foreach (var m in messages.OrderBy(m => m.Date))
            {
                var mc = new MessageControl(m);
                mc.SetEvent(MessageControl.Option.DeleteClick, MessageDelete_Click);
                mc.SetEvent(MessageControl.Option.ShowButtonClick, MessageShowAttachs_Click);
                mc.SetEvent(MessageControl.Option.ImageClick, MessageImage_Click);
                messageShowLayoutPanel.Controls.Add(mc);
            }
            messageShowLayoutPanel.VerticalScroll.Value = messageShowLayoutPanel.VerticalScroll.Maximum;
            messageShowLayoutPanel.Visible = true;
        }

        private void MessagesResize()
        {
            messageShowLayoutPanel.MaximumSize = new Size(Width - chatsLayoutPanel.Width -
                                                          SystemInformation.VerticalScrollBarWidth, Int32.MaxValue);
            foreach (var c in messageShowLayoutPanel.Controls)
            {
                var newW = messageShowLayoutPanel.Width - messageShowLayoutPanel.Margin.All * 2 -
                           SystemInformation.VerticalScrollBarWidth;
                (c as MessageControl).MinimumSize = new Size(newW, 50);
            }
        }

        public void ChatViewRefresh()
        {
            if (_chatId != Guid.Empty)
            {
                try
                {
                    var c = _chats.First(ch => ch.Id == _chatId);
                    c.UpdateView(DataBaseHelper.GetChat(_chatId));
                }
                catch (Exception ex)
                {
                    DataBaseHelper.ExceptionHandler(ex.Message);
                }
            }
        }
        
        private void Form_Resize(object sender, EventArgs e)
        {
            if (prev_maxChatCount != _maxChatCount)
            {
                СhatList_CustomDraw();
            }
            MessagesResize();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataBaseHelper.SendMessage(new MessageOnCreate()
                {
                    ChatId = _chatId,
                    UserId = _userId,
                    Text = messageTextBox.Text,
                    SelfDestruction = _selfDestruction,
                    DestructionTime = _selfDestruction ? selfDestructionPicker.Text : DateTime.MaxValue.ToString(),
                    Files = _attachList.Select(DataBaseHelper.SerializeFile)
                });
                AdditionalTools_Clear();
                MessagesRefresh(true);
                ChatViewRefresh();
                messageTextBox.Clear();
            }
            catch (Exception ex)
            {
                DataBaseHelper.ExceptionHandler(ex.Message);
            }
        }

        private void MainViewForm_Closing(object sender, FormClosingEventArgs e)
        {
            _update = false;
        }

        private void ChatInfoClear()
        {
            chatNameLabel.Text = String.Empty;
            chatMembersLabel.Text = String.Empty;
            searchBox.Visible = false;
            toolsBox.Visible = false;
        }

        private void ChatInfoFill(Chat chat)
        {
            if (!searchBox.Visible && !toolsBox.Visible)
            {
                searchBox.Visible = true;
                toolsBox.Visible = true;
            }
            chatNameLabel.Text = chat.Title;
            int membersCount = chat.Members.Count();
            string memberCountPostfix;
            switch (membersCount % 10)
            {
                case 1:
                    memberCountPostfix = membersCount % 100 == 11 ? "ов" : "";
                    break;
                case 2:
                case 3:
                case 4:
                    memberCountPostfix = 
                        membersCount % 100 > 10 && membersCount % 100 < 15 ? "ов" : "а";
                    break;
                default:
                    memberCountPostfix = "ов";
                    break;
            }
            
            chatMembersLabel.Text = $"{membersCount} участник{memberCountPostfix}";
        }

        private void ChatInfo_MouseEnter(object sender, EventArgs e)
        {
            if (_chatId == Guid.Empty)
                return;
            Control ctrl = sender as Control;
            while (new [] 
            {"chatNameLayoutPanel", "searchPanel", "toolsPanel"}.All(x => x != ctrl.Name))
                ctrl = ctrl.Parent;
            ctrl.BackColor = Color.LawnGreen;
            foreach (Control c in ctrl.Controls)
                c.BackColor = Color.LawnGreen;
        }

        private void ChatInfo_MouseLeave(object sender, EventArgs e)
        {
            if (_chatId == Guid.Empty)
                return;
            Control ctrl = sender as Control;
            while (new[]
                {"chatNameLayoutPanel", "searchPanel", "toolsPanel"}.All(x => x != ctrl.Name))
                ctrl = ctrl.Parent;
            ctrl.BackColor = Color.PaleGreen;
            foreach (Control c in ctrl.Controls)
                c.BackColor = Color.PaleGreen;
        }

        private void CommonSettings_MouseEnter(object sender, EventArgs e)
        {
            Control ctrl = sender as Control;
            while (ctrl.Name != "commonLayoutPanel")
                ctrl = ctrl.Parent;
            ctrl.BackColor = Color.LawnGreen;
            foreach (Control c in ctrl.Controls)
                c.BackColor = Color.LawnGreen;
        }

        private void CommonSettings_MouseLeave(object sender, EventArgs e)
        {
            Control ctrl = sender as Control;
            while (ctrl.Name != "commonLayoutPanel")
                ctrl = ctrl.Parent;
            ctrl.BackColor = Color.PaleGreen;
            foreach (Control c in ctrl.Controls)
                c.BackColor = Color.PaleGreen;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (_chatId != Guid.Empty)
                _dropdown.Show(PseudoDropDownHelper.Pseudo.Search);
        }

        public void SearchMessages(string keyWord)
        {
            if (_chatId != Guid.Empty)
            {
                _search = true;
                MessagesRefresh(true, keyWord);
                MessagesResize();
            }
        }

        private void ChatSettings_Click(object sender, EventArgs e)
        {
            if (_chatId != Guid.Empty)
                _dropdown.Show(PseudoDropDownHelper.Pseudo.ChatSettings);
        }

        public void PseudoDialog(PseudoDialogHelper.Pseudo type, 
            PseudoDialogHelper.Parameter par = PseudoDialogHelper.Parameter.Null)
        {
            try
            {
                _dialog.Show(type, par);
            }
            catch (Exception ex)
            {
                DataBaseHelper.ExceptionHandler(ex.Message);
            }
        }

        public void ChatsRefresh()
        {
            if (_userId != Guid.Empty)
            if (DataBaseHelper.UserChats(_userId).Count() != _chats.Count)
                Chat_Update();
        }

        /// <summary>
        /// Обновление чата на форме
        /// </summary>
        public void Chat_Update()
        {
            _chats.Clear();
            try
            {
                var chats = DataBaseHelper.UserChats(_userId);
                foreach (var c in chats)
                {
                    var cont = new ChatControl(c);
                    cont.SetClickHandler(СhatList_Click);
                    _chats.Add(cont);
                }
                СhatList_CustomDraw();
                if (_chatId != Guid.Empty)
                    ChatInfoFill(DataBaseHelper.GetChat(_chatId));
                else
                    ChatInfoClear();
            }
            catch (Exception ex)
            {
                DataBaseHelper.ExceptionHandler(ex.Message);
            }
        }

        private void ChatInfo_Click(object sender, EventArgs e)
        {
            if (_chatId != Guid.Empty)
                _dialog.Show(PseudoDialogHelper.Pseudo.ChatInfo);
        }
        
        private void ResizePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (_resize)
            {
                int minRowHeight = 50;
                var row = messageMainLayoutPanel.RowStyles[2];
                if (e.Y > 0) // Down
                {
                    if (row.Height - e.Y >= minRowHeight)
                        row.Height -= e.Y;
                    else
                        row.Height = minRowHeight;
                }
                else if (e.Y < 0) // Up
                {
                    row.Height -= e.Y;
                }
            }
        }

        private void ResizePanel_MouseDown(object sender, MouseEventArgs e)
        {
            _resize = true;
        }

        private void ResizePanel_MoiseUp(object sender, MouseEventArgs e)
        {
            _resize = false;
        }

        public void LeaveChat()
        {
            try
            {
                DataBaseHelper.DeleteChatMembers(_chatId, new [] {_userId});
                _chatId = Guid.Empty;
                Chat_Update();
            }
            catch (Exception ex)
            {
                DataBaseHelper.ExceptionHandler(ex.Message);
            }
        }

        public void DeleteChat()
        {
            try
            {
                DataBaseHelper.DeleteChat(_chatId);
                _chatId = Guid.Empty;
                Chat_Update();
            }
            catch (Exception ex)
            {
                DataBaseHelper.ExceptionHandler(ex.Message);
            }
        }

        private void CommonSettings_Click(object sender, EventArgs e)
        {
            _dropdown.Show(PseudoDropDownHelper.Pseudo.CommonSettings);
        }

        public void LogOut()
        {
            Hide();
            _chatId = Guid.Empty;
            _userId = Guid.Empty;
            _auth.Show();
        }

        private void AdditionToolsButton_Click(object sender, EventArgs e)
        {
            if (!_additional)
            {
                messageMainLayoutPanel.RowStyles[3].Height = 26;
                additionalToolsButton.Image = Properties.Resources.HideActive;
                messageSendLayoutPanel.Margin = new Padding(3, 3, 3, 0);
            }
            else
            {
                messageMainLayoutPanel.RowStyles[3].Height = 0;
                additionalToolsButton.Image = Properties.Resources.UnhideActive;
                messageSendLayoutPanel.Margin = new Padding(3, 3, 3, 3);
            }
            _additional = !_additional;
        }

        private void SelfDestructionButton_Click(object sender, EventArgs e)
        {
            if (!_selfDestruction)
            {
                selfDestructionButton.BackColor = ControlPaint.Light(Color.LawnGreen, 0.8f);
                selfDestructionPicker.Value = DateTime.Now.AddMinutes(5);
            }
            else
                selfDestructionButton.BackColor = Color.White;
            _selfDestruction = !_selfDestruction;
            selfDestructionPicker.Visible = _selfDestruction;
        }

        private void AttachButton_Click(object sender, EventArgs e)
        {
            if (!_attached)
            {
                if (openAttachDialog.ShowDialog() == DialogResult.OK)
                {
                    _attachList.AddRange(openAttachDialog.FileNames);
                    attachButton.BackColor = ControlPaint.Light(Color.LawnGreen, 0.8f);
                }
            }
            else
            {
                _attachList.Clear();
                attachButton.BackColor = Color.White;
            }
            _attached = !_attached;
        }

        private void AdditionalTools_Clear()
        {
            attachButton.BackColor = Color.White;
            _attached = false;
            _attachList.Clear();

            selfDestructionButton.BackColor = Color.White;
            _selfDestruction = false;
            selfDestructionPicker.Visible = false;
        }

        private void MessageTextBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == (Keys.Control | Keys.Enter))
            {
                SendButton_Click(sender, new EventArgs());
            }
        }

        private void MessageTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.Enter))
            {
                //Чистим оставшийся Enter
                messageTextBox.Text = String.Empty;
            }
        }
    }
}