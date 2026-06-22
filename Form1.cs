using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Xml.Linq;

namespace MyNotes
{

    public partial class Form1 : Form
    {
        MainMethodes mMethods = new MainMethodes();
        // Save
        static string filePathName;
        static bool isPathSet = false;
        static bool isSave = true;
        // Goto
        static int numLN = 0;
        // Find
        static string characterFind;
        static bool IsUp = false;
        static bool checkCase = false;
        public Form1()
        {
            InitializeComponent();
        }
        void changedFont(Font fn)
        {
            Maintxt.Font = fn;
        }
        void setName(string fileName)
        {
            if (fileName != null)
            {
                string justName = fileName.Substring(fileName.LastIndexOf('\\') + 1);
                string justPath = fileName.Remove(fileName.LastIndexOf('\\'));
                this.Text = justName + " - MyNotes";
            }
            else
            {
                this.Text = "Untitled.txt - MyNotes";

            }
        }
        string getName(string fileName)
        {
            if (fileName != null)
            {
                //string justName = fileName.Substring(fileName.LastIndexOf('\\') + 1);
                //string justPath = fileName.Remove(fileName.LastIndexOf('\\'));
                return fileName;
            }
            else
            {
                return "Untitled.txt";

            }
        }
        public int getLine1()
        {
            return numLN;
        }
        public void setInformFind(string chrFind, bool chCase, bool isUp)
        {
            checkCase = chCase;
            characterFind = chrFind;
            IsUp = isUp;
        }
        public void setInformSave(string path, bool set, bool save)
        {
            filePathName = path;
            isSave = save;
            isPathSet = set;
        }
        public int FindCharacter(TextBox txtBox)
        {
            int startF = (txtBox.SelectionStart + txtBox.SelectionLength);
            int startE = (txtBox.SelectionStart);
            int ind;
            if (!checkCase)
            {
                if (IsUp)
                {
                    ind = mMethods.findEnd(characterFind.ToLower(), txtBox.Text.ToLower(), startE - 1);
                }
                else
                {
                    ind = mMethods.findFirst(characterFind.ToLower(), txtBox.Text.ToLower(), startF);
                }
            }
            else
            {
                if (IsUp)
                {
                    ind = mMethods.findEnd(characterFind, txtBox.Text, startE - 1);
                }
                else
                {
                    ind = mMethods.findFirst(characterFind, txtBox.Text, startF);
                }
            }
            if (ind == -1)
            {
                MessageBox.Show(this, "Cannot find '" + characterFind + "'", "MyNotes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else
            {
                return ind;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Maintxt.Font = mMethods.getFont("mainFile.txt");
            setName(filePathName);
        }
        private void Form1_Close(object sender, EventArgs e)
        {
            Font fn = Maintxt.Font;
            string fnFA = fn.FontFamily.Name;
            string fnSI = fn.Size.ToString();
            string fnST = fn.Style.ToString();
            StreamWriter file = File.CreateText("mainFile.txt");
            file.WriteLine(fnFA);
            file.WriteLine(fnSI);
            file.WriteLine(fnST);
            file.Close();
        }
        private void TSMIWordWrap_Click(object sender, EventArgs e)
        {
            TSMIWordWrap.Checked = !(TSMIWordWrap.Checked);
        }
        private void TSMIWordWrap_CheckedChanged(object sender, EventArgs e)
        {
            if (TSMIWordWrap.Checked)
            {
                Maintxt.WordWrap = true;
                Maintxt.ScrollBars = ScrollBars.Vertical;
                TSMIStatusBar.Enabled = false;

            }
            else
            {
                Maintxt.WordWrap = false;
                Maintxt.ScrollBars = ScrollBars.Both;
                TSMIStatusBar.Enabled = true;

            }
        }

        private void TSMIFont_Click(object sender, EventArgs e)
        {
            FontDialog fnDialog = new FontDialog();
            fnDialog.Font = Maintxt.Font;
            Font fn = null;
            if (fnDialog.ShowDialog() == DialogResult.OK)
            {
                fn = fnDialog.Font;
                Maintxt.Font = fn;
                StreamWriter mainFile = File.CreateText("mainFile.txt");
                mainFile.WriteLine(fn.FontFamily.Name);
                mainFile.WriteLine(fn.Size.ToString());
                mainFile.WriteLine(fn.Style.ToString());
                mainFile.Close();
            }
        }

        private void Maintxt_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (Maintxt.SelectionLength > 0)
            {
                TSMICut.Enabled = true;
                TSMICopy.Enabled = true;
                TSMIDel.Enabled = true;
            }
            else
            {
                TSMICut.Enabled = false;
                TSMICopy.Enabled = false;
                TSMIDel.Enabled = false;
            }
        }

        private void TSMIExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TSMIPrint_Click(object sender, EventArgs e)
        {
            PrintDialog prn = new PrintDialog();
            prn.ShowDialog();
        }

        private void TSMISetupPage_Click(object sender, EventArgs e)
        {
            PageSetupDialog pgSe = new PageSetupDialog();
            pgSe.ShowDialog();
        }

        private void TSMISaveAs_Click(object sender, EventArgs e)
        {
            // Need To Change
            SaveFileDialog folderDi = new SaveFileDialog();
            folderDi.FileName = (filePathName == null) ? "New Text Document.txt" : filePathName;
            folderDi.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)| *.*";
            if (folderDi.ShowDialog() == DialogResult.OK)
            {
                string fiName = folderDi.FileName;
                StreamWriter mainFile = File.CreateText(fiName);
                mainFile.Write(Maintxt.Text);
                mainFile.Close();
                filePathName = folderDi.FileName;
                isPathSet = true;
                isSave = true;
                setName(filePathName);
            }
        }

        private void TSMIOpen_Click(object sender, EventArgs e)
        {
            // Need To Change
            if (isSave)
            {
                OpenFileDialog openDi = new OpenFileDialog();
                openDi.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)| *.*";
                if (openDi.ShowDialog() == DialogResult.OK)
                {
                    string fiName = openDi.FileName;
                    StreamReader mainFile = File.OpenText(fiName);
                    Maintxt.Text = mainFile.ReadToEnd();
                    filePathName = fiName;
                    isPathSet = true;
                    isSave = true;
                    setName(filePathName);
                    mainFile.Close();
                }
            }
            else
            {
                Form2 frm2 = new Form2(this, Maintxt, TSMIOpen.Name, (filePathName != null) ? filePathName : "Untitled.txt");
                frm2.ShowDialog();
                setName(filePathName);
            }
        }

