namespace ChatterBox.Client.WinForms.SubForms
{
    partial class SearchSubForm
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
            this.searchMainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.PictureBox();
            this.searchMainLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
            this.SuspendLayout();
            // 
            // searchMainLayoutPanel
            // 
            this.searchMainLayoutPanel.BackColor = System.Drawing.SystemColors.Window;
            this.searchMainLayoutPanel.ColumnCount = 2;
            this.searchMainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.searchMainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.searchMainLayoutPanel.Controls.Add(this.searchBox, 0, 0);
            this.searchMainLayoutPanel.Controls.Add(this.searchButton, 1, 0);
            this.searchMainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchMainLayoutPanel.Location = new System.Drawing.Point(1, 1);
            this.searchMainLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.searchMainLayoutPanel.Name = "searchMainLayoutPanel";
            this.searchMainLayoutPanel.RowCount = 1;
            this.searchMainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.searchMainLayoutPanel.Size = new System.Drawing.Size(238, 38);
            this.searchMainLayoutPanel.TabIndex = 0;
            // 
            // searchBox
            // 
            this.searchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchBox.Location = new System.Drawing.Point(5, 10);
            this.searchBox.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(198, 20);
            this.searchBox.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(208, 0);
            this.searchButton.Margin = new System.Windows.Forms.Padding(0);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(30, 38);
            this.searchButton.TabIndex = 1;
            this.searchButton.TabStop = false;
            // 
            // SearchSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(240, 40);
            this.Controls.Add(this.searchMainLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchSubForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SearchSubForm";
            this.searchMainLayoutPanel.ResumeLayout(false);
            this.searchMainLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel searchMainLayoutPanel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.PictureBox searchButton;
    }
}