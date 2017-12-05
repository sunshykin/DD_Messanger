namespace ChatterBox.Client.WinForms.SubForms
{
    partial class ChatInfoSubForm
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
            this.deleteChatLabel = new System.Windows.Forms.Label();
            this.leaveChatLabel = new System.Windows.Forms.Label();
            this.topLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.chatPictureBox = new System.Windows.Forms.PictureBox();
            this.chatInfoLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.chatTitleLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.membersLabel = new System.Windows.Forms.Label();
            this.mainLayoutPanel.SuspendLayout();
            this.topLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chatPictureBox)).BeginInit();
            this.chatInfoLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.BackColor = System.Drawing.SystemColors.Window;
            this.mainLayoutPanel.ColumnCount = 1;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.Controls.Add(this.deleteChatLabel, 0, 3);
            this.mainLayoutPanel.Controls.Add(this.leaveChatLabel, 0, 2);
            this.mainLayoutPanel.Controls.Add(this.topLayoutPanel, 0, 0);
            this.mainLayoutPanel.Controls.Add(this.membersLabel, 0, 1);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(1, 1);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 4;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(302, 200);
            this.mainLayoutPanel.TabIndex = 0;
            // 
            // deleteChatLabel
            // 
            this.deleteChatLabel.AutoSize = true;
            this.deleteChatLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteChatLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteChatLabel.ForeColor = System.Drawing.Color.Green;
            this.deleteChatLabel.Location = new System.Drawing.Point(0, 160);
            this.deleteChatLabel.Margin = new System.Windows.Forms.Padding(0);
            this.deleteChatLabel.Name = "deleteChatLabel";
            this.deleteChatLabel.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.deleteChatLabel.Size = new System.Drawing.Size(302, 40);
            this.deleteChatLabel.TabIndex = 3;
            this.deleteChatLabel.Text = "Delete This Chat";
            this.deleteChatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteChatLabel.MouseEnter += new System.EventHandler(this.ChatInfo_MouseEnter);
            this.deleteChatLabel.MouseLeave += new System.EventHandler(this.ChatInfo_MouseLeave);
            // 
            // leaveChatLabel
            // 
            this.leaveChatLabel.AutoSize = true;
            this.leaveChatLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leaveChatLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leaveChatLabel.ForeColor = System.Drawing.Color.Green;
            this.leaveChatLabel.Location = new System.Drawing.Point(0, 120);
            this.leaveChatLabel.Margin = new System.Windows.Forms.Padding(0);
            this.leaveChatLabel.Name = "leaveChatLabel";
            this.leaveChatLabel.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.leaveChatLabel.Size = new System.Drawing.Size(302, 40);
            this.leaveChatLabel.TabIndex = 2;
            this.leaveChatLabel.Text = "Leave This Chat";
            this.leaveChatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.leaveChatLabel.MouseEnter += new System.EventHandler(this.ChatInfo_MouseEnter);
            this.leaveChatLabel.MouseLeave += new System.EventHandler(this.ChatInfo_MouseLeave);
            // 
            // topLayoutPanel
            // 
            this.topLayoutPanel.BackColor = System.Drawing.Color.PaleGreen;
            this.topLayoutPanel.ColumnCount = 2;
            this.topLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.topLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topLayoutPanel.Controls.Add(this.chatPictureBox, 0, 0);
            this.topLayoutPanel.Controls.Add(this.chatInfoLayoutPanel, 1, 0);
            this.topLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.topLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.topLayoutPanel.Name = "topLayoutPanel";
            this.topLayoutPanel.RowCount = 1;
            this.topLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topLayoutPanel.Size = new System.Drawing.Size(302, 80);
            this.topLayoutPanel.TabIndex = 0;
            // 
            // chatPictureBox
            // 
            this.chatPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatPictureBox.Location = new System.Drawing.Point(10, 10);
            this.chatPictureBox.Margin = new System.Windows.Forms.Padding(10);
            this.chatPictureBox.Name = "chatPictureBox";
            this.chatPictureBox.Size = new System.Drawing.Size(60, 60);
            this.chatPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chatPictureBox.TabIndex = 0;
            this.chatPictureBox.TabStop = false;
            // 
            // chatInfoLayoutPanel
            // 
            this.chatInfoLayoutPanel.ColumnCount = 1;
            this.chatInfoLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.chatInfoLayoutPanel.Controls.Add(this.chatTitleLabel, 0, 1);
            this.chatInfoLayoutPanel.Controls.Add(this.closeButton, 0, 0);
            this.chatInfoLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatInfoLayoutPanel.Location = new System.Drawing.Point(83, 3);
            this.chatInfoLayoutPanel.Name = "chatInfoLayoutPanel";
            this.chatInfoLayoutPanel.RowCount = 2;
            this.chatInfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.chatInfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.chatInfoLayoutPanel.Size = new System.Drawing.Size(216, 74);
            this.chatInfoLayoutPanel.TabIndex = 1;
            // 
            // chatTitleLabel
            // 
            this.chatTitleLabel.AutoSize = true;
            this.chatTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatTitleLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chatTitleLabel.Location = new System.Drawing.Point(3, 20);
            this.chatTitleLabel.Name = "chatTitleLabel";
            this.chatTitleLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 20);
            this.chatTitleLabel.Size = new System.Drawing.Size(210, 54);
            this.chatTitleLabel.TabIndex = 2;
            this.chatTitleLabel.Text = "Chat Title";
            this.chatTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // closeButton
            // 
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.Image = global::ChatterBox.Client.WinForms.Properties.Resources.CloseX;
            this.closeButton.InitialImage = null;
            this.closeButton.Location = new System.Drawing.Point(196, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 20);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 0;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // membersLabel
            // 
            this.membersLabel.AutoSize = true;
            this.membersLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.membersLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.membersLabel.ForeColor = System.Drawing.Color.Green;
            this.membersLabel.Location = new System.Drawing.Point(0, 80);
            this.membersLabel.Margin = new System.Windows.Forms.Padding(0);
            this.membersLabel.Name = "membersLabel";
            this.membersLabel.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.membersLabel.Size = new System.Drawing.Size(302, 40);
            this.membersLabel.TabIndex = 1;
            this.membersLabel.Text = "Members Count";
            this.membersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.membersLabel.MouseEnter += new System.EventHandler(this.ChatInfo_MouseEnter);
            this.membersLabel.MouseLeave += new System.EventHandler(this.ChatInfo_MouseLeave);
            // 
            // ChatInfoSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(304, 202);
            this.Controls.Add(this.mainLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChatInfoSubForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChatInfoSubForm";
            this.mainLayoutPanel.ResumeLayout(false);
            this.mainLayoutPanel.PerformLayout();
            this.topLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chatPictureBox)).EndInit();
            this.chatInfoLayoutPanel.ResumeLayout(false);
            this.chatInfoLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel topLayoutPanel;
        private System.Windows.Forms.PictureBox chatPictureBox;
        private System.Windows.Forms.Label deleteChatLabel;
        private System.Windows.Forms.Label leaveChatLabel;
        private System.Windows.Forms.Label membersLabel;
        private System.Windows.Forms.TableLayoutPanel chatInfoLayoutPanel;
        private System.Windows.Forms.Label chatTitleLabel;
        private System.Windows.Forms.PictureBox closeButton;
    }
}