using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotes
{
    public partial class FInd : Form
    {

        static string find = "";
        static bool CHCase = false;
        static bool IsUp = true;
        Form1 fr = new Form1();
        TextBox txbx = new TextBox();
        int ind;
        public FInd()
        {
            InitializeComponent();
        }
        public FInd(Form1 frm, TextBox txtBox)
        {
            InitializeComponent();
            fr = frm;
            txbx = txtBox;
        }

        private void txtWord_TextChanged(object sender, EventArgs e)
        {
            find = txtWord.Text;
            if (txtWord.Text.Length > 0)
            {
                btnFindNx.Enabled = true;
            }
            else { btnFindNx.Enabled = false; }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdiDown_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnFindNx_Click(object sender, EventArgs e)
        {
            find = txtWord.Text;
            fr.setInformFind(find, CHCase, IsUp);
            if ((ind = fr.FindCharacter(txbx)) != -1)
            {
                fr.Activate();
                fr.Maintxt.Select(ind, find.Length);
                fr.Maintxt.SelectionStart = ind;
            }
        }

        private void rdiUp_CheckedChanged(object sender, EventArgs e)
        {
            
            
        }

        private void FInd_Load(object sender, EventArgs e)
        {
            IsUp = false;
            CHCase = false;
            txtWord.Text = find;
            txtWord.Select(0, find.Length - 1);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                CHCase = true;
            }
            else if (!checkBox1.Checked)
            {
                CHCase = false;
            }
        }

        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioButton2.Checked)
            {
                IsUp = true;
                //MessageBox.Show(this, IsUp.ToString());

            }
        }

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioButton1.Checked)
            {
                IsUp = false;
                //MessageBox.Show(this, IsUp.ToString());
            }
        }
    }
}
