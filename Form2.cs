using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MyNotes
{
    public partial class Form2 : Form
    {
        Form1 frm1 = new Form1();
        TextBox textBox1=new TextBox();
        static string buttonName;
        static string name = "Untitled.txt";
        public Form2(Form1 fr,TextBox txtBox,string BName = "Exit",string Name = "Untitled.txt")
        {
            InitializeComponent();
            name = Name;
            frm1 = fr;
            textBox1 = txtBox;
            buttonName = BName;
        }
        public string getName()
        {
            return name;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            mainlbl.Text = "Do you want to save changes to " + name + "?";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Need To Change

            SaveFileDialog saveDi = new SaveFileDialog();
            saveDi.Title = "Save as";
            saveDi.FileName = name;
            saveDi.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)| *.*";
            if (saveDi.ShowDialog() == DialogResult.OK)
            {
                name = saveDi.FileName;
                StreamWriter mainFile = File.CreateText(name);
                mainFile.WriteLine(textBox1.Text);
                mainFile.Close();
                if (buttonName == "TSMINew")
                {
                    textBox1.Text = "";
                    frm1.setInformSave("", false, true);
                    this.Close();
                }
                else if (buttonName == "TSMIOpen")
                {
                    OpenFileDialog openDi = new OpenFileDialog();
                    if (openDi.ShowDialog() == DialogResult.OK)
                    {
                        name = openDi.FileName;
                        StreamReader readFile = File.OpenText(name);
                        textBox1.Text = readFile.ReadToEnd();
                        frm1.setInformSave(name, true, true);
                        readFile.Close();
                    }
                    this.Close();
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                }
            }

        }

        private void btnDontSave_Click(object sender, EventArgs e)
        {
            if(buttonName == "TSMIOpen")
            {
                OpenFileDialog openDi = new OpenFileDialog();
                if(openDi.ShowDialog() == DialogResult.OK)
                {
                    name = openDi.FileName;
                    StreamReader readFile = File.OpenText(name);
                    textBox1.Text = readFile.ReadToEnd();
                    frm1.setInformSave(name, true,true);
                    readFile.Close();
                }
            }
            else if(buttonName == "TSMINew")
            {
                textBox1.Text = "";
                frm1.setInformSave("",false,true);
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
