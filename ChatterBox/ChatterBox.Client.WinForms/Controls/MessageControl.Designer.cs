namespace ChatterBox.Client.WinForms.Controls
{
    partial class MessageControl
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
            this.dateLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.dateLabel = new System.Windows.Forms.Label();
            this.bodyLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.messageTextLabel = new System.Windows.Forms.Label();
            this.avatarBox = new System.Windows.Forms.PictureBox();
            this.mainLayoutPanel.SuspendLayout();
            this.dateLayoutPanel.SuspendLayout();
            this.bodyLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.ColumnCount = 3;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.mainLayoutPanel.Controls.Add(this.dateLayoutPanel, 2, 0);
            this.mainLayoutPanel.Controls.Add(this.avatarBox, 0, 0);
            this.mainLayoutPanel.Controls.Add(this.bodyLayoutPanel, 1, 0);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 1;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(420, 50);
            this.mainLayoutPanel.TabIndex = 0;
            // 
            // dateLayoutPanel
            // 
            this.dateLayoutPanel.Controls.Add(this.dateLabel);
            this.dateLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateLayoutPanel.Location = new System.Drawing.Point(343, 3);
            this.dateLayoutPanel.Name = "dateLayoutPanel";
            this.dateLayoutPanel.Size = new System.Drawing.Size(74, 44);
            this.dateLayoutPanel.TabIndex = 1;
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(3, 3);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(3);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(30, 13);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Date";
            // 
            // bodyLayoutPanel
            // 
            this.bodyLayoutPanel.ColumnCount = 1;
            this.bodyLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bodyLayoutPanel.Controls.Add(this.userNameLabel, 0, 0);
            this.bodyLayoutPanel.Controls.Add(this.messageTextLabel, 0, 1);
            this.bodyLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyLayoutPanel.Location = new System.Drawing.Point(43, 3);
            this.bodyLayoutPanel.Name = "bodyLayoutPanel";
            this.bodyLayoutPanel.RowCount = 2;
            this.bodyLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.bodyLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bodyLayoutPanel.Size = new System.Drawing.Size(294, 44);
            this.bodyLayoutPanel.TabIndex = 2;
            // 
            // userNameLabel
            // 
            this.userNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userNameLabel.Location = new System.Drawing.Point(10, 3);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(281, 14);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "UserName";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // messageTextLabel
            // 
            this.messageTextLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageTextLabel.Location = new System.Drawing.Point(10, 23);
            this.messageTextLabel.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.messageTextLabel.Name = "messageTextLabel";
            this.messageTextLabel.Size = new System.Drawing.Size(281, 18);
            this.messageTextLabel.TabIndex = 1;
            this.messageTextLabel.Text = "MessageText";
            // 
            // avatarBox
            // 
            this.avatarBox.Location = new System.Drawing.Point(3, 3);
            this.avatarBox.Name = "avatarBox";
            this.avatarBox.Size = new System.Drawing.Size(34, 34);
            this.avatarBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarBox.TabIndex = 0;
            this.avatarBox.TabStop = false;
            // 
            // MessageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainLayoutPanel);
            this.Name = "MessageControl";
            this.Size = new System.Drawing.Size(420, 50);
            this.mainLayoutPanel.ResumeLayout(false);
            this.dateLayoutPanel.ResumeLayout(false);
            this.dateLayoutPanel.PerformLayout();
            this.bodyLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel dateLayoutPanel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.PictureBox avatarBox;
        private System.Windows.Forms.TableLayoutPanel bodyLayoutPanel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label messageTextLabel;
    }
}
