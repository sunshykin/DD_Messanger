namespace ChatterBox.Client.WinForms.Controls
{
    partial class UserInfoControl
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
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.actionButton = new System.Windows.Forms.PictureBox();
            this.mainLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionButton)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.ColumnCount = 3;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainLayoutPanel.Controls.Add(this.userPictureBox, 0, 0);
            this.mainLayoutPanel.Controls.Add(this.userNameLabel, 1, 0);
            this.mainLayoutPanel.Controls.Add(this.actionButton, 2, 0);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 1;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(260, 50);
            this.mainLayoutPanel.TabIndex = 0;
            this.mainLayoutPanel.Click += new System.EventHandler(this.UserInfo_Click);
            this.mainLayoutPanel.MouseEnter += new System.EventHandler(this.UserInfo_MouseEnter);
            this.mainLayoutPanel.MouseLeave += new System.EventHandler(this.UserInfo_MouseLeave);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userNameLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.userNameLabel.Location = new System.Drawing.Point(70, 0);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.userNameLabel.Size = new System.Drawing.Size(150, 50);
            this.userNameLabel.TabIndex = 1;
            this.userNameLabel.Text = "User Name";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userNameLabel.Click += new System.EventHandler(this.UserInfo_Click);
            this.userNameLabel.MouseEnter += new System.EventHandler(this.UserInfo_MouseEnter);
            this.userNameLabel.MouseLeave += new System.EventHandler(this.UserInfo_MouseLeave);
            // 
            // userPictureBox
            // 
            this.userPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userPictureBox.Location = new System.Drawing.Point(17, 2);
            this.userPictureBox.Margin = new System.Windows.Forms.Padding(17, 2, 7, 2);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(46, 46);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPictureBox.TabIndex = 0;
            this.userPictureBox.TabStop = false;
            this.userPictureBox.Click += new System.EventHandler(this.UserInfo_Click);
            this.userPictureBox.MouseEnter += new System.EventHandler(this.UserInfo_MouseEnter);
            this.userPictureBox.MouseLeave += new System.EventHandler(this.UserInfo_MouseLeave);
            // 
            // actionButton
            // 
            this.actionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionButton.Image = global::ChatterBox.Client.WinForms.Properties.Resources.DeleteInactive;
            this.actionButton.Location = new System.Drawing.Point(220, 0);
            this.actionButton.Margin = new System.Windows.Forms.Padding(0);
            this.actionButton.Name = "actionButton";
            this.actionButton.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.actionButton.Size = new System.Drawing.Size(40, 50);
            this.actionButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.actionButton.TabIndex = 2;
            this.actionButton.TabStop = false;
            this.actionButton.Click += new System.EventHandler(this.ActionButton_Click);
            this.actionButton.MouseEnter += new System.EventHandler(this.UserInfoButton_MouseEnter);
            this.actionButton.MouseLeave += new System.EventHandler(this.UserInfoButton_MouseLeave);
            // 
            // UserInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.mainLayoutPanel);
            this.Name = "UserInfoControl";
            this.Size = new System.Drawing.Size(260, 50);
            this.mainLayoutPanel.ResumeLayout(false);
            this.mainLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.PictureBox actionButton;
    }
}
