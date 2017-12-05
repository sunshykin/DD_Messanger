namespace ChatterBox.Client.WinForms.SubForms
{
    partial class SimpleYesNoSubForm
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
            this.infoLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.infoTextLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.buttonsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.noButton = new System.Windows.Forms.Label();
            this.yesButton = new System.Windows.Forms.Label();
            this.mainLayoutPanel.SuspendLayout();
            this.infoLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.buttonsLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.BackColor = System.Drawing.SystemColors.Window;
            this.mainLayoutPanel.ColumnCount = 1;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.Controls.Add(this.infoLayoutPanel, 0, 0);
            this.mainLayoutPanel.Controls.Add(this.buttonsLayoutPanel, 0, 1);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(1, 1);
            this.mainLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 2;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(260, 120);
            this.mainLayoutPanel.TabIndex = 0;
            // 
            // infoLayoutPanel
            // 
            this.infoLayoutPanel.BackColor = System.Drawing.Color.PaleGreen;
            this.infoLayoutPanel.ColumnCount = 1;
            this.infoLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.infoLayoutPanel.Controls.Add(this.infoTextLabel, 0, 1);
            this.infoLayoutPanel.Controls.Add(this.closeButton, 0, 0);
            this.infoLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.infoLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.infoLayoutPanel.Name = "infoLayoutPanel";
            this.infoLayoutPanel.RowCount = 2;
            this.infoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.infoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.infoLayoutPanel.Size = new System.Drawing.Size(260, 80);
            this.infoLayoutPanel.TabIndex = 2;
            // 
            // infoTextLabel
            // 
            this.infoTextLabel.AutoSize = true;
            this.infoTextLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoTextLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.infoTextLabel.Location = new System.Drawing.Point(3, 20);
            this.infoTextLabel.Name = "infoTextLabel";
            this.infoTextLabel.Size = new System.Drawing.Size(254, 60);
            this.infoTextLabel.TabIndex = 2;
            this.infoTextLabel.Text = "Question";
            this.infoTextLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // closeButton
            // 
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.Image = global::ChatterBox.Client.WinForms.Properties.Resources.CloseX;
            this.closeButton.InitialImage = null;
            this.closeButton.Location = new System.Drawing.Point(240, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 20);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 0;
            this.closeButton.TabStop = false;
            // 
            // buttonsLayoutPanel
            // 
            this.buttonsLayoutPanel.ColumnCount = 2;
            this.buttonsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsLayoutPanel.Controls.Add(this.noButton, 0, 0);
            this.buttonsLayoutPanel.Controls.Add(this.yesButton, 1, 0);
            this.buttonsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsLayoutPanel.Location = new System.Drawing.Point(0, 80);
            this.buttonsLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonsLayoutPanel.Name = "buttonsLayoutPanel";
            this.buttonsLayoutPanel.RowCount = 1;
            this.buttonsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsLayoutPanel.Size = new System.Drawing.Size(260, 40);
            this.buttonsLayoutPanel.TabIndex = 3;
            // 
            // noButton
            // 
            this.noButton.AutoSize = true;
            this.noButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.noButton.ForeColor = System.Drawing.Color.Green;
            this.noButton.Location = new System.Drawing.Point(3, 0);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(124, 40);
            this.noButton.TabIndex = 0;
            this.noButton.Text = "No";
            this.noButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.noButton.Click += new System.EventHandler(this.NoButton_Click);
            this.noButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.noButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // yesButton
            // 
            this.yesButton.AutoSize = true;
            this.yesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yesButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.yesButton.ForeColor = System.Drawing.Color.Green;
            this.yesButton.Location = new System.Drawing.Point(133, 0);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(124, 40);
            this.yesButton.TabIndex = 1;
            this.yesButton.Text = "Yes";
            this.yesButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.yesButton.Click += new System.EventHandler(this.YesButton_Click);
            this.yesButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.yesButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // SimpleYesNoSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(262, 122);
            this.Controls.Add(this.mainLayoutPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SimpleYesNoSubForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SimpleYesNoSubForm";
            this.mainLayoutPanel.ResumeLayout(false);
            this.infoLayoutPanel.ResumeLayout(false);
            this.infoLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.buttonsLayoutPanel.ResumeLayout(false);
            this.buttonsLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel infoLayoutPanel;
        private System.Windows.Forms.Label infoTextLabel;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.TableLayoutPanel buttonsLayoutPanel;
        private System.Windows.Forms.Label noButton;
        private System.Windows.Forms.Label yesButton;
    }
}