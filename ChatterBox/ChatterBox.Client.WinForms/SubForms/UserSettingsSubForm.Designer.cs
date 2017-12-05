namespace ChatterBox.Client.WinForms.SubForms
{
    partial class UserSettingsSubForm
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
            this.logOutLabel = new System.Windows.Forms.Label();
            this.changePictureLabel = new System.Windows.Forms.Label();
            this.changePasswordLabel = new System.Windows.Forms.Label();
            this.changeLoginLabel = new System.Windows.Forms.Label();
            this.topLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.userInfoLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.changeNameLabel = new System.Windows.Forms.Label();
            this.mainLayoutPanel.SuspendLayout();
            this.topLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.userInfoLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.BackColor = System.Drawing.SystemColors.Window;
            this.mainLayoutPanel.ColumnCount = 1;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.Controls.Add(this.logOutLabel, 0, 5);
            this.mainLayoutPanel.Controls.Add(this.changePictureLabel, 0, 4);
            this.mainLayoutPanel.Controls.Add(this.changePasswordLabel, 0, 3);
            this.mainLayoutPanel.Controls.Add(this.changeLoginLabel, 0, 2);
            this.mainLayoutPanel.Controls.Add(this.topLayoutPanel, 0, 0);
            this.mainLayoutPanel.Controls.Add(this.changeNameLabel, 0, 1);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(1, 1);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 6;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(260, 280);
            this.mainLayoutPanel.TabIndex = 1;
            // 
            // logOutLabel
            // 
            this.logOutLabel.AutoSize = true;
            this.logOutLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logOutLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logOutLabel.ForeColor = System.Drawing.Color.Green;
            this.logOutLabel.Location = new System.Drawing.Point(0, 240);
            this.logOutLabel.Margin = new System.Windows.Forms.Padding(0);
            this.logOutLabel.Name = "logOutLabel";
            this.logOutLabel.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.logOutLabel.Size = new System.Drawing.Size(260, 40);
            this.logOutLabel.TabIndex = 5;
            this.logOutLabel.Text = "Log Out";
            this.logOutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutLabel.MouseEnter += new System.EventHandler(this.SettingsItem_MouseEnter);
            this.logOutLabel.MouseLeave += new System.EventHandler(this.SettingsItem_MouseLeave);
            // 
            // changePictureLabel
            // 
            this.changePictureLabel.AutoSize = true;
            this.changePictureLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changePictureLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changePictureLabel.ForeColor = System.Drawing.Color.Green;
            this.changePictureLabel.Location = new System.Drawing.Point(0, 200);
            this.changePictureLabel.Margin = new System.Windows.Forms.Padding(0);
            this.changePictureLabel.Name = "changePictureLabel";
            this.changePictureLabel.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.changePictureLabel.Size = new System.Drawing.Size(260, 40);
            this.changePictureLabel.TabIndex = 4;
            this.changePictureLabel.Text = "Change Picture";
            this.changePictureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changePictureLabel.MouseEnter += new System.EventHandler(this.SettingsItem_MouseEnter);
            this.changePictureLabel.MouseLeave += new System.EventHandler(this.SettingsItem_MouseLeave);
            // 
            // changePasswordLabel
            // 
            this.changePasswordLabel.AutoSize = true;
            this.changePasswordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changePasswordLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changePasswordLabel.ForeColor = System.Drawing.Color.Green;
            this.changePasswordLabel.Location = new System.Drawing.Point(0, 160);
            this.changePasswordLabel.Margin = new System.Windows.Forms.Padding(0);
            this.changePasswordLabel.Name = "changePasswordLabel";
            this.changePasswordLabel.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.changePasswordLabel.Size = new System.Drawing.Size(260, 40);
            this.changePasswordLabel.TabIndex = 3;
            this.changePasswordLabel.Text = "Change Password";
            this.changePasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changePasswordLabel.MouseEnter += new System.EventHandler(this.SettingsItem_MouseEnter);
            this.changePasswordLabel.MouseLeave += new System.EventHandler(this.SettingsItem_MouseLeave);
            // 
            // changeLoginLabel
            // 
            this.changeLoginLabel.AutoSize = true;
            this.changeLoginLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeLoginLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeLoginLabel.ForeColor = System.Drawing.Color.Green;
            this.changeLoginLabel.Location = new System.Drawing.Point(0, 120);
            this.changeLoginLabel.Margin = new System.Windows.Forms.Padding(0);
            this.changeLoginLabel.Name = "changeLoginLabel";
            this.changeLoginLabel.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.changeLoginLabel.Size = new System.Drawing.Size(260, 40);
            this.changeLoginLabel.TabIndex = 2;
            this.changeLoginLabel.Text = "Change Login";
            this.changeLoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changeLoginLabel.MouseEnter += new System.EventHandler(this.SettingsItem_MouseEnter);
            this.changeLoginLabel.MouseLeave += new System.EventHandler(this.SettingsItem_MouseLeave);
            // 
            // topLayoutPanel
            // 
            this.topLayoutPanel.BackColor = System.Drawing.Color.PaleGreen;
            this.topLayoutPanel.ColumnCount = 2;
            this.topLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.topLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topLayoutPanel.Controls.Add(this.userPictureBox, 0, 0);
            this.topLayoutPanel.Controls.Add(this.userInfoLayoutPanel, 1, 0);
            this.topLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.topLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.topLayoutPanel.Name = "topLayoutPanel";
            this.topLayoutPanel.RowCount = 1;
            this.topLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topLayoutPanel.Size = new System.Drawing.Size(260, 80);
            this.topLayoutPanel.TabIndex = 0;
            // 
            // userPictureBox
            // 
            this.userPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userPictureBox.Location = new System.Drawing.Point(10, 10);
            this.userPictureBox.Margin = new System.Windows.Forms.Padding(10);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(60, 60);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPictureBox.TabIndex = 0;
            this.userPictureBox.TabStop = false;
            // 
            // userInfoLayoutPanel
            // 
            this.userInfoLayoutPanel.ColumnCount = 1;
            this.userInfoLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.userInfoLayoutPanel.Controls.Add(this.userNameLabel, 0, 1);
            this.userInfoLayoutPanel.Controls.Add(this.closeButton, 0, 0);
            this.userInfoLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userInfoLayoutPanel.Location = new System.Drawing.Point(83, 3);
            this.userInfoLayoutPanel.Name = "userInfoLayoutPanel";
            this.userInfoLayoutPanel.RowCount = 2;
            this.userInfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.userInfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.userInfoLayoutPanel.Size = new System.Drawing.Size(174, 74);
            this.userInfoLayoutPanel.TabIndex = 1;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userNameLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameLabel.Location = new System.Drawing.Point(3, 20);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 20);
            this.userNameLabel.Size = new System.Drawing.Size(168, 54);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "User Name";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // closeButton
            // 
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.Image = global::ChatterBox.Client.WinForms.Properties.Resources.CloseX;
            this.closeButton.InitialImage = null;
            this.closeButton.Location = new System.Drawing.Point(154, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 20);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 0;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // changeNameLabel
            // 
            this.changeNameLabel.AutoSize = true;
            this.changeNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeNameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeNameLabel.ForeColor = System.Drawing.Color.Green;
            this.changeNameLabel.Location = new System.Drawing.Point(0, 80);
            this.changeNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.changeNameLabel.Name = "changeNameLabel";
            this.changeNameLabel.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.changeNameLabel.Size = new System.Drawing.Size(260, 40);
            this.changeNameLabel.TabIndex = 1;
            this.changeNameLabel.Text = "Change User Name";
            this.changeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changeNameLabel.MouseEnter += new System.EventHandler(this.SettingsItem_MouseEnter);
            this.changeNameLabel.MouseLeave += new System.EventHandler(this.SettingsItem_MouseLeave);
            // 
            // UserSettingsSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(262, 282);
            this.Controls.Add(this.mainLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserSettingsSubForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UserSettingsSubForm";
            this.mainLayoutPanel.ResumeLayout(false);
            this.mainLayoutPanel.PerformLayout();
            this.topLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.userInfoLayoutPanel.ResumeLayout(false);
            this.userInfoLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.Label changePasswordLabel;
        private System.Windows.Forms.Label changeLoginLabel;
        private System.Windows.Forms.TableLayoutPanel topLayoutPanel;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.TableLayoutPanel userInfoLayoutPanel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Label changeNameLabel;
        private System.Windows.Forms.Label changePictureLabel;
        private System.Windows.Forms.Label logOutLabel;
    }
}