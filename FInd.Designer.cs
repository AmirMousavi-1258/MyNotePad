namespace MyNotes
{
    partial class FInd
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
            lblWord = new Label();
            txtWord = new TextBox();
            btnCancel = new Button();
            btnFindNx = new Button();
            grpDir = new GroupBox();
            rdiDown = new RadioButton();
            groupBox2 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            rdiUp = new RadioButton();
            button2 = new Button();
            checkBox1 = new CheckBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            grpDir.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblWord
            // 
            lblWord.AutoSize = true;
            lblWord.Location = new Point(12, 12);
            lblWord.Name = "lblWord";
            lblWord.Size = new Size(80, 20);
            lblWord.TabIndex = 1;
            lblWord.Text = "Find what :";
            // 
            // txtWord
            // 
            txtWord.Location = new Point(91, 9);
            txtWord.Name = "txtWord";
            txtWord.Size = new Size(249, 27);
            txtWord.TabIndex = 2;
            txtWord.TextChanged += txtWord_TextChanged;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(352, 55);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnFindNx
            // 
            btnFindNx.DialogResult = DialogResult.OK;
            btnFindNx.Enabled = false;
            btnFindNx.Location = new Point(352, 7);
            btnFindNx.Name = "btnFindNx";
            btnFindNx.Size = new Size(94, 29);
            btnFindNx.TabIndex = 0;
            btnFindNx.Text = "Find next";
            btnFindNx.UseVisualStyleBackColor = true;
            btnFindNx.Click += btnFindNx_Click;
            // 
            // grpDir
            // 
            grpDir.Controls.Add(rdiDown);
            grpDir.Controls.Add(groupBox2);
            grpDir.Controls.Add(rdiUp);
            grpDir.Controls.Add(button2);
            grpDir.Location = new Point(201, 55);
            grpDir.Name = "grpDir";
            grpDir.Size = new Size(139, 53);
            grpDir.TabIndex = 5;
            grpDir.TabStop = false;
            grpDir.Text = "Direction";
            // 
            // rdiDown
            // 
            rdiDown.AutoSize = true;
            rdiDown.Checked = true;
            rdiDown.Location = new Point(67, 26);
            rdiDown.Name = "rdiDown";
            rdiDown.Size = new Size(69, 24);
            rdiDown.TabIndex = 8;
            rdiDown.TabStop = true;
            rdiDown.Text = "Down";
            rdiDown.UseVisualStyleBackColor = true;
            rdiDown.CheckedChanged += rdiDown_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(139, 53);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Direction";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Checked = true;
            radioButton3.Location = new Point(67, 26);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(69, 24);
            radioButton3.TabIndex = 8;
            radioButton3.TabStop = true;
            radioButton3.Text = "Down";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += rdiDown_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(6, 26);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(49, 24);
            radioButton4.TabIndex = 7;
            radioButton4.Text = "Up";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += rdiUp_CheckedChanged;
            // 
            // rdiUp
            // 
            rdiUp.AutoSize = true;
            rdiUp.Location = new Point(6, 26);
            rdiUp.Name = "rdiUp";
            rdiUp.Size = new Size(49, 24);
            rdiUp.TabIndex = 7;
            rdiUp.Text = "Up";
            rdiUp.UseVisualStyleBackColor = true;
            rdiUp.CheckedChanged += rdiUp_CheckedChanged;
            // 
            // button2
            // 
            button2.Location = new Point(151, 0);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnCancel_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 84);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(105, 24);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Match case";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.AccessibleRole = AccessibleRole.None;
            button1.AutoSize = true;
            button1.Location = new Point(352, 55);
            button1.Name = "button1";
            button1.Size = new Size(94, 30);
            button1.TabIndex = 3;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCancel_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Location = new Point(201, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(139, 53);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Direction";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(67, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(69, 24);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "Down";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += rdiDown_CheckedChanged;
            radioButton1.MouseClick += radioButton1_MouseClick;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 26);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(49, 24);
            radioButton2.TabIndex = 7;
            radioButton2.Text = "Up";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += rdiUp_CheckedChanged;
            radioButton2.MouseClick += radioButton2_MouseClick;
            // 
            // FInd
            // 
            AccessibleRole = AccessibleRole.None;
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(458, 130);
            Controls.Add(checkBox1);
            Controls.Add(groupBox1);
            Controls.Add(grpDir);
            Controls.Add(button1);
            Controls.Add(btnFindNx);
            Controls.Add(btnCancel);
            Controls.Add(txtWord);
            Controls.Add(lblWord);
            MaximizeBox = false;
            Name = "FInd";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Find";
            Load += FInd_Load;
            grpDir.ResumeLayout(false);
            grpDir.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWord;
        private TextBox txtWord;
        private Button btnCancel;
        private Button btnFindNx;
        private GroupBox grpDir;
        private RadioButton rdiDown;
        private RadioButton rdiUp;
        private GroupBox groupBox2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Button button2;
        protected CheckBox checkBox1;
        protected RadioButton radioButton1;
        protected RadioButton radioButton2;
        internal Button button1;
        internal GroupBox groupBox1;
    }
}