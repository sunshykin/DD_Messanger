namespace ChatterBox.Client.WinForms.Controls
{
    partial class ChatControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.avatarBox = new System.Windows.Forms.PictureBox();
            this.textLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.chatTitleLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.mainLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).BeginInit();
            this.textLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.ColumnCount = 5;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.mainLayoutPanel.Controls.Add(this.avatarBox, 1, 1);
            this.mainLayoutPanel.Controls.Add(this.textLayoutPanel, 3, 1);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 3;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(280, 60);
            this.mainLayoutPanel.TabIndex = 0;
            this.mainLayoutPanel.Click += new System.EventHandler(this.ChatControl_Click);
            this.mainLayoutPanel.MouseEnter += new System.EventHandler(this.ChatControl_MouseEnter);
            this.mainLayoutPanel.MouseLeave += new System.EventHandler(this.ChatControl_MouseLeave);
            // 
            // avatarBox
            // 
            this.avatarBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avatarBox.Location = new System.Drawing.Point(4, 4);
            this.avatarBox.Margin = new System.Windows.Forms.Padding(0);
            this.avatarBox.Name = "avatarBox";
            this.avatarBox.Size = new System.Drawing.Size(50, 52);
            this.avatarBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarBox.TabIndex = 0;
            this.avatarBox.TabStop = false;
            this.avatarBox.Click += new System.EventHandler(this.ChatControl_Click);
            this.avatarBox.MouseEnter += new System.EventHandler(this.ChatControl_MouseEnter);
            this.avatarBox.MouseLeave += new System.EventHandler(this.ChatControl_MouseLeave);
            // 
            // textLayoutPanel
            // 
            this.textLayoutPanel.ColumnCount = 1;
            this.textLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.textLayoutPanel.Controls.Add(this.chatTitleLabel, 0, 0);
            this.textLayoutPanel.Controls.Add(this.messageLabel, 0, 1);
            this.textLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textLayoutPanel.Location = new System.Drawing.Point(62, 7);
            this.textLayoutPanel.Name = "textLayoutPanel";
            this.textLayoutPanel.RowCount = 2;
            this.textLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.textLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.textLayoutPanel.Size = new System.Drawing.Size(211, 46);
            this.textLayoutPanel.TabIndex = 1;
            // 
            // chatTitleLabel
            // 
            this.chatTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatTitleLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chatTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.chatTitleLabel.Name = "chatTitleLabel";
            this.chatTitleLabel.Size = new System.Drawing.Size(205, 27);
            this.chatTitleLabel.TabIndex = 0;
            this.chatTitleLabel.Text = "ChatName";
            this.chatTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chatTitleLabel.Click += new System.EventHandler(this.ChatControl_Click);
            this.chatTitleLabel.MouseEnter += new System.EventHandler(this.ChatControl_MouseEnter);
            this.chatTitleLabel.MouseLeave += new System.EventHandler(this.ChatControl_MouseLeave);
            // 
            // messageLabel
            // 
            this.messageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageLabel.Location = new System.Drawing.Point(3, 27);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(205, 19);
            this.messageLabel.TabIndex = 1;
            this.messageLabel.Text = "Message: Label";
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.messageLabel.Click += new System.EventHandler(this.ChatControl_Click);
            this.messageLabel.MouseEnter += new System.EventHandler(this.ChatControl_MouseEnter);
            this.messageLabel.MouseLeave += new System.EventHandler(this.ChatControl_MouseLeave);
            // 
            // ChatControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.mainLayoutPanel);
            this.Name = "ChatControl";
            this.Size = new System.Drawing.Size(280, 60);
            this.MouseEnter += new System.EventHandler(this.ChatControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ChatControl_MouseLeave);
            this.mainLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).EndInit();
            this.textLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.PictureBox avatarBox;
        private System.Windows.Forms.TableLayoutPanel textLayoutPanel;
        private System.Windows.Forms.Label chatTitleLabel;
        private System.Windows.Forms.Label messageLabel;
    }
}
