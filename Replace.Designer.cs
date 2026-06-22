namespace MyNotes
{
    partial class Replace
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
            label1 = new Label();
            label2 = new Label();
            btnFind = new Button();
            btnReplace = new Button();
            btnReplaceAll = new Button();
            btnCancel = new Button();
            txtBoxReplace = new TextBox();
            txtBoxFind = new TextBox();
            chbxMatchCase = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 7.8F);
            label1.Location = new Point(4, 26);
            label1.Name = "label1";
            label1.Size = new Size(74, 16);
            label1.TabIndex = 0;
            label1.Text = "Find What :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 7.8F);
            label2.Location = new Point(4, 59);
            label2.Name = "label2";
            label2.Size = new Size(91, 16);
            label2.TabIndex = 1;
            label2.Text = "Replace With :";
            // 
            // btnFind
            // 
            btnFind.Enabled = false;
            btnFind.Font = new Font("Tahoma", 7.8F);
            btnFind.Location = new Point(345, 15);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(94, 27);
            btnFind.TabIndex = 2;
            btnFind.Text = "Find Next";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // btnReplace
            // 
            btnReplace.Enabled = false;
            btnReplace.Font = new Font("Tahoma", 7.8F);
            btnReplace.Location = new Point(345, 48);
            btnReplace.Name = "btnReplace";
            btnReplace.Size = new Size(94, 27);
            btnReplace.TabIndex = 3;
            btnReplace.Text = "Replace";
            btnReplace.UseVisualStyleBackColor = true;
            btnReplace.Click += btnReplace_Click;
            // 
            // btnReplaceAll
            // 
            btnReplaceAll.Enabled = false;
            btnReplaceAll.Font = new Font("Tahoma", 7.8F);
            btnReplaceAll.Location = new Point(345, 81);
            btnReplaceAll.Name = "btnReplaceAll";
            btnReplaceAll.Size = new Size(94, 27);
            btnReplaceAll.TabIndex = 4;
            btnReplaceAll.Text = "Replace All";
            btnReplaceAll.UseVisualStyleBackColor = true;
            btnReplaceAll.Click += btnReplaceAll_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Tahoma", 7.8F);
            btnCancel.Location = new Point(345, 114);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 27);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtBoxReplace
            // 
            txtBoxReplace.Font = new Font("Tahoma", 7.8F);
            txtBoxReplace.Location = new Point(104, 50);
            txtBoxReplace.Name = "txtBoxReplace";
            txtBoxReplace.Size = new Size(232, 23);
            txtBoxReplace.TabIndex = 6;
            txtBoxReplace.TextChanged += txtBoxReplace_TextChanged;
            // 
            // txtBoxFind
            // 
            txtBoxFind.Font = new Font("Tahoma", 7.8F);
            txtBoxFind.Location = new Point(104, 17);
            txtBoxFind.Name = "txtBoxFind";
            txtBoxFind.Size = new Size(232, 23);
            txtBoxFind.TabIndex = 7;
            txtBoxFind.TextChanged += txtBoxFind_TextChanged;
            // 
            // chbxMatchCase
            // 
            chbxMatchCase.AutoSize = true;
            chbxMatchCase.Font = new Font("Tahoma", 7.8F);
            chbxMatchCase.Location = new Point(12, 121);
            chbxMatchCase.Name = "chbxMatchCase";
            chbxMatchCase.Size = new Size(93, 20);
            chbxMatchCase.TabIndex = 8;
            chbxMatchCase.Text = "Match case";
            chbxMatchCase.UseVisualStyleBackColor = true;
            chbxMatchCase.CheckedChanged += chbxMatchCase_CheckedChanged;
            // 
            // Replace
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 160);
            Controls.Add(chbxMatchCase);
            Controls.Add(txtBoxFind);
            Controls.Add(txtBoxReplace);
            Controls.Add(btnCancel);
            Controls.Add(btnReplaceAll);
            Controls.Add(btnReplace);
            Controls.Add(btnFind);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Replace";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Replace";
            Load += Replace_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label label1;
        private Label label2;
        private Button btnFind;
        private Button btnReplace;
        private Button btnReplaceAll;
        private Button btnCancel;
        private TextBox txtBoxReplace;
        private TextBox txtBoxFind;
        private CheckBox chbxMatchCase;
    }
}