namespace ChatterBox.Client.WinForms.SubForms
{
    partial class CommonSettingsSubForm
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
            this.newChatLabel = new System.Windows.Forms.Label();
            this.contactsLabel = new System.Windows.Forms.Label();
            this.userSettingsLabel = new System.Windows.Forms.Label();
            this.mainLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.BackColor = System.Drawing.SystemColors.Window;
            this.mainLayoutPanel.ColumnCount = 1;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.Controls.Add(this.userSettingsLabel, 0, 2);
            this.mainLayoutPanel.Controls.Add(this.contactsLabel, 0, 1);
            this.mainLayoutPanel.Controls.Add(this.newChatLabel, 0, 0);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(1, 1);
            this.mainLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 3;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(208, 120);
            this.mainLayoutPanel.TabIndex = 0;
            // 
            // newChatLabel
            // 
            this.newChatLabel.AutoSize = true;
            this.newChatLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newChatLabel.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.newChatLabel.ForeColor = System.Drawing.Color.Green;
            this.newChatLabel.Location = new System.Drawing.Point(0, 0);
            this.newChatLabel.Margin = new System.Windows.Forms.Padding(0);
            this.newChatLabel.Name = "newChatLabel";
            this.newChatLabel.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.newChatLabel.Size = new System.Drawing.Size(208, 40);
            this.newChatLabel.TabIndex = 0;
            this.newChatLabel.Text = "New Chat";
            this.newChatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newChatLabel.MouseEnter += new System.EventHandler(this.CommonItem_MouseEnter);
            this.newChatLabel.MouseLeave += new System.EventHandler(this.CommonItem_MouseLeave);
            // 
            // contactsLabel
            // 
            this.contactsLabel.AutoSize = true;
            this.contactsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contactsLabel.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.contactsLabel.ForeColor = System.Drawing.Color.Green;
            this.contactsLabel.Location = new System.Drawing.Point(0, 40);
            this.contactsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.contactsLabel.Name = "contactsLabel";
            this.contactsLabel.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.contactsLabel.Size = new System.Drawing.Size(208, 40);
            this.contactsLabel.TabIndex = 1;
            this.contactsLabel.Text = "Contacts";
            this.contactsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contactsLabel.MouseEnter += new System.EventHandler(this.CommonItem_MouseEnter);
            this.contactsLabel.MouseLeave += new System.EventHandler(this.CommonItem_MouseLeave);
            // 
            // userSettingsLabel
            // 
            this.userSettingsLabel.AutoSize = true;
            this.userSettingsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userSettingsLabel.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.userSettingsLabel.ForeColor = System.Drawing.Color.Green;
            this.userSettingsLabel.Location = new System.Drawing.Point(0, 80);
            this.userSettingsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.userSettingsLabel.Name = "userSettingsLabel";
            this.userSettingsLabel.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.userSettingsLabel.Size = new System.Drawing.Size(208, 40);
            this.userSettingsLabel.TabIndex = 2;
            this.userSettingsLabel.Text = "User Settings";
            this.userSettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userSettingsLabel.MouseEnter += new System.EventHandler(this.CommonItem_MouseEnter);
            this.userSettingsLabel.MouseLeave += new System.EventHandler(this.CommonItem_MouseLeave);
            // 
            // CommonSettingsSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(210, 122);
            this.Controls.Add(this.mainLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CommonSettingsSubForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "CommonSettingsSubForm";
            this.mainLayoutPanel.ResumeLayout(false);
            this.mainLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.Label userSettingsLabel;
        private System.Windows.Forms.Label contactsLabel;
        private System.Windows.Forms.Label newChatLabel;
    }
}