        private void TSMIViewHelp_Click(object sender, EventArgs e)
        {
            StreamReader mainFile = File.OpenText("mainFile.txt");
            string s1 = mainFile.ReadLine();
            string s2 = mainFile.ReadLine();
            string s3 = mainFile.ReadLine();
            mainFile.Close();
            MessageBox.Show(this, s1 + "," + s2 + "," + s3);
            //string fiName = @"C:\first\second\main.txt";
            //string justName = fiName.Substring(fiName.LastIndexOf("\\")+1);
            //string justPath = fiName.Remove(fiName.LastIndexOf('\\')+1);
            //MessageBox.Show(this, justPath + "\n" + justName);
        }

        private void TSMICut_Click(object sender, EventArgs e)
        {
            Maintxt.Cut();
        }

        private void TSMICopy_Click(object sender, EventArgs e)
        {
            Maintxt.Copy();
        }

        private void TSMIPaste_Click(object sender, EventArgs e)
        {
            Maintxt.Paste();
        }

        private void TSMIDel_Click(object sender, EventArgs e)
        {
            Maintxt.SelectedText = "";
        }

        private void TSMISelectAll_Click(object sender, EventArgs e)
        {
            Maintxt.SelectAll();
        }

        private void TSMITimeDate_Click(object sender, EventArgs e)
        {
            Maintxt.Text += DateTime.Now.ToString();
        }

        private void TSMIUndo_Click(object sender, EventArgs e)
        {
            Maintxt.Undo();
        }

        private void TSMIAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBx = new AboutBox1();
            aboutBx.ShowDialog();
        }

        private void TSMINew_Click(object sender, EventArgs e)
        {
            if (!isSave)
            {
                if (!isPathSet)
                {
                    Form2 frm2 = new Form2(this, Maintxt, TSMINew.Name);
                    frm2.ShowDialog();
                }
                else
                {
                    Form2 frm2 = new Form2(this, Maintxt, TSMINew.Name, filePathName);
                    frm2.ShowDialog();
                }
                setName(filePathName);
            }
            else if (isSave)
            {
                if (isPathSet)
                {
                    Form2 frm2 = new Form2(this, Maintxt, TSMINew.Name, filePathName);
                    frm2.ShowDialog();
                    setName(filePathName);
                }
            }
        }

