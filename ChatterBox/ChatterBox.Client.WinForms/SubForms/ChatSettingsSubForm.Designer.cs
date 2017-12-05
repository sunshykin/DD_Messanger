namespace ChatterBox.Client.WinForms.SubForms
{
    partial class ChatSettingsSubForm
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
            this.chatChangesLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.changePictureLabel = new System.Windows.Forms.Label();
            this.changeTitleLabel = new System.Windows.Forms.Label();
            this.chatShowsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.showAttachsLabel = new System.Windows.Forms.Label();
            this.mainLayoutPanel.SuspendLayout();
            this.chatChangesLayoutPanel.SuspendLayout();
            this.chatShowsLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.BackColor = System.Drawing.Color.PaleGreen;
            this.mainLayoutPanel.ColumnCount = 1;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.Controls.Add(this.chatChangesLayoutPanel, 0, 0);
            this.mainLayoutPanel.Controls.Add(this.chatShowsLayoutPanel, 0, 1);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.Padding = new System.Windows.Forms.Padding(1);
            this.mainLayoutPanel.RowCount = 2;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(202, 92);
            this.mainLayoutPanel.TabIndex = 0;
            // 
            // chatChangesLayoutPanel
            // 
            this.chatChangesLayoutPanel.BackColor = System.Drawing.SystemColors.Window;
            this.chatChangesLayoutPanel.ColumnCount = 1;
            this.chatChangesLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.chatChangesLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.chatChangesLayoutPanel.Controls.Add(this.changePictureLabel, 0, 1);
            this.chatChangesLayoutPanel.Controls.Add(this.changeTitleLabel, 0, 0);
            this.chatChangesLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatChangesLayoutPanel.Location = new System.Drawing.Point(1, 1);
            this.chatChangesLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.chatChangesLayoutPanel.Name = "chatChangesLayoutPanel";
            this.chatChangesLayoutPanel.RowCount = 2;
            this.chatChangesLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.chatChangesLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.chatChangesLayoutPanel.Size = new System.Drawing.Size(200, 60);
            this.chatChangesLayoutPanel.TabIndex = 0;
            // 
            // changePictureLabel
            // 
            this.changePictureLabel.AutoSize = true;
            this.changePictureLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changePictureLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changePictureLabel.ForeColor = System.Drawing.Color.Green;
            this.changePictureLabel.Location = new System.Drawing.Point(1, 31);
            this.changePictureLabel.Margin = new System.Windows.Forms.Padding(1);
            this.changePictureLabel.Name = "changePictureLabel";
            this.changePictureLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.changePictureLabel.Size = new System.Drawing.Size(198, 28);
            this.changePictureLabel.TabIndex = 1;
            this.changePictureLabel.Text = "Change Chat Picture";
            this.changePictureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changePictureLabel.MouseEnter += new System.EventHandler(this.SettingsItem_MouseEnter);
            this.changePictureLabel.MouseLeave += new System.EventHandler(this.SettingsItem_MouseLeave);
            // 
            // changeTitleLabel
            // 
            this.changeTitleLabel.AutoSize = true;
            this.changeTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeTitleLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeTitleLabel.ForeColor = System.Drawing.Color.Green;
            this.changeTitleLabel.Location = new System.Drawing.Point(1, 1);
            this.changeTitleLabel.Margin = new System.Windows.Forms.Padding(1);
            this.changeTitleLabel.Name = "changeTitleLabel";
            this.changeTitleLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.changeTitleLabel.Size = new System.Drawing.Size(198, 28);
            this.changeTitleLabel.TabIndex = 0;
            this.changeTitleLabel.Text = "Change Chat Title";
            this.changeTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changeTitleLabel.MouseEnter += new System.EventHandler(this.SettingsItem_MouseEnter);
            this.changeTitleLabel.MouseLeave += new System.EventHandler(this.SettingsItem_MouseLeave);
            // 
            // chatShowsLayoutPanel
            // 
            this.chatShowsLayoutPanel.BackColor = System.Drawing.Color.PaleGreen;
            this.chatShowsLayoutPanel.ColumnCount = 1;
            this.chatShowsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.chatShowsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.chatShowsLayoutPanel.Controls.Add(this.showAttachsLabel, 0, 0);
            this.chatShowsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatShowsLayoutPanel.Location = new System.Drawing.Point(1, 61);
            this.chatShowsLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.chatShowsLayoutPanel.Name = "chatShowsLayoutPanel";
            this.chatShowsLayoutPanel.RowCount = 1;
            this.chatShowsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.chatShowsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.chatShowsLayoutPanel.Size = new System.Drawing.Size(200, 30);
            this.chatShowsLayoutPanel.TabIndex = 1;
            // 
            // showAttachsLabel
            // 
            this.showAttachsLabel.AutoSize = true;
            this.showAttachsLabel.BackColor = System.Drawing.SystemColors.Window;
            this.showAttachsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showAttachsLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showAttachsLabel.ForeColor = System.Drawing.Color.Green;
            this.showAttachsLabel.Location = new System.Drawing.Point(0, 1);
            this.showAttachsLabel.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.showAttachsLabel.Name = "showAttachsLabel";
            this.showAttachsLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.showAttachsLabel.Size = new System.Drawing.Size(200, 29);
            this.showAttachsLabel.TabIndex = 2;
            this.showAttachsLabel.Text = "Show Chat Attachs";
            this.showAttachsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showAttachsLabel.MouseEnter += new System.EventHandler(this.SettingsItem_MouseEnter);
            this.showAttachsLabel.MouseLeave += new System.EventHandler(this.SettingsItem_MouseLeave);
            // 
            // ChatSettingsSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 92);
            this.Controls.Add(this.mainLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChatSettingsSubForm";
            this.Text = "SettingsSubForm";
            this.mainLayoutPanel.ResumeLayout(false);
            this.chatChangesLayoutPanel.ResumeLayout(false);
            this.chatChangesLayoutPanel.PerformLayout();
            this.chatShowsLayoutPanel.ResumeLayout(false);
            this.chatShowsLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel chatChangesLayoutPanel;
        private System.Windows.Forms.Label changePictureLabel;
        private System.Windows.Forms.Label changeTitleLabel;
        private System.Windows.Forms.TableLayoutPanel chatShowsLayoutPanel;
        private System.Windows.Forms.Label showAttachsLabel;
    }
}