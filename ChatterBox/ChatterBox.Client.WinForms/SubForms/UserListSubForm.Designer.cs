namespace ChatterBox.Client.WinForms.SubForms
{
    partial class UserListSubForm
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
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.actionLabel = new System.Windows.Forms.Label();
            this.userCardsLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mainLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.BackColor = System.Drawing.Color.PaleGreen;
            this.mainLayoutPanel.ColumnCount = 1;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.Controls.Add(this.closeButton, 0, 0);
            this.mainLayoutPanel.Controls.Add(this.titleLabel, 0, 1);
            this.mainLayoutPanel.Controls.Add(this.actionLabel, 0, 3);
            this.mainLayoutPanel.Controls.Add(this.userCardsLayoutPanel, 0, 2);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(1, 1);
            this.mainLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 4;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(283, 360);
            this.mainLayoutPanel.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.Image = global::ChatterBox.Client.WinForms.Properties.Resources.CloseX;
            this.closeButton.InitialImage = null;
            this.closeButton.Location = new System.Drawing.Point(263, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 20);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 1;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 16.75F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(3, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.titleLabel.Size = new System.Drawing.Size(277, 40);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Title";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // actionLabel
            // 
            this.actionLabel.AutoSize = true;
            this.actionLabel.BackColor = System.Drawing.Color.White;
            this.actionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionLabel.Font = new System.Drawing.Font("Calibri", 16F);
            this.actionLabel.Location = new System.Drawing.Point(0, 320);
            this.actionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.Size = new System.Drawing.Size(283, 40);
            this.actionLabel.TabIndex = 3;
            this.actionLabel.Text = "Action Here";
            this.actionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.actionLabel.MouseEnter += new System.EventHandler(this.ActionLabel_MouseEnter);
            this.actionLabel.MouseLeave += new System.EventHandler(this.ActionLabel_MouseLeave);
            // 
            // userCardsLayoutPanel
            // 
            this.userCardsLayoutPanel.AutoScroll = true;
            this.userCardsLayoutPanel.BackColor = System.Drawing.Color.White;
            this.userCardsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userCardsLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.userCardsLayoutPanel.Location = new System.Drawing.Point(0, 60);
            this.userCardsLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.userCardsLayoutPanel.Name = "userCardsLayoutPanel";
            this.userCardsLayoutPanel.Size = new System.Drawing.Size(283, 260);
            this.userCardsLayoutPanel.TabIndex = 4;
            this.userCardsLayoutPanel.WrapContents = false;
            // 
            // UserListSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(285, 362);
            this.Controls.Add(this.mainLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserListSubForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UserListSubForm";
            this.mainLayoutPanel.ResumeLayout(false);
            this.mainLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label actionLabel;
        private System.Windows.Forms.FlowLayoutPanel userCardsLayoutPanel;
    }
}