        private void TSMIStatusBar_Click(object sender, EventArgs e)
        {
            TSMIStatusBar.Checked = !TSMIStatusBar.Checked;
            if (TSMIStatusBar.Checked)
            {
                statusBar1.Visible = true;
                TSMIGoTo.Enabled = true;
                int line = Maintxt.GetLineFromCharIndex(Maintxt.SelectionStart) + 1;
                int col = mMethods.getCol(Maintxt.Text, Maintxt.SelectionStart);
                lblTSS.Text = $"Line {line} Col{col} char {Maintxt.SelectionStart}";
            }
            else
            {
                statusBar1.Visible = false;
                TSMIGoTo.Enabled = false;
            }
        }

        private void TSMIGoTo_Click(object sender, EventArgs e)
        {
            formGoTo frmGoTo = new formGoTo(numLN + 1);
            frmGoTo.ShowDialog();
            int numline;
            if ((numline = frmGoTo.getLine()) > 0)
            {
                Maintxt.SelectionStart = Maintxt.GetFirstCharIndexFromLine(numline - 1);
                Maintxt.ScrollToCaret();
            }
        }

        private void Maintxt_TextChanged(object sender, EventArgs e)
        {
            numLN = Maintxt.GetLineFromCharIndex(Maintxt.SelectionStart);
            isSave = false;
            int line = Maintxt.GetLineFromCharIndex(Maintxt.SelectionStart) + 1;
            int col = mMethods.getCol(Maintxt.Text, Maintxt.SelectionStart);
            lblTSS.Text = $"Line {line} Col{col} char {Maintxt.SelectionStart}";
        }

        private void TSMIFind_Click(object sender, EventArgs e)
        {
            FInd find = new FInd(this, Maintxt);
            find.Show(this);
        }

        private void TSMIFindNext_Click(object sender, EventArgs e)
        {
            if (characterFind == null)
            {
                TSMIFind_Click(sender, e);
            }
            else
            {
                int ind;
                if ((ind = FindCharacter(Maintxt)) != -1)
                {
                    Maintxt.Select(ind, characterFind.Length);
                }
            }
        }

        private void TSMISave_Click(object sender, EventArgs e)
        {

            if (isPathSet)
            {
                if (!isSave)
                {
                    // Need To Change
                    StreamWriter mainFile = File.CreateText(filePathName);
                    mainFile.WriteLine(Maintxt.Text);
                    mainFile.Close();
                    isSave = true;
                }
            }
            else
            {
                TSMISaveAs_Click(sender, e);
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSave)
            {
                Form2 frm2 = new Form2(this, Maintxt, "Exit", getName(filePathName));
                if (frm2.ShowDialog() == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }

            }
        }

        private void TSMIReplace_Click(object sender, EventArgs e)
        {
            Replace replace = new Replace(characterFind, this);
            replace.Show(this);
        }

        private void themeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog(); 
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                Maintxt.BackColor = colorDialog.Color;
            }
        }

        private void moreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color txtcolor;
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog(this) == DialogResult.OK)
            {
                txtcolor = colorDialog.Color;
                Maintxt.ForeColor = txtcolor;
                foreach (ToolStripMenuItem item in textColorToolStripMenuItem.DropDownItems)
                {
                    item.Checked = false;
                }
            }

        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maintxt.ForeColor = Color.Blue;
            foreach(ToolStripMenuItem item in textColorToolStripMenuItem.DropDownItems)
            {
                item.Checked = false;
                if(item == blueToolStripMenuItem)
                {
                    item.Checked = true;
                }
            }
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maintxt.ForeColor = Color.Red;
            redToolStripMenuItem.Checked = true;
            foreach (ToolStripMenuItem item in textColorToolStripMenuItem.DropDownItems)
            {
                item.Checked = false;
                if (item == redToolStripMenuItem)
                {
                    item.Checked = true;
                }
            }
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maintxt.ForeColor= Color.Black;
            blackToolStripMenuItem.Checked = true;
            foreach (ToolStripMenuItem item in textColorToolStripMenuItem.DropDownItems)
            {
                item.Checked = false;
                if (item == blackToolStripMenuItem)
                {
                    item.Checked = true;
                }
            }
        }
    }
}
