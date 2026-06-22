namespace MyNotes
{
    partial class AboutBox1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            tableLayoutPanel = new TableLayoutPanel();
            logoPictureBox = new PictureBox();
            labelProductName = new Label();
            labelVersion = new Label();
            labelCopyright = new Label();
            textBoxDescription = new TextBox();
            okButton = new Button();
            pictureBox1 = new PictureBox();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel.Controls.Add(logoPictureBox, 0, 0);
            tableLayoutPanel.Controls.Add(labelProductName, 1, 0);
            tableLayoutPanel.Controls.Add(labelVersion, 1, 1);
            tableLayoutPanel.Controls.Add(labelCopyright, 1, 2);
            tableLayoutPanel.Controls.Add(textBoxDescription, 1, 3);
            tableLayoutPanel.Controls.Add(okButton, 1, 4);
            tableLayoutPanel.Location = new Point(12, 103);
            tableLayoutPanel.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 5;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.5263176F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.5263176F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 17.5438557F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 43.8596535F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 17.5438557F));
            tableLayoutPanel.Size = new Size(556, 318);
            tableLayoutPanel.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Dock = DockStyle.Fill;
            logoPictureBox.Location = new Point(4, 5);
            logoPictureBox.Margin = new Padding(4, 5, 4, 5);
            logoPictureBox.Name = "logoPictureBox";
            tableLayoutPanel.SetRowSpan(logoPictureBox, 5);
            logoPictureBox.Size = new Size(75, 308);
            logoPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            logoPictureBox.TabIndex = 12;
            logoPictureBox.TabStop = false;
            // 
            // labelProductName
            // 
            labelProductName.Dock = DockStyle.Fill;
            labelProductName.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelProductName.Location = new Point(91, 0);
            labelProductName.Margin = new Padding(8, 0, 4, 0);
            labelProductName.MaximumSize = new Size(0, 26);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(461, 26);
            labelProductName.TabIndex = 19;
            labelProductName.Text = "My Note";
            labelProductName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelVersion
            // 
            labelVersion.Dock = DockStyle.Fill;
            labelVersion.Location = new Point(91, 33);
            labelVersion.Margin = new Padding(8, 0, 4, 0);
            labelVersion.MaximumSize = new Size(0, 26);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(461, 26);
            labelVersion.TabIndex = 0;
            labelVersion.Text = "Version 1.00";
            labelVersion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelCopyright
            // 
            labelCopyright.Dock = DockStyle.Fill;
            labelCopyright.Location = new Point(91, 66);
            labelCopyright.Margin = new Padding(8, 0, 4, 0);
            labelCopyright.MaximumSize = new Size(0, 26);
            labelCopyright.Name = "labelCopyright";
            labelCopyright.Size = new Size(461, 26);
            labelCopyright.TabIndex = 21;
            labelCopyright.Text = "Amir Mousavi";
            labelCopyright.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxDescription
            // 
            textBoxDescription.BackColor = SystemColors.Info;
            textBoxDescription.BorderStyle = BorderStyle.None;
            textBoxDescription.Dock = DockStyle.Fill;
            textBoxDescription.Location = new Point(91, 126);
            textBoxDescription.Margin = new Padding(8, 5, 4, 5);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ReadOnly = true;
            textBoxDescription.Size = new Size(461, 129);
            textBoxDescription.TabIndex = 23;
            textBoxDescription.TabStop = false;
            textBoxDescription.Text = "Description";
            // 
            // okButton
            // 
            okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okButton.AutoSize = true;
            okButton.DialogResult = DialogResult.Cancel;
            okButton.Location = new Point(472, 283);
            okButton.Margin = new Padding(4, 5, 4, 5);
            okButton.Name = "okButton";
            okButton.Size = new Size(80, 30);
            okButton.TabIndex = 24;
            okButton.Text = "&OK";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(556, 87);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // AboutBox1
            // 
            AcceptButton = okButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(580, 435);
            Controls.Add(pictureBox1);
            Controls.Add(tableLayoutPanel);
            Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutBox1";
            Padding = new Padding(12, 14, 12, 14);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "About";
            Load += AboutBox1_Load;
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button okButton;
        private PictureBox logoPictureBox;
        private PictureBox pictureBox1;
    }
}
