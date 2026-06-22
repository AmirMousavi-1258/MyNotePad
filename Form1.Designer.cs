namespace MyNotes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            TSMIFile = new ToolStripMenuItem();
            TSMINew = new ToolStripMenuItem();
            TSMIOpen = new ToolStripMenuItem();
            TSMISave = new ToolStripMenuItem();
            TSMISaveAs = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            TSMISetupPage = new ToolStripMenuItem();
            TSMIPrint = new ToolStripMenuItem();
            xxToolStripMenuItem = new ToolStripSeparator();
            TSMIExit = new ToolStripMenuItem();
            TSMIEdit = new ToolStripMenuItem();
            TSMIUndo = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            TSMICut = new ToolStripMenuItem();
            TSMICopy = new ToolStripMenuItem();
            TSMIPaste = new ToolStripMenuItem();
            TSMIDel = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            TSMIFind = new ToolStripMenuItem();
            TSMIFindNext = new ToolStripMenuItem();
            TSMIReplace = new ToolStripMenuItem();
            TSMIGoTo = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            TSMISelectAll = new ToolStripMenuItem();
            TSMITimeDate = new ToolStripMenuItem();
            TSMIFormat = new ToolStripMenuItem();
            TSMIWordWrap = new ToolStripMenuItem();
            TSMIFont = new ToolStripMenuItem();
            TSMIView = new ToolStripMenuItem();
            TSMIStatusBar = new ToolStripMenuItem();
            themeToolStripMenuItem = new ToolStripMenuItem();
            textColorToolStripMenuItem = new ToolStripMenuItem();
            blackToolStripMenuItem = new ToolStripMenuItem();
            redToolStripMenuItem = new ToolStripMenuItem();
            blueToolStripMenuItem = new ToolStripMenuItem();
            moreToolStripMenuItem = new ToolStripMenuItem();
            TSMIHelp = new ToolStripMenuItem();
            TSMIViewHelp = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            TSMIAbout = new ToolStripMenuItem();
            Maintxt = new TextBox();
            statusBar1 = new StatusStrip();
            lblTSS = new ToolStripStatusLabel();
            toolStripContainer1 = new ToolStripContainer();
            toolStripContainer2 = new ToolStripContainer();
            menuStrip1.SuspendLayout();
            statusBar1.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            toolStripContainer2.BottomToolStripPanel.SuspendLayout();
            toolStripContainer2.ContentPanel.SuspendLayout();
            toolStripContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { TSMIFile, TSMIEdit, TSMIFormat, TSMIView, TSMIHelp });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // TSMIFile
            // 
            TSMIFile.DropDownItems.AddRange(new ToolStripItem[] { TSMINew, TSMIOpen, TSMISave, TSMISaveAs, toolStripMenuItem2, TSMISetupPage, TSMIPrint, xxToolStripMenuItem, TSMIExit });
            TSMIFile.Name = "TSMIFile";
            TSMIFile.Size = new Size(46, 24);
            TSMIFile.Text = "File";
            // 
            // TSMINew
            // 
            TSMINew.Name = "TSMINew";
            TSMINew.ShortcutKeys = Keys.Control | Keys.N;
            TSMINew.Size = new Size(190, 26);
            TSMINew.Text = "New";
            TSMINew.Click += TSMINew_Click;
            // 
            // TSMIOpen
            // 
            TSMIOpen.Name = "TSMIOpen";
            TSMIOpen.ShortcutKeys = Keys.Control | Keys.O;
            TSMIOpen.Size = new Size(190, 26);
            TSMIOpen.Text = "Open...";
            TSMIOpen.Click += TSMIOpen_Click;
            // 
            // TSMISave
            // 
            TSMISave.Name = "TSMISave";
            TSMISave.ShortcutKeys = Keys.Control | Keys.S;
            TSMISave.Size = new Size(190, 26);
            TSMISave.Text = "Save";
            TSMISave.Click += TSMISave_Click;
            // 
            // TSMISaveAs
            // 
            TSMISaveAs.Name = "TSMISaveAs";
            TSMISaveAs.Size = new Size(190, 26);
            TSMISaveAs.Text = "Save As...";
            TSMISaveAs.Click += TSMISaveAs_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(187, 6);
            // 
            // TSMISetupPage
            // 
            TSMISetupPage.Name = "TSMISetupPage";
            TSMISetupPage.Size = new Size(190, 26);
            TSMISetupPage.Text = "Page Setup";
            TSMISetupPage.Click += TSMISetupPage_Click;
            // 
            // TSMIPrint
            // 
            TSMIPrint.Name = "TSMIPrint";
            TSMIPrint.ShortcutKeys = Keys.Control | Keys.P;
            TSMIPrint.Size = new Size(190, 26);
            TSMIPrint.Text = "Print...";
            TSMIPrint.Click += TSMIPrint_Click;
            // 
            // xxToolStripMenuItem
            // 
            xxToolStripMenuItem.Name = "xxToolStripMenuItem";
            xxToolStripMenuItem.Size = new Size(187, 6);
            // 
            // TSMIExit
            // 
            TSMIExit.Name = "TSMIExit";
            TSMIExit.Size = new Size(190, 26);
            TSMIExit.Text = "Exit";
            TSMIExit.Click += TSMIExit_Click;
            // 
            // TSMIEdit
            // 
            TSMIEdit.DropDownItems.AddRange(new ToolStripItem[] { TSMIUndo, toolStripSeparator2, TSMICut, TSMICopy, TSMIPaste, TSMIDel, toolStripSeparator3, TSMIFind, TSMIFindNext, TSMIReplace, TSMIGoTo, toolStripSeparator1, TSMISelectAll, TSMITimeDate });
            TSMIEdit.Name = "TSMIEdit";
            TSMIEdit.Size = new Size(49, 24);
            TSMIEdit.Text = "Edit";
            // 
            // TSMIUndo
            // 
            TSMIUndo.Name = "TSMIUndo";
            TSMIUndo.ShortcutKeys = Keys.Control | Keys.Z;
            TSMIUndo.Size = new Size(207, 26);
            TSMIUndo.Text = "Undo";
            TSMIUndo.Click += TSMIUndo_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(204, 6);
            // 
            // TSMICut
            // 
            TSMICut.Enabled = false;
            TSMICut.Name = "TSMICut";
            TSMICut.ShortcutKeys = Keys.Control | Keys.X;
            TSMICut.Size = new Size(207, 26);
            TSMICut.Text = "Cut";
            TSMICut.Click += TSMICut_Click;
            // 
            // TSMICopy
            // 
            TSMICopy.Enabled = false;
            TSMICopy.Name = "TSMICopy";
            TSMICopy.ShortcutKeys = Keys.Control | Keys.C;
            TSMICopy.Size = new Size(207, 26);
            TSMICopy.Text = "Copy";
            TSMICopy.Click += TSMICopy_Click;
            // 
            // TSMIPaste
            // 
            TSMIPaste.Name = "TSMIPaste";
            TSMIPaste.ShortcutKeys = Keys.Control | Keys.V;
            TSMIPaste.Size = new Size(207, 26);
            TSMIPaste.Text = "Paste";
            TSMIPaste.Click += TSMIPaste_Click;
            // 
            // TSMIDel
            // 
            TSMIDel.Enabled = false;
            TSMIDel.Name = "TSMIDel";
            TSMIDel.ShortcutKeys = Keys.Delete;
            TSMIDel.Size = new Size(207, 26);
            TSMIDel.Text = "Delete";
            TSMIDel.Click += TSMIDel_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(204, 6);
            // 
            // TSMIFind
            // 
            TSMIFind.Name = "TSMIFind";
            TSMIFind.ShortcutKeys = Keys.Control | Keys.F;
            TSMIFind.Size = new Size(207, 26);
            TSMIFind.Text = "Find...";
            TSMIFind.Click += TSMIFind_Click;
            // 
            // TSMIFindNext
            // 
            TSMIFindNext.Name = "TSMIFindNext";
            TSMIFindNext.ShortcutKeys = Keys.F3;
            TSMIFindNext.Size = new Size(207, 26);
            TSMIFindNext.Text = "Find Next";
            TSMIFindNext.Click += TSMIFindNext_Click;
            // 
            // TSMIReplace
            // 
            TSMIReplace.Name = "TSMIReplace";
            TSMIReplace.ShortcutKeys = Keys.Control | Keys.H;
            TSMIReplace.Size = new Size(207, 26);
            TSMIReplace.Text = "Replace...";
            TSMIReplace.Click += TSMIReplace_Click;
            // 
            // TSMIGoTo
            // 
            TSMIGoTo.Enabled = false;
            TSMIGoTo.Name = "TSMIGoTo";
            TSMIGoTo.ShortcutKeys = Keys.Control | Keys.G;
            TSMIGoTo.Size = new Size(207, 26);
            TSMIGoTo.Text = "Go To...";
            TSMIGoTo.Click += TSMIGoTo_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(204, 6);
            // 
            // TSMISelectAll
            // 
            TSMISelectAll.Name = "TSMISelectAll";
            TSMISelectAll.ShortcutKeys = Keys.Control | Keys.A;
            TSMISelectAll.Size = new Size(207, 26);
            TSMISelectAll.Text = "Select All";
            TSMISelectAll.Click += TSMISelectAll_Click;
            // 
            // TSMITimeDate
            // 
            TSMITimeDate.Name = "TSMITimeDate";
            TSMITimeDate.ShortcutKeys = Keys.F5;
            TSMITimeDate.Size = new Size(207, 26);
            TSMITimeDate.Text = "Time/Date";
            TSMITimeDate.Click += TSMITimeDate_Click;
            // 
            // TSMIFormat
            // 
            TSMIFormat.DropDownItems.AddRange(new ToolStripItem[] { TSMIWordWrap, TSMIFont });
            TSMIFormat.Name = "TSMIFormat";
            TSMIFormat.Size = new Size(70, 24);
            TSMIFormat.Text = "Format";
            // 
            // TSMIWordWrap
            // 
            TSMIWordWrap.Checked = true;
            TSMIWordWrap.CheckState = CheckState.Checked;
            TSMIWordWrap.Name = "TSMIWordWrap";
            TSMIWordWrap.Size = new Size(168, 26);
            TSMIWordWrap.Text = "Word Wrap";
            TSMIWordWrap.CheckedChanged += TSMIWordWrap_CheckedChanged;
            TSMIWordWrap.Click += TSMIWordWrap_Click;
            // 
            // TSMIFont
            // 
            TSMIFont.Name = "TSMIFont";
            TSMIFont.Size = new Size(168, 26);
            TSMIFont.Text = "Font...";
            TSMIFont.Click += TSMIFont_Click;
            // 
            // TSMIView
            // 
            TSMIView.DropDownItems.AddRange(new ToolStripItem[] { TSMIStatusBar, themeToolStripMenuItem, textColorToolStripMenuItem });
            TSMIView.Name = "TSMIView";
            TSMIView.Size = new Size(55, 24);
            TSMIView.Text = "View";
            // 
            // TSMIStatusBar
            // 
            TSMIStatusBar.Enabled = false;
            TSMIStatusBar.Name = "TSMIStatusBar";
            TSMIStatusBar.Size = new Size(224, 26);
            TSMIStatusBar.Text = "Status Bar";
            TSMIStatusBar.Click += TSMIStatusBar_Click;
            // 
            // themeToolStripMenuItem
            // 
            themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            themeToolStripMenuItem.Size = new Size(224, 26);
            themeToolStripMenuItem.Text = "Theme...";
            themeToolStripMenuItem.Click += themeToolStripMenuItem_Click;
            // 
            // textColorToolStripMenuItem
            // 
            textColorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { blackToolStripMenuItem, redToolStripMenuItem, blueToolStripMenuItem, moreToolStripMenuItem });
            textColorToolStripMenuItem.Name = "textColorToolStripMenuItem";
            textColorToolStripMenuItem.Size = new Size(224, 26);
            textColorToolStripMenuItem.Text = "Text Color...";
            // 
            // blackToolStripMenuItem
            // 
            blackToolStripMenuItem.Checked = true;
            blackToolStripMenuItem.CheckState = CheckState.Checked;
            blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            blackToolStripMenuItem.Size = new Size(224, 26);
            blackToolStripMenuItem.Text = "Black";
            blackToolStripMenuItem.Click += blackToolStripMenuItem_Click;
            // 
            // redToolStripMenuItem
            // 
            redToolStripMenuItem.Name = "redToolStripMenuItem";
            redToolStripMenuItem.Size = new Size(224, 26);
            redToolStripMenuItem.Text = "Red";
            redToolStripMenuItem.Click += redToolStripMenuItem_Click;
            // 
            // blueToolStripMenuItem
            // 
            blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            blueToolStripMenuItem.Size = new Size(224, 26);
            blueToolStripMenuItem.Text = "Blue";
            blueToolStripMenuItem.Click += blueToolStripMenuItem_Click;
            // 
            // moreToolStripMenuItem
            // 
            moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            moreToolStripMenuItem.Size = new Size(224, 26);
            moreToolStripMenuItem.Text = "More...";
            moreToolStripMenuItem.Click += moreToolStripMenuItem_Click;
            // 
            // TSMIHelp
            // 
            TSMIHelp.DropDownItems.AddRange(new ToolStripItem[] { TSMIViewHelp, toolStripSeparator4, TSMIAbout });
            TSMIHelp.Name = "TSMIHelp";
            TSMIHelp.Size = new Size(55, 24);
            TSMIHelp.Text = "Help";
            // 
            // TSMIViewHelp
            // 
            TSMIViewHelp.Name = "TSMIViewHelp";
            TSMIViewHelp.Size = new Size(200, 26);
            TSMIViewHelp.Text = "View Help";
            TSMIViewHelp.Click += TSMIViewHelp_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(197, 6);
            // 
            // TSMIAbout
            // 
            TSMIAbout.Name = "TSMIAbout";
            TSMIAbout.Size = new Size(200, 26);
            TSMIAbout.Text = "About My Notes";
            TSMIAbout.Click += TSMIAbout_Click;
            // 
            // Maintxt
            // 
            Maintxt.BorderStyle = BorderStyle.FixedSingle;
            Maintxt.Cursor = Cursors.IBeam;
            Maintxt.Dock = DockStyle.Fill;
            Maintxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Maintxt.Location = new Point(0, 0);
            Maintxt.Multiline = true;
            Maintxt.Name = "Maintxt";
            Maintxt.ScrollBars = ScrollBars.Vertical;
            Maintxt.Size = new Size(800, 528);
            Maintxt.TabIndex = 1;
            Maintxt.TextChanged += Maintxt_TextChanged;
            Maintxt.MouseCaptureChanged += Maintxt_MouseCaptureChanged;
            // 
            // statusBar1
            // 
            statusBar1.Dock = DockStyle.None;
            statusBar1.ImageScalingSize = new Size(20, 20);
            statusBar1.Items.AddRange(new ToolStripItem[] { lblTSS });
            statusBar1.Location = new Point(0, 0);
            statusBar1.Name = "statusBar1";
            statusBar1.Size = new Size(110, 30);
            statusBar1.TabIndex = 3;
            statusBar1.Text = "statusStrip1";
            statusBar1.Visible = false;
            // 
            // lblTSS
            // 
            lblTSS.BorderSides = ToolStripStatusLabelBorderSides.Right;
            lblTSS.Name = "lblTSS";
            lblTSS.Size = new Size(93, 24);
            lblTSS.Text = "ln -- char -- ";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.AutoScroll = true;
            toolStripContainer1.ContentPanel.Controls.Add(Maintxt);
            toolStripContainer1.ContentPanel.Size = new Size(800, 528);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(800, 556);
            toolStripContainer1.TabIndex = 4;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(menuStrip1);
            // 
            // toolStripContainer2
            // 
            // 
            // toolStripContainer2.BottomToolStripPanel
            // 
            toolStripContainer2.BottomToolStripPanel.Controls.Add(statusBar1);
            // 
            // toolStripContainer2.ContentPanel
            // 
            toolStripContainer2.ContentPanel.AutoScroll = true;
            toolStripContainer2.ContentPanel.Controls.Add(toolStripContainer1);
            toolStripContainer2.ContentPanel.Size = new Size(800, 556);
            toolStripContainer2.Dock = DockStyle.Fill;
            toolStripContainer2.Location = new Point(0, 0);
            toolStripContainer2.Name = "toolStripContainer2";
            toolStripContainer2.Size = new Size(800, 581);
            toolStripContainer2.TabIndex = 6;
            toolStripContainer2.Text = "toolStripContainer2";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 581);
            Controls.Add(toolStripContainer2);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(450, 600);
            Name = "Form1";
            Text = "My Notes";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusBar1.ResumeLayout(false);
            statusBar1.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ContentPanel.PerformLayout();
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            toolStripContainer2.BottomToolStripPanel.ResumeLayout(false);
            toolStripContainer2.BottomToolStripPanel.PerformLayout();
            toolStripContainer2.ContentPanel.ResumeLayout(false);
            toolStripContainer2.ResumeLayout(false);
            toolStripContainer2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem TSMIFile;
        private ToolStripMenuItem TSMINew;
        private ToolStripMenuItem TSMIOpen;
        private ToolStripMenuItem TSMISave;
        private ToolStripMenuItem TSMISaveAs;
        private ToolStripMenuItem TSMIEdit;
        private ToolStripMenuItem TSMIFormat;
        private ToolStripMenuItem TSMIView;
        private ToolStripMenuItem TSMIHelp;
        private ToolStripMenuItem TSMISetupPage;
        private ToolStripMenuItem TSMIPrint;
        private ToolStripMenuItem TSMIExit;
        private ToolStripMenuItem TSMIUndo;
        private ToolStripMenuItem TSMICut;
        private ToolStripMenuItem TSMICopy;
        private ToolStripMenuItem TSMIPaste;
        private ToolStripMenuItem TSMIDel;
        private ToolStripMenuItem TSMIFind;
        private ToolStripMenuItem TSMIFindNext;
        private ToolStripMenuItem TSMIReplace;
        private ToolStripMenuItem TSMIGoTo;
        private ToolStripMenuItem TSMISelectAll;
        private ToolStripMenuItem TSMITimeDate;
        private ToolStripMenuItem TSMIWordWrap;
        private ToolStripMenuItem TSMIFont;
        private ToolStripMenuItem TSMIStatusBar;
        private ToolStripMenuItem TSMIViewHelp;
        private ToolStripMenuItem TSMIAbout;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripSeparator xxToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator4;
        private StatusStrip statusBar1;
        private ToolStripContainer toolStripContainer1;
        private ToolStripStatusLabel lblTSS;
        private ToolStripContainer toolStripContainer2;
        public TextBox Maintxt;
        private ToolStripMenuItem themeToolStripMenuItem;
        private ToolStripMenuItem textColorToolStripMenuItem;
        private ToolStripMenuItem blackToolStripMenuItem;
        private ToolStripMenuItem redToolStripMenuItem;
        private ToolStripMenuItem blueToolStripMenuItem;
        private ToolStripMenuItem moreToolStripMenuItem;
    }
}
