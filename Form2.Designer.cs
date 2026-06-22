namespace MyNotes
{
    partial class Form2
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
            panel1 = new Panel();
            btnCancel = new Button();
            btnDontSave = new Button();
            btnSave = new Button();
            mainlbl = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnDontSave);
            panel1.Controls.Add(btnSave);
            panel1.ImeMode = ImeMode.On;
            panel1.Location = new Point(4, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(466, 68);
            panel1.TabIndex = 3;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(375, 22);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(87, 29);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDontSave
            // 
            btnDontSave.DialogResult = DialogResult.OK;
            btnDontSave.Location = new Point(258, 22);
            btnDontSave.Name = "btnDontSave";
            btnDontSave.Size = new Size(107, 29);
            btnDontSave.TabIndex = 4;
            btnDontSave.Text = "Don't Save";
            btnDontSave.UseVisualStyleBackColor = true;
            btnDontSave.Click += btnDontSave_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(157, 22);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 29);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // mainlbl
            // 
            mainlbl.AutoSize = true;
            mainlbl.Font = new Font("Tahoma", 10.8F);
            mainlbl.ForeColor = Color.DarkBlue;
            mainlbl.Location = new Point(10, 29);
            mainlbl.MaximumSize = new Size(370, 66);
            mainlbl.Name = "mainlbl";
            mainlbl.Size = new Size(266, 22);
            mainlbl.TabIndex = 4;
            mainlbl.Text = "Do you want to save changes to";
            // 
            // Form2
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ButtonFace;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(472, 168);
            Controls.Add(mainlbl);
            Controls.Add(panel1);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MyNote";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnCancel;
        private Button btnDontSave;
        private Button btnSave;
        private Label mainlbl;
    }
}