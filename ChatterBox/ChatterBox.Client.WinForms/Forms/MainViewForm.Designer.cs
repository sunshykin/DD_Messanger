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
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.chatsLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.messageMainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.messageSendLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.messageTextBox = new System.Windows.Forms.RichTextBox();
            this.messageShowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.sendButton = new System.Windows.Forms.PictureBox();
            this.mainLayoutPanel.SuspendLayout();
            this.messageMainLayoutPanel.SuspendLayout();
            this.messageSendLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sendButton)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.ColumnCount = 2;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.Controls.Add(this.chatsLayoutPanel, 0, 1);
            this.mainLayoutPanel.Controls.Add(this.messageMainLayoutPanel, 1, 1);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 2;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(666, 372);
            this.mainLayoutPanel.TabIndex = 0;
            // 
            // chatsLayoutPanel
            // 
            this.chatsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatsLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.chatsLayoutPanel.Location = new System.Drawing.Point(3, 43);
            this.chatsLayoutPanel.Name = "chatsLayoutPanel";
            this.chatsLayoutPanel.Size = new System.Drawing.Size(204, 326);
            this.chatsLayoutPanel.TabIndex = 0;
            this.chatsLayoutPanel.WrapContents = false;
            this.chatsLayoutPanel.MouseEnter += new System.EventHandler(this.chats_MouseEnter);
            this.chatsLayoutPanel.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.chats_MouseWheel);
            // 
            // messageMainLayoutPanel
            // 
            this.messageMainLayoutPanel.ColumnCount = 1;
            this.messageMainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.messageMainLayoutPanel.Controls.Add(this.messageSendLayoutPanel, 0, 1);
            this.messageMainLayoutPanel.Controls.Add(this.messageShowLayoutPanel, 0, 0);
            this.messageMainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageMainLayoutPanel.Location = new System.Drawing.Point(213, 43);
            this.messageMainLayoutPanel.Name = "messageMainLayoutPanel";
            this.messageMainLayoutPanel.RowCount = 2;
            this.messageMainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.messageMainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.messageMainLayoutPanel.Size = new System.Drawing.Size(450, 326);
            this.messageMainLayoutPanel.TabIndex = 1;
            // 
            // messageSendLayoutPanel
            // 
            this.messageSendLayoutPanel.BackColor = System.Drawing.SystemColors.Window;
            this.messageSendLayoutPanel.ColumnCount = 3;
            this.messageSendLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.messageSendLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.messageSendLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.messageSendLayoutPanel.Controls.Add(this.sendButton, 2, 0);
            this.messageSendLayoutPanel.Controls.Add(this.messageTextBox, 1, 0);
            this.messageSendLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageSendLayoutPanel.Location = new System.Drawing.Point(3, 289);
            this.messageSendLayoutPanel.Name = "messageSendLayoutPanel";
            this.messageSendLayoutPanel.RowCount = 1;
            this.messageSendLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.messageSendLayoutPanel.Size = new System.Drawing.Size(444, 34);
            this.messageSendLayoutPanel.TabIndex = 0;
            // 
            // messageTextBox
            // 
            this.messageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageTextBox.Location = new System.Drawing.Point(42, 2);
            this.messageTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(320, 30);
            this.messageTextBox.TabIndex = 1;
            this.messageTextBox.Text = "";
            // 
            // messageShowLayoutPanel
            // 
            this.messageShowLayoutPanel.AutoScroll = true;
            this.messageShowLayoutPanel.BackColor = System.Drawing.SystemColors.Window;
            this.messageShowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageShowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.messageShowLayoutPanel.Name = "messageShowLayoutPanel";
            this.messageShowLayoutPanel.Size = new System.Drawing.Size(444, 280);
            this.messageShowLayoutPanel.TabIndex = 1;
            // 
            // sendButton
            // 
            this.sendButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sendButton.Image = global::ChatterBox.Client.WinForms.Properties.Resources.SendImage;
            this.sendButton.Location = new System.Drawing.Point(366, 2);
            this.sendButton.Margin = new System.Windows.Forms.Padding(2);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(30, 30);
            this.sendButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sendButton.TabIndex = 0;
            this.sendButton.TabStop = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // MainViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 372);
            this.Controls.Add(this.mainLayoutPanel);
            this.Name = "MainViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatterBox";
            this.ResizeEnd += new System.EventHandler(this.Form_ResizeEnd);
            this.mainLayoutPanel.ResumeLayout(false);
            this.messageMainLayoutPanel.ResumeLayout(false);
            this.messageSendLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sendButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel chatsLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel messageMainLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel messageSendLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel messageShowLayoutPanel;
        private System.Windows.Forms.PictureBox sendButton;
        private System.Windows.Forms.RichTextBox messageTextBox;
    }
}