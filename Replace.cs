using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace MyNotes
{
    public partial class Replace : Form
    {
        MainMethodes mainM = new MainMethodes();
        Form1 frm;
        string findWord = string.Empty;
        string replaceWord = string.Empty;
        int indexFind = -1;
        int indexReplace = -1;
        bool isFind = false;
        public Replace()
        {
            InitializeComponent();
        }
        public Replace(string find, Form1 form1)
        {
            frm = form1;
            findWord = find;
            InitializeComponent();
        }

        private void Replace_Load(object sender, EventArgs e)
        {
            txtBoxFind.Text = findWord;
            txtBoxReplace.Text = replaceWord;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxFind_TextChanged(object sender, EventArgs e)
        {
            findWord = txtBoxFind.Text;
            if (txtBoxFind.Text != string.Empty)
            {
                btnFind.Enabled = true;
                btnReplace.Enabled = true;
                btnReplaceAll.Enabled = true;
            }
            else
            {
                btnFind.Enabled = false;
                btnReplace.Enabled = false;
                btnReplaceAll.Enabled = false;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            frm.setInformFind(findWord, chbxMatchCase.Checked, false);
            if ((indexFind = frm.FindCharacter(frm.Maintxt)) != -1)
            {
                isFind = true;
                indexReplace = indexFind;
                frm.Activate();
                frm.Maintxt.Select(indexFind, txtBoxFind.TextLength);
                indexFind += findWord.Length - 1;
            }
            else { isFind = false; }
        }

        private void txtBoxReplace_TextChanged(object sender, EventArgs e)
        {
            replaceWord = txtBoxReplace.Text;
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (isFind)
            {
                frm.Maintxt.SelectedText = replaceWord;
                isFind = false;
            }
            else
            {
                btnFind_Click(sender, e);
            }
        }

        private void btnReplaceAll_Click(object sender, EventArgs e)
        {
            mainM.replaceAll(findWord, replaceWord, frm.Maintxt);

        }

        private void chbxMatchCase_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
