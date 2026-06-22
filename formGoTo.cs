using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Automation;

namespace MyNotes
{
    public partial class formGoTo : Form
    {
        Form fr = new Form();
        int enteredLineNumber = 0;
        int lastLineNumber;
        public formGoTo()
        {
            InitializeComponent();
        }
        public formGoTo(int line)
        {
            lastLineNumber = line;
            InitializeComponent();
        }
        public int getLine()
        {
            return enteredLineNumber;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string txt = textBox1.Text;
            int txtln = textBox1.TextLength;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGoTo(object sender, EventArgs e)
        {
            int NumLn = int.Parse(textBox1.Text);
            if (NumLn <= lastLineNumber)
            {
                enteredLineNumber = NumLn;
                btnCancel_Click(sender, e);
            }
            else
            {
                MessageBox.Show(this, "The line number is beyond the total number of lines", "line", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = (lastLineNumber + 1).ToString();
                textBox1.SelectAll();
            }
        }

        private void formGoTo_Load(object sender, EventArgs e)
        {
            textBox1.Text = (lastLineNumber).ToString();
            textBox1.SelectAll();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                lblError.Text = "Enter number!!";
                lblError.ForeColor = Color.Red;
                lblError.Visible = true;
            }
            else
            {
                lblError.Visible = false;
            }
        }
    }
}
