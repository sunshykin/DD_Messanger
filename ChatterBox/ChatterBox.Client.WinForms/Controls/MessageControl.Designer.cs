using System.Windows.Forms;

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
            this.deleteButton = new System.Windows.Forms.PictureBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.avatarBox = new System.Windows.Forms.PictureBox();
            this.bodyLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.messageTextLabel = new System.Windows.Forms.Label();
            this.showAttachsLabel = new System.Windows.Forms.LinkLabel();
            this.imageLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.image1Box = new System.Windows.Forms.PictureBox();
            this.image2Box = new System.Windows.Forms.PictureBox();
            this.image3Box = new System.Windows.Forms.PictureBox();
            this.mainLayoutPanel.SuspendLayout();
            this.dateLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).BeginInit();
            this.bodyLayoutPanel.SuspendLayout();
            this.imageLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image1Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image2Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image3Box)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.AutoSize = true;
            this.mainLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
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
            this.mainLayoutPanel.MinimumSize = new System.Drawing.Size(420, 50);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 1;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(420, 69);
            this.mainLayoutPanel.TabIndex = 0;
            this.mainLayoutPanel.MouseEnter += new System.EventHandler(this.Message_MouseEnter);
            this.mainLayoutPanel.MouseLeave += new System.EventHandler(this.Message_MouseLeave);
            // 
            // dateLayoutPanel
            // 
            this.dateLayoutPanel.AutoSize = true;
            this.dateLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dateLayoutPanel.Controls.Add(this.deleteButton);
            this.dateLayoutPanel.Controls.Add(this.dateLabel);
            this.dateLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateLayoutPanel.Location = new System.Drawing.Point(343, 3);
            this.dateLayoutPanel.Name = "dateLayoutPanel";
            this.dateLayoutPanel.Size = new System.Drawing.Size(74, 63);
            this.dateLayoutPanel.TabIndex = 1;
            this.dateLayoutPanel.MouseEnter += new System.EventHandler(this.Date_MouseEnter);
            this.dateLayoutPanel.MouseLeave += new System.EventHandler(this.Date_MouseLeave);
            // 
            // deleteButton
            // 
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteButton.Image = global::ChatterBox.Client.WinForms.Properties.Resources.DeleteActive;
            this.deleteButton.Location = new System.Drawing.Point(0, 0);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Padding = new System.Windows.Forms.Padding(22, 7, 22, 7);
            this.deleteButton.Size = new System.Drawing.Size(74, 44);
            this.deleteButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deleteButton.TabIndex = 1;
            this.deleteButton.TabStop = false;
            this.deleteButton.Visible = false;
            this.deleteButton.MouseEnter += new System.EventHandler(this.DeleteButton_MouseEnter);
            this.deleteButton.MouseLeave += new System.EventHandler(this.DeleteButton_MouseLeave);
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(3, 47);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(3);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(30, 13);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Date";
            this.dateLabel.MouseEnter += new System.EventHandler(this.Date_MouseEnter);
            this.dateLabel.MouseLeave += new System.EventHandler(this.Date_MouseLeave);
            // 
            // avatarBox
            // 
            this.avatarBox.Location = new System.Drawing.Point(3, 3);
            this.avatarBox.Name = "avatarBox";
            this.avatarBox.Size = new System.Drawing.Size(34, 34);
            this.avatarBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarBox.TabIndex = 0;
            this.avatarBox.TabStop = false;
            this.avatarBox.MouseEnter += new System.EventHandler(this.Message_MouseEnter);
            this.avatarBox.MouseLeave += new System.EventHandler(this.Message_MouseLeave);
            // 
            // bodyLayoutPanel
            // 
            this.bodyLayoutPanel.AutoSize = true;
            this.bodyLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bodyLayoutPanel.ColumnCount = 1;
            this.bodyLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bodyLayoutPanel.Controls.Add(this.userNameLabel, 0, 0);
            this.bodyLayoutPanel.Controls.Add(this.messageTextLabel, 0, 1);
            this.bodyLayoutPanel.Controls.Add(this.showAttachsLabel, 0, 2);
            this.bodyLayoutPanel.Controls.Add(this.imageLayoutPanel, 0, 3);
            this.bodyLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyLayoutPanel.Location = new System.Drawing.Point(43, 3);
            this.bodyLayoutPanel.MinimumSize = new System.Drawing.Size(294, 44);
            this.bodyLayoutPanel.Name = "bodyLayoutPanel";
            this.bodyLayoutPanel.RowCount = 4;
            this.bodyLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.bodyLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bodyLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.bodyLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.bodyLayoutPanel.Size = new System.Drawing.Size(294, 63);
            this.bodyLayoutPanel.TabIndex = 2;
            this.bodyLayoutPanel.MouseEnter += new System.EventHandler(this.Message_MouseEnter);
            this.bodyLayoutPanel.MouseLeave += new System.EventHandler(this.Message_MouseLeave);
            // 
            // userNameLabel
            // 
            this.userNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameLabel.Location = new System.Drawing.Point(0, 0);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.userNameLabel.Size = new System.Drawing.Size(294, 20);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "UserName";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userNameLabel.MouseEnter += new System.EventHandler(this.Message_MouseEnter);
            this.userNameLabel.MouseLeave += new System.EventHandler(this.Message_MouseLeave);
            // 
            // messageTextLabel
            // 
            this.messageTextLabel.AutoSize = true;
            this.messageTextLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageTextLabel.Location = new System.Drawing.Point(0, 20);
            this.messageTextLabel.Margin = new System.Windows.Forms.Padding(0);
            this.messageTextLabel.MinimumSize = new System.Drawing.Size(281, 18);
            this.messageTextLabel.Name = "messageTextLabel";
            this.messageTextLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 2);
            this.messageTextLabel.Size = new System.Drawing.Size(294, 43);
            this.messageTextLabel.TabIndex = 1;
            this.messageTextLabel.Text = "MessageText";
            this.messageTextLabel.MouseEnter += new System.EventHandler(this.Message_MouseEnter);
            this.messageTextLabel.MouseLeave += new System.EventHandler(this.Message_MouseLeave);
            // 
            // showAttachsLabel
            // 
            this.showAttachsLabel.AutoSize = true;
            this.showAttachsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showAttachsLabel.Location = new System.Drawing.Point(0, 63);
            this.showAttachsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.showAttachsLabel.Name = "showAttachsLabel";
            this.showAttachsLabel.Size = new System.Drawing.Size(294, 1);
            this.showAttachsLabel.TabIndex = 2;
            this.showAttachsLabel.TabStop = true;
            this.showAttachsLabel.Text = "Total 3 items...";
            this.showAttachsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showAttachsLabel.MouseEnter += new System.EventHandler(this.SelectingItem_MouseEnter);
            this.showAttachsLabel.MouseLeave += new System.EventHandler(this.SelectingItem_MouseLeave);
            // 
            // imageLayoutPanel
            // 
            this.imageLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imageLayoutPanel.ColumnCount = 5;
            this.imageLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.imageLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.imageLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.imageLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.imageLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.imageLayoutPanel.Controls.Add(this.image1Box, 1, 0);
            this.imageLayoutPanel.Controls.Add(this.image2Box, 2, 0);
            this.imageLayoutPanel.Controls.Add(this.image3Box, 3, 0);
            this.imageLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageLayoutPanel.Location = new System.Drawing.Point(0, 63);
            this.imageLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.imageLayoutPanel.Name = "imageLayoutPanel";
            this.imageLayoutPanel.RowCount = 1;
            this.imageLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.imageLayoutPanel.Size = new System.Drawing.Size(294, 1);
            this.imageLayoutPanel.TabIndex = 3;
            this.imageLayoutPanel.MouseEnter += new System.EventHandler(this.Message_MouseEnter);
            this.imageLayoutPanel.MouseLeave += new System.EventHandler(this.Message_MouseLeave);
            // 
            // image1Box
            // 
            this.image1Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.image1Box.Location = new System.Drawing.Point(30, 0);
            this.image1Box.Margin = new System.Windows.Forms.Padding(0);
            this.image1Box.Name = "image1Box";
            this.image1Box.Padding = new System.Windows.Forms.Padding(2);
            this.image1Box.Size = new System.Drawing.Size(78, 1);
            this.image1Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image1Box.TabIndex = 0;
            this.image1Box.TabStop = false;
            this.image1Box.MouseEnter += new System.EventHandler(this.SelectingItem_MouseEnter);
            this.image1Box.MouseLeave += new System.EventHandler(this.SelectingItem_MouseLeave);
            // 
            // image2Box
            // 
            this.image2Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.image2Box.Location = new System.Drawing.Point(108, 0);
            this.image2Box.Margin = new System.Windows.Forms.Padding(0);
            this.image2Box.Name = "image2Box";
            this.image2Box.Padding = new System.Windows.Forms.Padding(2);
            this.image2Box.Size = new System.Drawing.Size(78, 1);
            this.image2Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image2Box.TabIndex = 0;
            this.image2Box.TabStop = false;
            this.image2Box.MouseEnter += new System.EventHandler(this.SelectingItem_MouseEnter);
            this.image2Box.MouseLeave += new System.EventHandler(this.SelectingItem_MouseLeave);
            // 
            // image3Box
            // 
            this.image3Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.image3Box.Location = new System.Drawing.Point(186, 0);
            this.image3Box.Margin = new System.Windows.Forms.Padding(0);
            this.image3Box.Name = "image3Box";
            this.image3Box.Padding = new System.Windows.Forms.Padding(2);
            this.image3Box.Size = new System.Drawing.Size(78, 1);
            this.image3Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image3Box.TabIndex = 0;
            this.image3Box.TabStop = false;
            this.image3Box.MouseEnter += new System.EventHandler(this.SelectingItem_MouseEnter);
            this.image3Box.MouseLeave += new System.EventHandler(this.SelectingItem_MouseLeave);
            // 
            // MessageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.mainLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(420, 50);
            this.Name = "MessageControl";
            this.Size = new System.Drawing.Size(420, 69);
            this.mainLayoutPanel.ResumeLayout(false);
            this.mainLayoutPanel.PerformLayout();
            this.dateLayoutPanel.ResumeLayout(false);
            this.dateLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).EndInit();
            this.bodyLayoutPanel.ResumeLayout(false);
            this.bodyLayoutPanel.PerformLayout();
            this.imageLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.image1Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image2Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image3Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel dateLayoutPanel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.PictureBox avatarBox;
        private System.Windows.Forms.TableLayoutPanel bodyLayoutPanel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label messageTextLabel;
        private System.Windows.Forms.PictureBox deleteButton;
        private System.Windows.Forms.LinkLabel showAttachsLabel;
        private System.Windows.Forms.TableLayoutPanel imageLayoutPanel;
        private System.Windows.Forms.PictureBox image1Box;
        private System.Windows.Forms.PictureBox image2Box;
        private System.Windows.Forms.PictureBox image3Box;
    }
}
