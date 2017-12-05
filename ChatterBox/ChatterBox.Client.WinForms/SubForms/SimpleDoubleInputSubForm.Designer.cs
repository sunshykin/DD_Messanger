namespace ChatterBox.Client.WinForms.SubForms
{
    partial class SimpleDoubleInputSubForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.buttonsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.itemsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.item1Label = new System.Windows.Forms.Label();
            this.item2Label = new System.Windows.Forms.Label();
            this.item1TextBox = new System.Windows.Forms.TextBox();
            this.item2TextBox = new System.Windows.Forms.TextBox();
            this.mainLayoutPanel.SuspendLayout();
            this.buttonsLayoutPanel.SuspendLayout();
            this.itemsLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.BackColor = System.Drawing.SystemColors.Window;
            this.mainLayoutPanel.ColumnCount = 1;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.Controls.Add(this.titleLabel, 0, 0);
            this.mainLayoutPanel.Controls.Add(this.buttonsLayoutPanel, 0, 2);
            this.mainLayoutPanel.Controls.Add(this.itemsLayoutPanel, 0, 1);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(1, 1);
            this.mainLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 3;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(240, 150);
            this.mainLayoutPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.titleLabel.Location = new System.Drawing.Point(3, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(234, 30);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonsLayoutPanel
            // 
            this.buttonsLayoutPanel.ColumnCount = 5;
            this.buttonsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.buttonsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.buttonsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.buttonsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.buttonsLayoutPanel.Controls.Add(this.cancelButton, 1, 0);
            this.buttonsLayoutPanel.Controls.Add(this.okButton, 3, 0);
            this.buttonsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsLayoutPanel.Location = new System.Drawing.Point(0, 120);
            this.buttonsLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonsLayoutPanel.Name = "buttonsLayoutPanel";
            this.buttonsLayoutPanel.RowCount = 1;
            this.buttonsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsLayoutPanel.Size = new System.Drawing.Size(240, 30);
            this.buttonsLayoutPanel.TabIndex = 2;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.Location = new System.Drawing.Point(33, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(69, 24);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.okButton.Location = new System.Drawing.Point(138, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(69, 24);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Изменить";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // itemsLayoutPanel
            // 
            this.itemsLayoutPanel.ColumnCount = 1;
            this.itemsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.itemsLayoutPanel.Controls.Add(this.item1Label, 0, 0);
            this.itemsLayoutPanel.Controls.Add(this.item2Label, 0, 2);
            this.itemsLayoutPanel.Controls.Add(this.item1TextBox, 0, 1);
            this.itemsLayoutPanel.Controls.Add(this.item2TextBox, 0, 3);
            this.itemsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsLayoutPanel.Location = new System.Drawing.Point(0, 30);
            this.itemsLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.itemsLayoutPanel.Name = "itemsLayoutPanel";
            this.itemsLayoutPanel.RowCount = 4;
            this.itemsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.itemsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.itemsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.itemsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.itemsLayoutPanel.Size = new System.Drawing.Size(240, 90);
            this.itemsLayoutPanel.TabIndex = 3;
            // 
            // item1Label
            // 
            this.item1Label.AutoSize = true;
            this.item1Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.item1Label.Location = new System.Drawing.Point(0, 0);
            this.item1Label.Margin = new System.Windows.Forms.Padding(0);
            this.item1Label.Name = "item1Label";
            this.item1Label.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.item1Label.Size = new System.Drawing.Size(240, 20);
            this.item1Label.TabIndex = 0;
            this.item1Label.Text = "item1";
            this.item1Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // item2Label
            // 
            this.item2Label.AutoSize = true;
            this.item2Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.item2Label.Location = new System.Drawing.Point(0, 45);
            this.item2Label.Margin = new System.Windows.Forms.Padding(0);
            this.item2Label.Name = "item2Label";
            this.item2Label.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.item2Label.Size = new System.Drawing.Size(240, 20);
            this.item2Label.TabIndex = 1;
            this.item2Label.Text = "item2";
            this.item2Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // item1TextBox
            // 
            this.item1TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.item1TextBox.Location = new System.Drawing.Point(35, 22);
            this.item1TextBox.Margin = new System.Windows.Forms.Padding(35, 2, 35, 2);
            this.item1TextBox.Name = "item1TextBox";
            this.item1TextBox.Size = new System.Drawing.Size(170, 20);
            this.item1TextBox.TabIndex = 2;
            // 
            // item2TextBox
            // 
            this.item2TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.item2TextBox.Location = new System.Drawing.Point(35, 67);
            this.item2TextBox.Margin = new System.Windows.Forms.Padding(35, 2, 35, 2);
            this.item2TextBox.Name = "item2TextBox";
            this.item2TextBox.PasswordChar = '•';
            this.item2TextBox.Size = new System.Drawing.Size(170, 20);
            this.item2TextBox.TabIndex = 3;
            // 
            // SimpleDoubleInputSubForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(242, 152);
            this.Controls.Add(this.mainLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SimpleDoubleInputSubForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SimpleInputSubForm";
            this.mainLayoutPanel.ResumeLayout(false);
            this.mainLayoutPanel.PerformLayout();
            this.buttonsLayoutPanel.ResumeLayout(false);
            this.itemsLayoutPanel.ResumeLayout(false);
            this.itemsLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TableLayoutPanel buttonsLayoutPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TableLayoutPanel itemsLayoutPanel;
        private System.Windows.Forms.Label item1Label;
        private System.Windows.Forms.Label item2Label;
        private System.Windows.Forms.TextBox item1TextBox;
        private System.Windows.Forms.TextBox item2TextBox;
    }
}