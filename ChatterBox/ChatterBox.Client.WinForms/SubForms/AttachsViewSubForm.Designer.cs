namespace ChatterBox.Client.WinForms.SubForms
{
    partial class AttachsViewSubForm
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
            this.downloadLabel = new System.Windows.Forms.Label();
            this.attachsLargeLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
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
            this.mainLayoutPanel.Controls.Add(this.downloadLabel, 0, 3);
            this.mainLayoutPanel.Controls.Add(this.attachsLargeLayoutPanel, 0, 2);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(1, 1);
            this.mainLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 4;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(476, 360);
            this.mainLayoutPanel.TabIndex = 1;
            // 
            // closeButton
            // 
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.Image = global::ChatterBox.Client.WinForms.Properties.Resources.CloseX;
            this.closeButton.InitialImage = null;
            this.closeButton.Location = new System.Drawing.Point(456, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 20);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 1;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.ClickButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 16.75F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(3, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.titleLabel.Size = new System.Drawing.Size(470, 40);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Title";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // downloadLabel
            // 
            this.downloadLabel.AutoSize = true;
            this.downloadLabel.BackColor = System.Drawing.Color.White;
            this.downloadLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downloadLabel.Font = new System.Drawing.Font("Calibri", 16F);
            this.downloadLabel.Location = new System.Drawing.Point(0, 320);
            this.downloadLabel.Margin = new System.Windows.Forms.Padding(0);
            this.downloadLabel.Name = "downloadLabel";
            this.downloadLabel.Size = new System.Drawing.Size(476, 40);
            this.downloadLabel.TabIndex = 3;
            this.downloadLabel.Text = "Download Files";
            this.downloadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.downloadLabel.Click += new System.EventHandler(this.DownloadButton_Click);
            this.downloadLabel.MouseEnter += new System.EventHandler(this.DownloadButton_MouseEnter);
            this.downloadLabel.MouseLeave += new System.EventHandler(this.DownloadButton_MouseLeave);
            // 
            // attachsLargeLayoutPanel
            // 
            this.attachsLargeLayoutPanel.AutoScroll = true;
            this.attachsLargeLayoutPanel.BackColor = System.Drawing.Color.White;
            this.attachsLargeLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attachsLargeLayoutPanel.Location = new System.Drawing.Point(0, 60);
            this.attachsLargeLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.attachsLargeLayoutPanel.Name = "attachsLargeLayoutPanel";
            this.attachsLargeLayoutPanel.Size = new System.Drawing.Size(476, 260);
            this.attachsLargeLayoutPanel.TabIndex = 4;
            // 
            // AttachsViewSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(478, 362);
            this.Controls.Add(this.mainLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AttachsViewSubForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AttachsViewSubForm";
            this.mainLayoutPanel.ResumeLayout(false);
            this.mainLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label downloadLabel;
        private System.Windows.Forms.FlowLayoutPanel attachsLargeLayoutPanel;
    }
}