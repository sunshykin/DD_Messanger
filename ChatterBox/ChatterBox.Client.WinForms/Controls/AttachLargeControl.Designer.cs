namespace ChatterBox.Client.WinForms.Controls
{
    partial class AttachLargeControl
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
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.filePictureBox = new System.Windows.Forms.PictureBox();
            this.mainLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.BackColor = System.Drawing.Color.White;
            this.mainLayoutPanel.ColumnCount = 1;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.Controls.Add(this.filePictureBox, 0, 0);
            this.mainLayoutPanel.Controls.Add(this.fileNameLabel, 0, 1);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(1, 1);
            this.mainLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 2;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(150, 180);
            this.mainLayoutPanel.TabIndex = 0;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F);
            this.fileNameLabel.Location = new System.Drawing.Point(0, 150);
            this.fileNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(150, 30);
            this.fileNameLabel.TabIndex = 1;
            this.fileNameLabel.Text = "FileName";
            this.fileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fileNameLabel.Click += new System.EventHandler(this.File_Click);
            this.fileNameLabel.DoubleClick += new System.EventHandler(this.File_DoubleClick);
            this.fileNameLabel.MouseEnter += new System.EventHandler(this.File_MouseEnter);
            this.fileNameLabel.MouseLeave += new System.EventHandler(this.File_MouseLeave);
            // 
            // filePictureBox
            // 
            this.filePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filePictureBox.Image = global::ChatterBox.Client.WinForms.Properties.Resources.File;
            this.filePictureBox.Location = new System.Drawing.Point(0, 0);
            this.filePictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.filePictureBox.Name = "filePictureBox";
            this.filePictureBox.Padding = new System.Windows.Forms.Padding(10);
            this.filePictureBox.Size = new System.Drawing.Size(150, 150);
            this.filePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.filePictureBox.TabIndex = 0;
            this.filePictureBox.TabStop = false;
            this.filePictureBox.Click += new System.EventHandler(this.File_Click);
            this.filePictureBox.DoubleClick += new System.EventHandler(this.File_DoubleClick);
            this.filePictureBox.MouseEnter += new System.EventHandler(this.File_MouseEnter);
            this.filePictureBox.MouseLeave += new System.EventHandler(this.File_MouseLeave);
            // 
            // AttachLargeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.Controls.Add(this.mainLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AttachLargeControl";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(152, 182);
            this.mainLayoutPanel.ResumeLayout(false);
            this.mainLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.PictureBox filePictureBox;
        private System.Windows.Forms.Label fileNameLabel;
    }
}
