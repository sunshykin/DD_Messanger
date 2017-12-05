namespace ChatterBox.Client.WinForms.Forms
{
    partial class MainViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainViewForm));
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.chatsLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.messageMainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.messageSendLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.messageTextBox = new System.Windows.Forms.RichTextBox();
            this.sendButton = new System.Windows.Forms.PictureBox();
            this.additionalToolsButton = new System.Windows.Forms.PictureBox();
            this.messageShowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.resizePanel = new System.Windows.Forms.Panel();
            this.messageSendAdditionalLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.attachButton = new System.Windows.Forms.PictureBox();
            this.selfDestructionButton = new System.Windows.Forms.Label();
            this.selfDestructionPicker = new System.Windows.Forms.DateTimePicker();
            this.chatInfoLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchBox = new System.Windows.Forms.PictureBox();
            this.toolsPanel = new System.Windows.Forms.Panel();
            this.toolsBox = new System.Windows.Forms.PictureBox();
            this.chatNameLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.chatNameLabel = new System.Windows.Forms.Label();
            this.chatMembersLabel = new System.Windows.Forms.Label();
            this.commonLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.commonSettingsIcon = new System.Windows.Forms.Label();
            this.comonTitleLabel = new System.Windows.Forms.Label();
            this.openAttachDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainLayoutPanel.SuspendLayout();
            this.messageMainLayoutPanel.SuspendLayout();
            this.messageSendLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sendButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalToolsButton)).BeginInit();
            this.messageSendAdditionalLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attachButton)).BeginInit();
            this.chatInfoLayoutPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBox)).BeginInit();
            this.toolsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolsBox)).BeginInit();
            this.chatNameLayoutPanel.SuspendLayout();
            this.commonLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.ColumnCount = 2;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.Controls.Add(this.chatsLayoutPanel, 0, 1);
            this.mainLayoutPanel.Controls.Add(this.messageMainLayoutPanel, 1, 1);
            this.mainLayoutPanel.Controls.Add(this.chatInfoLayoutPanel, 1, 0);
            this.mainLayoutPanel.Controls.Add(this.commonLayoutPanel, 0, 0);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 2;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(665, 371);
            this.mainLayoutPanel.TabIndex = 0;
            // 
            // chatsLayoutPanel
            // 
            this.chatsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatsLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.chatsLayoutPanel.Location = new System.Drawing.Point(3, 43);
            this.chatsLayoutPanel.Name = "chatsLayoutPanel";
            this.chatsLayoutPanel.Size = new System.Drawing.Size(204, 325);
            this.chatsLayoutPanel.TabIndex = 0;
            this.chatsLayoutPanel.WrapContents = false;
            this.chatsLayoutPanel.MouseEnter += new System.EventHandler(this.СhatList_MouseEnter);
            this.chatsLayoutPanel.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.СhatList_MouseWheel);
            // 
            // messageMainLayoutPanel
            // 
            this.messageMainLayoutPanel.ColumnCount = 1;
            this.messageMainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.messageMainLayoutPanel.Controls.Add(this.messageSendLayoutPanel, 0, 2);
            this.messageMainLayoutPanel.Controls.Add(this.messageShowLayoutPanel, 0, 0);
            this.messageMainLayoutPanel.Controls.Add(this.resizePanel, 0, 1);
            this.messageMainLayoutPanel.Controls.Add(this.messageSendAdditionalLayoutPanel, 0, 3);
            this.messageMainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageMainLayoutPanel.Location = new System.Drawing.Point(213, 43);
            this.messageMainLayoutPanel.Name = "messageMainLayoutPanel";
            this.messageMainLayoutPanel.RowCount = 4;
            this.messageMainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.messageMainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.messageMainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.messageMainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.messageMainLayoutPanel.Size = new System.Drawing.Size(449, 325);
            this.messageMainLayoutPanel.TabIndex = 1;
            // 
            // messageSendLayoutPanel
            // 
            this.messageSendLayoutPanel.BackColor = System.Drawing.SystemColors.Window;
            this.messageSendLayoutPanel.ColumnCount = 3;
            this.messageSendLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.messageSendLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.messageSendLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.messageSendLayoutPanel.Controls.Add(this.messageTextBox, 1, 0);
            this.messageSendLayoutPanel.Controls.Add(this.sendButton, 2, 0);
            this.messageSendLayoutPanel.Controls.Add(this.additionalToolsButton, 0, 0);
            this.messageSendLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageSendLayoutPanel.Location = new System.Drawing.Point(3, 252);
            this.messageSendLayoutPanel.Name = "messageSendLayoutPanel";
            this.messageSendLayoutPanel.RowCount = 1;
            this.messageSendLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.messageSendLayoutPanel.Size = new System.Drawing.Size(443, 44);
            this.messageSendLayoutPanel.TabIndex = 2;
            // 
            // messageTextBox
            // 
            this.messageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageTextBox.Location = new System.Drawing.Point(52, 2);
            this.messageTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(339, 40);
            this.messageTextBox.TabIndex = 1;
            this.messageTextBox.Text = "";
            this.messageTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MessageTextBox_KeyDown);
            this.messageTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MessageTextBox_KeyUp);
            // 
            // sendButton
            // 
            this.sendButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sendButton.Image = global::ChatterBox.Client.WinForms.Properties.Resources.SendImage;
            this.sendButton.Location = new System.Drawing.Point(395, 4);
            this.sendButton.Margin = new System.Windows.Forms.Padding(2);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(36, 36);
            this.sendButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sendButton.TabIndex = 0;
            this.sendButton.TabStop = false;
            this.sendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // additionalToolsButton
            // 
            this.additionalToolsButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.additionalToolsButton.Image = ((System.Drawing.Image)(resources.GetObject("additionalToolsButton.Image")));
            this.additionalToolsButton.Location = new System.Drawing.Point(12, 4);
            this.additionalToolsButton.Margin = new System.Windows.Forms.Padding(2);
            this.additionalToolsButton.Name = "additionalToolsButton";
            this.additionalToolsButton.Size = new System.Drawing.Size(36, 36);
            this.additionalToolsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.additionalToolsButton.TabIndex = 2;
            this.additionalToolsButton.TabStop = false;
            this.additionalToolsButton.Click += new System.EventHandler(this.AdditionToolsButton_Click);
            // 
            // messageShowLayoutPanel
            // 
            this.messageShowLayoutPanel.AutoScroll = true;
            this.messageShowLayoutPanel.BackColor = System.Drawing.SystemColors.Window;
            this.messageShowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageShowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.messageShowLayoutPanel.Name = "messageShowLayoutPanel";
            this.messageShowLayoutPanel.Size = new System.Drawing.Size(443, 240);
            this.messageShowLayoutPanel.TabIndex = 1;
            // 
            // resizePanel
            // 
            this.resizePanel.BackColor = System.Drawing.Color.Silver;
            this.resizePanel.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.resizePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resizePanel.Location = new System.Drawing.Point(0, 246);
            this.resizePanel.Margin = new System.Windows.Forms.Padding(0);
            this.resizePanel.Name = "resizePanel";
            this.resizePanel.Size = new System.Drawing.Size(449, 3);
            this.resizePanel.TabIndex = 3;
            this.resizePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResizePanel_MouseDown);
            this.resizePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ResizePanel_MouseMove);
            this.resizePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ResizePanel_MoiseUp);
            // 
            // messageSendAdditionalLayoutPanel
            // 
            this.messageSendAdditionalLayoutPanel.BackColor = System.Drawing.Color.White;
            this.messageSendAdditionalLayoutPanel.ColumnCount = 6;
            this.messageSendAdditionalLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.89796F));
            this.messageSendAdditionalLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.messageSendAdditionalLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.20408F));
            this.messageSendAdditionalLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.messageSendAdditionalLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.messageSendAdditionalLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.89796F));
            this.messageSendAdditionalLayoutPanel.Controls.Add(this.attachButton, 1, 0);
            this.messageSendAdditionalLayoutPanel.Controls.Add(this.selfDestructionButton, 3, 0);
            this.messageSendAdditionalLayoutPanel.Controls.Add(this.selfDestructionPicker, 4, 0);
            this.messageSendAdditionalLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageSendAdditionalLayoutPanel.Location = new System.Drawing.Point(3, 299);
            this.messageSendAdditionalLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.messageSendAdditionalLayoutPanel.Name = "messageSendAdditionalLayoutPanel";
            this.messageSendAdditionalLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.messageSendAdditionalLayoutPanel.RowCount = 1;
            this.messageSendAdditionalLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.messageSendAdditionalLayoutPanel.Size = new System.Drawing.Size(443, 23);
            this.messageSendAdditionalLayoutPanel.TabIndex = 4;
            // 
            // attachButton
            // 
            this.attachButton.Image = global::ChatterBox.Client.WinForms.Properties.Resources.Attach;
            this.attachButton.Location = new System.Drawing.Point(82, 3);
            this.attachButton.Margin = new System.Windows.Forms.Padding(0);
            this.attachButton.Name = "attachButton";
            this.attachButton.Size = new System.Drawing.Size(20, 20);
            this.attachButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.attachButton.TabIndex = 0;
            this.attachButton.TabStop = false;
            this.attachButton.Click += new System.EventHandler(this.AttachButton_Click);
            // 
            // selfDestructionButton
            // 
            this.selfDestructionButton.AutoSize = true;
            this.selfDestructionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selfDestructionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selfDestructionButton.Location = new System.Drawing.Point(120, 3);
            this.selfDestructionButton.Margin = new System.Windows.Forms.Padding(0);
            this.selfDestructionButton.Name = "selfDestructionButton";
            this.selfDestructionButton.Size = new System.Drawing.Size(100, 20);
            this.selfDestructionButton.TabIndex = 1;
            this.selfDestructionButton.Text = "Самоудаление";
            this.selfDestructionButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selfDestructionButton.Click += new System.EventHandler(this.SelfDestructionButton_Click);
            // 
            // selfDestructionPicker
            // 
            this.selfDestructionPicker.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.selfDestructionPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selfDestructionPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.selfDestructionPicker.Location = new System.Drawing.Point(220, 3);
            this.selfDestructionPicker.Margin = new System.Windows.Forms.Padding(0);
            this.selfDestructionPicker.Name = "selfDestructionPicker";
            this.selfDestructionPicker.Size = new System.Drawing.Size(140, 20);
            this.selfDestructionPicker.TabIndex = 2;
            this.selfDestructionPicker.Visible = false;
            // 
            // chatInfoLayoutPanel
            // 
            this.chatInfoLayoutPanel.BackColor = System.Drawing.Color.PaleGreen;
            this.chatInfoLayoutPanel.ColumnCount = 3;
            this.chatInfoLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.chatInfoLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.chatInfoLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.chatInfoLayoutPanel.Controls.Add(this.searchPanel, 1, 0);
            this.chatInfoLayoutPanel.Controls.Add(this.toolsPanel, 2, 0);
            this.chatInfoLayoutPanel.Controls.Add(this.chatNameLayoutPanel, 0, 0);
            this.chatInfoLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatInfoLayoutPanel.Location = new System.Drawing.Point(210, 0);
            this.chatInfoLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.chatInfoLayoutPanel.Name = "chatInfoLayoutPanel";
            this.chatInfoLayoutPanel.RowCount = 1;
            this.chatInfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.chatInfoLayoutPanel.Size = new System.Drawing.Size(455, 40);
            this.chatInfoLayoutPanel.TabIndex = 2;
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.searchBox);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchPanel.Location = new System.Drawing.Point(355, 0);
            this.searchPanel.Margin = new System.Windows.Forms.Padding(0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.searchPanel.Size = new System.Drawing.Size(60, 40);
            this.searchPanel.TabIndex = 2;
            this.searchPanel.Click += new System.EventHandler(this.Search_Click);
            this.searchPanel.MouseEnter += new System.EventHandler(this.ChatInfo_MouseEnter);
            this.searchPanel.MouseLeave += new System.EventHandler(this.ChatInfo_MouseLeave);
            // 
            // searchBox
            // 
            this.searchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchBox.Image = global::ChatterBox.Client.WinForms.Properties.Resources.Search;
            this.searchBox.InitialImage = null;
            this.searchBox.Location = new System.Drawing.Point(20, 10);
            this.searchBox.Margin = new System.Windows.Forms.Padding(0);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(20, 20);
            this.searchBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchBox.TabIndex = 2;
            this.searchBox.TabStop = false;
            this.searchBox.Click += new System.EventHandler(this.Search_Click);
            this.searchBox.MouseEnter += new System.EventHandler(this.ChatInfo_MouseEnter);
            this.searchBox.MouseLeave += new System.EventHandler(this.ChatInfo_MouseLeave);
            // 
            // toolsPanel
            // 
            this.toolsPanel.Controls.Add(this.toolsBox);
            this.toolsPanel.Location = new System.Drawing.Point(415, 0);
            this.toolsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.Padding = new System.Windows.Forms.Padding(10);
            this.toolsPanel.Size = new System.Drawing.Size(40, 40);
            this.toolsPanel.TabIndex = 3;
            this.toolsPanel.Click += new System.EventHandler(this.ChatSettings_Click);
            this.toolsPanel.MouseEnter += new System.EventHandler(this.ChatInfo_MouseEnter);
            this.toolsPanel.MouseLeave += new System.EventHandler(this.ChatInfo_MouseLeave);
            // 
            // toolsBox
            // 
            this.toolsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolsBox.Image = global::ChatterBox.Client.WinForms.Properties.Resources.Tools;
            this.toolsBox.Location = new System.Drawing.Point(10, 10);
            this.toolsBox.Margin = new System.Windows.Forms.Padding(0);
            this.toolsBox.Name = "toolsBox";
            this.toolsBox.Size = new System.Drawing.Size(20, 20);
            this.toolsBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.toolsBox.TabIndex = 0;
            this.toolsBox.TabStop = false;
            this.toolsBox.Click += new System.EventHandler(this.ChatSettings_Click);
            this.toolsBox.MouseEnter += new System.EventHandler(this.ChatInfo_MouseEnter);
            this.toolsBox.MouseLeave += new System.EventHandler(this.ChatInfo_MouseLeave);
            // 
            // chatNameLayoutPanel
            // 
            this.chatNameLayoutPanel.Controls.Add(this.chatNameLabel);
            this.chatNameLayoutPanel.Controls.Add(this.chatMembersLabel);
            this.chatNameLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatNameLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.chatNameLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.chatNameLayoutPanel.Name = "chatNameLayoutPanel";
            this.chatNameLayoutPanel.Size = new System.Drawing.Size(355, 40);
            this.chatNameLayoutPanel.TabIndex = 4;
            this.chatNameLayoutPanel.Click += new System.EventHandler(this.ChatInfo_Click);
            this.chatNameLayoutPanel.MouseEnter += new System.EventHandler(this.ChatInfo_MouseEnter);
            this.chatNameLayoutPanel.MouseLeave += new System.EventHandler(this.ChatInfo_MouseLeave);
            // 
            // chatNameLabel
            // 
            this.chatNameLabel.AutoSize = true;
            this.chatNameLabel.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.chatNameLabel.Location = new System.Drawing.Point(3, 0);
            this.chatNameLabel.MinimumSize = new System.Drawing.Size(0, 40);
            this.chatNameLabel.Name = "chatNameLabel";
            this.chatNameLabel.Size = new System.Drawing.Size(174, 40);
            this.chatNameLabel.TabIndex = 0;
            this.chatNameLabel.Text = "Chat Name Goes Here";
            this.chatNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chatNameLabel.Click += new System.EventHandler(this.ChatInfo_Click);
            this.chatNameLabel.MouseEnter += new System.EventHandler(this.ChatInfo_MouseEnter);
            this.chatNameLabel.MouseLeave += new System.EventHandler(this.ChatInfo_MouseLeave);
            // 
            // chatMembersLabel
            // 
            this.chatMembersLabel.AutoSize = true;
            this.chatMembersLabel.Font = new System.Drawing.Font("Calibri", 10F);
            this.chatMembersLabel.Location = new System.Drawing.Point(183, 0);
            this.chatMembersLabel.MinimumSize = new System.Drawing.Size(0, 40);
            this.chatMembersLabel.Name = "chatMembersLabel";
            this.chatMembersLabel.Size = new System.Drawing.Size(97, 40);
            this.chatMembersLabel.TabIndex = 1;
            this.chatMembersLabel.Text = "Members count";
            this.chatMembersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chatMembersLabel.Click += new System.EventHandler(this.ChatInfo_Click);
            this.chatMembersLabel.MouseEnter += new System.EventHandler(this.ChatInfo_MouseEnter);
            this.chatMembersLabel.MouseLeave += new System.EventHandler(this.ChatInfo_MouseLeave);
            // 
            // commonLayoutPanel
            // 
            this.commonLayoutPanel.BackColor = System.Drawing.Color.PaleGreen;
            this.commonLayoutPanel.ColumnCount = 2;
            this.commonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.commonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.commonLayoutPanel.Controls.Add(this.commonSettingsIcon, 0, 0);
            this.commonLayoutPanel.Controls.Add(this.comonTitleLabel, 1, 0);
            this.commonLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commonLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.commonLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.commonLayoutPanel.Name = "commonLayoutPanel";
            this.commonLayoutPanel.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.commonLayoutPanel.RowCount = 1;
            this.commonLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.commonLayoutPanel.Size = new System.Drawing.Size(210, 40);
            this.commonLayoutPanel.TabIndex = 3;
            this.commonLayoutPanel.Click += new System.EventHandler(this.CommonSettings_Click);
            this.commonLayoutPanel.MouseEnter += new System.EventHandler(this.CommonSettings_MouseEnter);
            this.commonLayoutPanel.MouseLeave += new System.EventHandler(this.CommonSettings_MouseLeave);
            // 
            // commonSettingsIcon
            // 
            this.commonSettingsIcon.AutoSize = true;
            this.commonSettingsIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commonSettingsIcon.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.commonSettingsIcon.Location = new System.Drawing.Point(6, 0);
            this.commonSettingsIcon.Margin = new System.Windows.Forms.Padding(0);
            this.commonSettingsIcon.Name = "commonSettingsIcon";
            this.commonSettingsIcon.Size = new System.Drawing.Size(40, 40);
            this.commonSettingsIcon.TabIndex = 0;
            this.commonSettingsIcon.Text = "☰";
            this.commonSettingsIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.commonSettingsIcon.Click += new System.EventHandler(this.CommonSettings_Click);
            this.commonSettingsIcon.MouseEnter += new System.EventHandler(this.CommonSettings_MouseEnter);
            this.commonSettingsIcon.MouseLeave += new System.EventHandler(this.CommonSettings_MouseLeave);
            // 
            // comonTitleLabel
            // 
            this.comonTitleLabel.AutoSize = true;
            this.comonTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comonTitleLabel.Font = new System.Drawing.Font("Calibri", 18F);
            this.comonTitleLabel.Location = new System.Drawing.Point(46, 0);
            this.comonTitleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.comonTitleLabel.Name = "comonTitleLabel";
            this.comonTitleLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.comonTitleLabel.Size = new System.Drawing.Size(164, 40);
            this.comonTitleLabel.TabIndex = 1;
            this.comonTitleLabel.Text = "ChatterBox";
            this.comonTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.comonTitleLabel.Click += new System.EventHandler(this.CommonSettings_Click);
            this.comonTitleLabel.MouseEnter += new System.EventHandler(this.CommonSettings_MouseEnter);
            this.comonTitleLabel.MouseLeave += new System.EventHandler(this.CommonSettings_MouseLeave);
            // 
            // openAttachDialog
            // 
            this.openAttachDialog.FileName = "openFileDialog1";
            this.openAttachDialog.Multiselect = true;
            // 
            // MainViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 371);
            this.Controls.Add(this.mainLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(681, 410);
            this.Name = "MainViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatterBox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainViewForm_Closing);
            this.Resize += new System.EventHandler(this.Form_Resize);
            this.mainLayoutPanel.ResumeLayout(false);
            this.messageMainLayoutPanel.ResumeLayout(false);
            this.messageSendLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sendButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalToolsButton)).EndInit();
            this.messageSendAdditionalLayoutPanel.ResumeLayout(false);
            this.messageSendAdditionalLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attachButton)).EndInit();
            this.chatInfoLayoutPanel.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchBox)).EndInit();
            this.toolsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolsBox)).EndInit();
            this.chatNameLayoutPanel.ResumeLayout(false);
            this.chatNameLayoutPanel.PerformLayout();
            this.commonLayoutPanel.ResumeLayout(false);
            this.commonLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel chatsLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel messageMainLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel messageShowLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel chatInfoLayoutPanel;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.PictureBox searchBox;
        private System.Windows.Forms.Panel toolsPanel;
        private System.Windows.Forms.PictureBox toolsBox;
        private System.Windows.Forms.FlowLayoutPanel chatNameLayoutPanel;
        private System.Windows.Forms.Label chatNameLabel;
        private System.Windows.Forms.Label chatMembersLabel;
        private System.Windows.Forms.TableLayoutPanel messageSendLayoutPanel;
        private System.Windows.Forms.PictureBox sendButton;
        private System.Windows.Forms.RichTextBox messageTextBox;
        private System.Windows.Forms.Panel resizePanel;
        private System.Windows.Forms.TableLayoutPanel commonLayoutPanel;
        private System.Windows.Forms.Label commonSettingsIcon;
        private System.Windows.Forms.Label comonTitleLabel;
        private System.Windows.Forms.TableLayoutPanel messageSendAdditionalLayoutPanel;
        private System.Windows.Forms.PictureBox additionalToolsButton;
        private System.Windows.Forms.PictureBox attachButton;
        private System.Windows.Forms.Label selfDestructionButton;
        private System.Windows.Forms.DateTimePicker selfDestructionPicker;
        private System.Windows.Forms.OpenFileDialog openAttachDialog;
    }
}