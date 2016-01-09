namespace Desktop_IDE
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.chkTheme = new MetroFramework.Controls.MetroCheckBox();
            this.tabMenu = new MetroFramework.Controls.MetroTabControl();
            this.tabUser = new MetroFramework.Controls.MetroTabPage();
            this.butCreate = new MetroFramework.Controls.MetroButton();
            this.butLoadTest = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.mpUser = new MetroFramework.Controls.MetroPanel();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.lblExam = new MetroFramework.Controls.MetroLabel();
            this.lblSubject = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUser = new MetroFramework.Controls.MetroLabel();
            this.lblFinish = new MetroFramework.Controls.MetroLabel();
            this.lbxServer = new System.Windows.Forms.ListBox();
            this.tbxFile = new MetroFramework.Controls.MetroTextBox();
            this.tabQuestion = new MetroFramework.Controls.MetroTabPage();
            this.butClear = new MetroFramework.Controls.MetroButton();
            this.butNext = new MetroFramework.Controls.MetroButton();
            this.butPrevious = new MetroFramework.Controls.MetroButton();
            this.butDelete = new MetroFramework.Controls.MetroButton();
            this.panelQuestion = new MetroFramework.Controls.MetroPanel();
            this.lblQuestion = new MetroFramework.Controls.MetroLabel();
            this.txtD = new MetroFramework.Controls.MetroTextBox();
            this.rbD = new MetroFramework.Controls.MetroRadioButton();
            this.txtB = new MetroFramework.Controls.MetroTextBox();
            this.rbB = new MetroFramework.Controls.MetroRadioButton();
            this.txtC = new MetroFramework.Controls.MetroTextBox();
            this.rbC = new MetroFramework.Controls.MetroRadioButton();
            this.txtA = new MetroFramework.Controls.MetroTextBox();
            this.rbA = new MetroFramework.Controls.MetroRadioButton();
            this.txtQuestion = new MetroFramework.Controls.MetroTextBox();
            this.butSave = new MetroFramework.Controls.MetroButton();
            this.butLoad = new MetroFramework.Controls.MetroButton();
            this.butAdd = new MetroFramework.Controls.MetroButton();
            this.cbNumber = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tabUdb = new MetroFramework.Controls.MetroTabPage();
            this.tabRegister = new MetroFramework.Controls.MetroTabPage();
            this.butHotspot = new MetroFramework.Controls.MetroButton();
            this.butServer = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            this.tabMenu.SuspendLayout();
            this.tabUser.SuspendLayout();
            this.mpUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabQuestion.SuspendLayout();
            this.panelQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // msmMain
            // 
            this.msmMain.Owner = this;
            // 
            // chkTheme
            // 
            this.chkTheme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTheme.AutoSize = true;
            this.chkTheme.Location = new System.Drawing.Point(27, 400);
            this.chkTheme.Name = "chkTheme";
            this.chkTheme.Size = new System.Drawing.Size(87, 15);
            this.chkTheme.TabIndex = 0;
            this.chkTheme.Text = "Dark Theme";
            this.chkTheme.UseSelectable = true;
            this.chkTheme.CheckedChanged += new System.EventHandler(this.checkTheme);
            // 
            // tabMenu
            // 
            this.tabMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMenu.Controls.Add(this.tabUser);
            this.tabMenu.Controls.Add(this.tabQuestion);
            this.tabMenu.Controls.Add(this.tabUdb);
            this.tabMenu.Controls.Add(this.tabRegister);
            this.tabMenu.Location = new System.Drawing.Point(23, 55);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 1;
            this.tabMenu.Size = new System.Drawing.Size(696, 339);
            this.tabMenu.TabIndex = 1;
            this.tabMenu.UseSelectable = true;
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.butCreate);
            this.tabUser.Controls.Add(this.butLoadTest);
            this.tabUser.Controls.Add(this.metroLabel5);
            this.tabUser.Controls.Add(this.mpUser);
            this.tabUser.Controls.Add(this.lbxServer);
            this.tabUser.Controls.Add(this.tbxFile);
            this.tabUser.HorizontalScrollbarBarColor = true;
            this.tabUser.HorizontalScrollbarHighlightOnWheel = false;
            this.tabUser.HorizontalScrollbarSize = 10;
            this.tabUser.Location = new System.Drawing.Point(4, 38);
            this.tabUser.Name = "tabUser";
            this.tabUser.Size = new System.Drawing.Size(688, 297);
            this.tabUser.TabIndex = 0;
            this.tabUser.Text = "Users";
            this.tabUser.VerticalScrollbarBarColor = true;
            this.tabUser.VerticalScrollbarHighlightOnWheel = false;
            this.tabUser.VerticalScrollbarSize = 10;
            // 
            // butCreate
            // 
            this.butCreate.Location = new System.Drawing.Point(585, 21);
            this.butCreate.Name = "butCreate";
            this.butCreate.Size = new System.Drawing.Size(100, 23);
            this.butCreate.TabIndex = 8;
            this.butCreate.Text = "Create Test File";
            this.butCreate.UseSelectable = true;
            this.butCreate.Click += new System.EventHandler(this.clickCreate);
            // 
            // butLoadTest
            // 
            this.butLoadTest.Location = new System.Drawing.Point(473, 21);
            this.butLoadTest.Name = "butLoadTest";
            this.butLoadTest.Size = new System.Drawing.Size(87, 23);
            this.butLoadTest.TabIndex = 7;
            this.butLoadTest.Text = "Load Test File";
            this.butLoadTest.UseSelectable = true;
            this.butLoadTest.Click += new System.EventHandler(this.butLoadTest_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(3, 25);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(57, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Test File:";
            // 
            // mpUser
            // 
            this.mpUser.BackColor = System.Drawing.Color.Transparent;
            this.mpUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mpUser.Controls.Add(this.lblId);
            this.mpUser.Controls.Add(this.lblExam);
            this.mpUser.Controls.Add(this.lblSubject);
            this.mpUser.Controls.Add(this.pictureBox1);
            this.mpUser.Controls.Add(this.lblUser);
            this.mpUser.Controls.Add(this.lblFinish);
            this.mpUser.HorizontalScrollbarBarColor = true;
            this.mpUser.HorizontalScrollbarHighlightOnWheel = false;
            this.mpUser.HorizontalScrollbarSize = 10;
            this.mpUser.Location = new System.Drawing.Point(328, 50);
            this.mpUser.Name = "mpUser";
            this.mpUser.Size = new System.Drawing.Size(359, 225);
            this.mpUser.TabIndex = 5;
            this.mpUser.VerticalScrollbarBarColor = true;
            this.mpUser.VerticalScrollbarHighlightOnWheel = false;
            this.mpUser.VerticalScrollbarSize = 10;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(3, 25);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(75, 19);
            this.lblId.TabIndex = 9;
            this.lblId.Text = "ID number:";
            // 
            // lblExam
            // 
            this.lblExam.AutoSize = true;
            this.lblExam.Location = new System.Drawing.Point(3, 121);
            this.lblExam.Name = "lblExam";
            this.lblExam.Size = new System.Drawing.Size(48, 19);
            this.lblExam.TabIndex = 8;
            this.lblExam.Text = "Exam :";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(3, 87);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(54, 19);
            this.lblSubject.TabIndex = 7;
            this.lblSubject.Text = "Subject:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(76, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(3, 55);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(43, 19);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "User: ";
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.Location = new System.Drawing.Point(98, 181);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(93, 19);
            this.lblFinish.TabIndex = 2;
            this.lblFinish.Text = "Still Answering";
            // 
            // lbxServer
            // 
            this.lbxServer.FormattingEnabled = true;
            this.lbxServer.Location = new System.Drawing.Point(3, 50);
            this.lbxServer.Name = "lbxServer";
            this.lbxServer.Size = new System.Drawing.Size(302, 225);
            this.lbxServer.TabIndex = 4;
            this.lbxServer.SelectedIndexChanged += new System.EventHandler(this.selectClient);
            // 
            // tbxFile
            // 
            // 
            // 
            // 
            this.tbxFile.CustomButton.Image = null;
            this.tbxFile.CustomButton.Location = new System.Drawing.Point(358, 1);
            this.tbxFile.CustomButton.Name = "";
            this.tbxFile.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxFile.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxFile.CustomButton.TabIndex = 1;
            this.tbxFile.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxFile.CustomButton.UseSelectable = true;
            this.tbxFile.CustomButton.Visible = false;
            this.tbxFile.Enabled = false;
            this.tbxFile.Lines = new string[0];
            this.tbxFile.Location = new System.Drawing.Point(77, 21);
            this.tbxFile.MaxLength = 32767;
            this.tbxFile.Name = "tbxFile";
            this.tbxFile.PasswordChar = '\0';
            this.tbxFile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxFile.SelectedText = "";
            this.tbxFile.SelectionLength = 0;
            this.tbxFile.SelectionStart = 0;
            this.tbxFile.Size = new System.Drawing.Size(380, 23);
            this.tbxFile.TabIndex = 3;
            this.tbxFile.UseSelectable = true;
            this.tbxFile.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxFile.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tabQuestion
            // 
            this.tabQuestion.Controls.Add(this.butClear);
            this.tabQuestion.Controls.Add(this.butNext);
            this.tabQuestion.Controls.Add(this.butPrevious);
            this.tabQuestion.Controls.Add(this.butDelete);
            this.tabQuestion.Controls.Add(this.panelQuestion);
            this.tabQuestion.Controls.Add(this.butSave);
            this.tabQuestion.Controls.Add(this.butLoad);
            this.tabQuestion.Controls.Add(this.butAdd);
            this.tabQuestion.Controls.Add(this.cbNumber);
            this.tabQuestion.Controls.Add(this.metroLabel1);
            this.tabQuestion.HorizontalScrollbarBarColor = true;
            this.tabQuestion.HorizontalScrollbarHighlightOnWheel = false;
            this.tabQuestion.HorizontalScrollbarSize = 10;
            this.tabQuestion.Location = new System.Drawing.Point(4, 38);
            this.tabQuestion.Name = "tabQuestion";
            this.tabQuestion.Size = new System.Drawing.Size(688, 297);
            this.tabQuestion.TabIndex = 1;
            this.tabQuestion.Text = "Questions";
            this.tabQuestion.VerticalScrollbarBarColor = true;
            this.tabQuestion.VerticalScrollbarHighlightOnWheel = false;
            this.tabQuestion.VerticalScrollbarSize = 10;
            // 
            // butClear
            // 
            this.butClear.Location = new System.Drawing.Point(12, 124);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(169, 23);
            this.butClear.TabIndex = 11;
            this.butClear.Text = "Clear Text Fields";
            this.butClear.UseSelectable = true;
            this.butClear.Click += new System.EventHandler(this.clickClear);
            // 
            // butNext
            // 
            this.butNext.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.butNext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butNext.Location = new System.Drawing.Point(610, 271);
            this.butNext.Name = "butNext";
            this.butNext.Size = new System.Drawing.Size(75, 23);
            this.butNext.TabIndex = 10;
            this.butNext.Text = "Next>>";
            this.butNext.UseSelectable = true;
            this.butNext.Click += new System.EventHandler(this.clickNext);
            // 
            // butPrevious
            // 
            this.butPrevious.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.butPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butPrevious.Location = new System.Drawing.Point(439, 273);
            this.butPrevious.Name = "butPrevious";
            this.butPrevious.Size = new System.Drawing.Size(75, 23);
            this.butPrevious.TabIndex = 9;
            this.butPrevious.Text = "<<Previous";
            this.butPrevious.UseSelectable = true;
            this.butPrevious.Click += new System.EventHandler(this.clickPrevious);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(106, 95);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(75, 23);
            this.butDelete.TabIndex = 8;
            this.butDelete.Text = "Delete Item";
            this.butDelete.UseSelectable = true;
            this.butDelete.Click += new System.EventHandler(this.clickDelete);
            // 
            // panelQuestion
            // 
            this.panelQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelQuestion.Controls.Add(this.lblQuestion);
            this.panelQuestion.Controls.Add(this.txtD);
            this.panelQuestion.Controls.Add(this.rbD);
            this.panelQuestion.Controls.Add(this.txtB);
            this.panelQuestion.Controls.Add(this.rbB);
            this.panelQuestion.Controls.Add(this.txtC);
            this.panelQuestion.Controls.Add(this.rbC);
            this.panelQuestion.Controls.Add(this.txtA);
            this.panelQuestion.Controls.Add(this.rbA);
            this.panelQuestion.Controls.Add(this.txtQuestion);
            this.panelQuestion.HorizontalScrollbarBarColor = true;
            this.panelQuestion.HorizontalScrollbarHighlightOnWheel = false;
            this.panelQuestion.HorizontalScrollbarSize = 10;
            this.panelQuestion.Location = new System.Drawing.Point(187, 3);
            this.panelQuestion.Name = "panelQuestion";
            this.panelQuestion.Size = new System.Drawing.Size(498, 264);
            this.panelQuestion.TabIndex = 7;
            this.panelQuestion.VerticalScrollbarBarColor = true;
            this.panelQuestion.VerticalScrollbarHighlightOnWheel = false;
            this.panelQuestion.VerticalScrollbarSize = 10;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(3, 8);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(61, 19);
            this.lblQuestion.TabIndex = 14;
            this.lblQuestion.Text = "Question";
            // 
            // txtD
            // 
            // 
            // 
            // 
            this.txtD.CustomButton.Image = null;
            this.txtD.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.txtD.CustomButton.Name = "";
            this.txtD.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtD.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtD.CustomButton.TabIndex = 1;
            this.txtD.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtD.CustomButton.UseSelectable = true;
            this.txtD.CustomButton.Visible = false;
            this.txtD.Lines = new string[0];
            this.txtD.Location = new System.Drawing.Point(317, 230);
            this.txtD.MaxLength = 32767;
            this.txtD.Name = "txtD";
            this.txtD.PasswordChar = '\0';
            this.txtD.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtD.SelectedText = "";
            this.txtD.SelectionLength = 0;
            this.txtD.SelectionStart = 0;
            this.txtD.Size = new System.Drawing.Size(167, 23);
            this.txtD.TabIndex = 13;
            this.txtD.UseSelectable = true;
            this.txtD.WaterMark = "Type option D here...";
            this.txtD.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtD.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.Location = new System.Drawing.Point(277, 235);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(34, 15);
            this.rbD.TabIndex = 12;
            this.rbD.Text = "D.";
            this.rbD.UseSelectable = true;
            // 
            // txtB
            // 
            // 
            // 
            // 
            this.txtB.CustomButton.Image = null;
            this.txtB.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.txtB.CustomButton.Name = "";
            this.txtB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtB.CustomButton.TabIndex = 1;
            this.txtB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtB.CustomButton.UseSelectable = true;
            this.txtB.CustomButton.Visible = false;
            this.txtB.Lines = new string[0];
            this.txtB.Location = new System.Drawing.Point(317, 186);
            this.txtB.MaxLength = 32767;
            this.txtB.Name = "txtB";
            this.txtB.PasswordChar = '\0';
            this.txtB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtB.SelectedText = "";
            this.txtB.SelectionLength = 0;
            this.txtB.SelectionStart = 0;
            this.txtB.Size = new System.Drawing.Size(167, 23);
            this.txtB.TabIndex = 11;
            this.txtB.UseSelectable = true;
            this.txtB.WaterMark = "Type option C here...";
            this.txtB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Location = new System.Drawing.Point(277, 191);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(33, 15);
            this.rbB.TabIndex = 10;
            this.rbB.Text = "B.";
            this.rbB.UseSelectable = true;
            // 
            // txtC
            // 
            // 
            // 
            // 
            this.txtC.CustomButton.Image = null;
            this.txtC.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.txtC.CustomButton.Name = "";
            this.txtC.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtC.CustomButton.TabIndex = 1;
            this.txtC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtC.CustomButton.UseSelectable = true;
            this.txtC.CustomButton.Visible = false;
            this.txtC.Lines = new string[0];
            this.txtC.Location = new System.Drawing.Point(63, 230);
            this.txtC.MaxLength = 32767;
            this.txtC.Name = "txtC";
            this.txtC.PasswordChar = '\0';
            this.txtC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtC.SelectedText = "";
            this.txtC.SelectionLength = 0;
            this.txtC.SelectionStart = 0;
            this.txtC.Size = new System.Drawing.Size(167, 23);
            this.txtC.TabIndex = 9;
            this.txtC.UseSelectable = true;
            this.txtC.WaterMark = "Type option B here...";
            this.txtC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(23, 235);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(34, 15);
            this.rbC.TabIndex = 8;
            this.rbC.Text = "C.";
            this.rbC.UseSelectable = true;
            // 
            // txtA
            // 
            // 
            // 
            // 
            this.txtA.CustomButton.Image = null;
            this.txtA.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.txtA.CustomButton.Name = "";
            this.txtA.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtA.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtA.CustomButton.TabIndex = 1;
            this.txtA.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtA.CustomButton.UseSelectable = true;
            this.txtA.CustomButton.Visible = false;
            this.txtA.Lines = new string[0];
            this.txtA.Location = new System.Drawing.Point(63, 186);
            this.txtA.MaxLength = 32767;
            this.txtA.Name = "txtA";
            this.txtA.PasswordChar = '\0';
            this.txtA.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtA.SelectedText = "";
            this.txtA.SelectionLength = 0;
            this.txtA.SelectionStart = 0;
            this.txtA.Size = new System.Drawing.Size(167, 23);
            this.txtA.TabIndex = 7;
            this.txtA.UseSelectable = true;
            this.txtA.WaterMark = "Type option A here...";
            this.txtA.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtA.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Checked = true;
            this.rbA.Location = new System.Drawing.Point(23, 191);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(34, 15);
            this.rbA.TabIndex = 3;
            this.rbA.TabStop = true;
            this.rbA.Text = "A.";
            this.rbA.UseSelectable = true;
            // 
            // txtQuestion
            // 
            // 
            // 
            // 
            this.txtQuestion.CustomButton.Image = null;
            this.txtQuestion.CustomButton.Location = new System.Drawing.Point(350, 2);
            this.txtQuestion.CustomButton.Name = "";
            this.txtQuestion.CustomButton.Size = new System.Drawing.Size(145, 145);
            this.txtQuestion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuestion.CustomButton.TabIndex = 1;
            this.txtQuestion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuestion.CustomButton.UseSelectable = true;
            this.txtQuestion.CustomButton.Visible = false;
            this.txtQuestion.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtQuestion.Lines = new string[0];
            this.txtQuestion.Location = new System.Drawing.Point(0, 30);
            this.txtQuestion.MaxLength = 295;
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.PasswordChar = '\0';
            this.txtQuestion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuestion.SelectedText = "";
            this.txtQuestion.SelectionLength = 0;
            this.txtQuestion.SelectionStart = 0;
            this.txtQuestion.Size = new System.Drawing.Size(498, 150);
            this.txtQuestion.TabIndex = 2;
            this.txtQuestion.UseSelectable = true;
            this.txtQuestion.WaterMark = "Type the question here...";
            this.txtQuestion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuestion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15.4F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(106, 231);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(75, 36);
            this.butSave.TabIndex = 6;
            this.butSave.Text = "Save";
            this.butSave.UseSelectable = true;
            this.butSave.Click += new System.EventHandler(this.clickSave);
            // 
            // butLoad
            // 
            this.butLoad.Location = new System.Drawing.Point(12, 231);
            this.butLoad.Name = "butLoad";
            this.butLoad.Size = new System.Drawing.Size(75, 36);
            this.butLoad.TabIndex = 5;
            this.butLoad.Text = "Load";
            this.butLoad.UseSelectable = true;
            this.butLoad.Click += new System.EventHandler(this.clickLoad);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(12, 95);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 23);
            this.butAdd.TabIndex = 4;
            this.butAdd.Text = "Add Item";
            this.butAdd.UseSelectable = true;
            this.butAdd.Click += new System.EventHandler(this.clickAdd);
            // 
            // cbNumber
            // 
            this.cbNumber.FormattingEnabled = true;
            this.cbNumber.IntegralHeight = false;
            this.cbNumber.ItemHeight = 23;
            this.cbNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbNumber.Location = new System.Drawing.Point(132, 50);
            this.cbNumber.Name = "cbNumber";
            this.cbNumber.Size = new System.Drawing.Size(49, 29);
            this.cbNumber.TabIndex = 3;
            this.cbNumber.UseSelectable = true;
            this.cbNumber.SelectedIndexChanged += new System.EventHandler(this.changeNum);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 50);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(114, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Question Number";
            // 
            // tabUdb
            // 
            this.tabUdb.HorizontalScrollbarBarColor = true;
            this.tabUdb.HorizontalScrollbarHighlightOnWheel = false;
            this.tabUdb.HorizontalScrollbarSize = 10;
            this.tabUdb.Location = new System.Drawing.Point(4, 38);
            this.tabUdb.Name = "tabUdb";
            this.tabUdb.Size = new System.Drawing.Size(688, 297);
            this.tabUdb.TabIndex = 2;
            this.tabUdb.Text = "User Database";
            this.tabUdb.VerticalScrollbarBarColor = true;
            this.tabUdb.VerticalScrollbarHighlightOnWheel = false;
            this.tabUdb.VerticalScrollbarSize = 10;
            // 
            // tabRegister
            // 
            this.tabRegister.HorizontalScrollbarBarColor = true;
            this.tabRegister.HorizontalScrollbarHighlightOnWheel = false;
            this.tabRegister.HorizontalScrollbarSize = 10;
            this.tabRegister.Location = new System.Drawing.Point(4, 38);
            this.tabRegister.Name = "tabRegister";
            this.tabRegister.Size = new System.Drawing.Size(688, 297);
            this.tabRegister.TabIndex = 3;
            this.tabRegister.Text = "Register Login Data";
            this.tabRegister.VerticalScrollbarBarColor = true;
            this.tabRegister.VerticalScrollbarHighlightOnWheel = false;
            this.tabRegister.VerticalScrollbarSize = 10;
            // 
            // butHotspot
            // 
            this.butHotspot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butHotspot.Location = new System.Drawing.Point(304, 400);
            this.butHotspot.Name = "butHotspot";
            this.butHotspot.Size = new System.Drawing.Size(165, 21);
            this.butHotspot.TabIndex = 2;
            this.butHotspot.Text = "Start Hotspot";
            this.butHotspot.UseSelectable = true;
            this.butHotspot.Click += new System.EventHandler(this.clickHotspot);
            // 
            // butServer
            // 
            this.butServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butServer.Location = new System.Drawing.Point(554, 400);
            this.butServer.Name = "butServer";
            this.butServer.Size = new System.Drawing.Size(165, 21);
            this.butServer.TabIndex = 4;
            this.butServer.Text = "Start Server";
            this.butServer.UseSelectable = true;
            this.butServer.Click += new System.EventHandler(this.clickServer);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 442);
            this.Controls.Add(this.butServer);
            this.Controls.Add(this.butHotspot);
            this.Controls.Add(this.chkTheme);
            this.Controls.Add(this.tabMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Project M.E.G.A.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.atClose);
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.tabMenu.ResumeLayout(false);
            this.tabUser.ResumeLayout(false);
            this.tabUser.PerformLayout();
            this.mpUser.ResumeLayout(false);
            this.mpUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabQuestion.ResumeLayout(false);
            this.tabQuestion.PerformLayout();
            this.panelQuestion.ResumeLayout(false);
            this.panelQuestion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox chkTheme;
        private MetroFramework.Controls.MetroButton butHotspot;
        private MetroFramework.Controls.MetroTabPage tabUser;
        private MetroFramework.Controls.MetroTabPage tabQuestion;
        private MetroFramework.Controls.MetroTabPage tabUdb;
        private MetroFramework.Controls.MetroPanel panelQuestion;
        private MetroFramework.Controls.MetroButton butSave;
        private MetroFramework.Controls.MetroButton butLoad;
        private MetroFramework.Controls.MetroButton butAdd;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton butNext;
        private MetroFramework.Controls.MetroButton butPrevious;
        private MetroFramework.Controls.MetroButton butDelete;
        private MetroFramework.Controls.MetroLabel lblQuestion;
        private MetroFramework.Controls.MetroButton butServer;
        private MetroFramework.Controls.MetroRadioButton rbD;
        private MetroFramework.Controls.MetroRadioButton rbB;
        private MetroFramework.Controls.MetroRadioButton rbC;
        private MetroFramework.Controls.MetroRadioButton rbA;
        private MetroFramework.Controls.MetroButton butClear;
        private MetroFramework.Controls.MetroTextBox txtD;
        private MetroFramework.Controls.MetroTextBox txtB;
        private MetroFramework.Controls.MetroTextBox txtC;
        private MetroFramework.Controls.MetroTextBox txtA;
        private MetroFramework.Controls.MetroTextBox txtQuestion;
        private MetroFramework.Controls.MetroTextBox tbxFile;
        private System.Windows.Forms.ListBox lbxServer;
        public MetroFramework.Controls.MetroTabControl tabMenu;
        public MetroFramework.Controls.MetroTabPage tabRegister;
        public MetroFramework.Controls.MetroComboBox cbNumber;
        private MetroFramework.Controls.MetroPanel mpUser;
        private MetroFramework.Controls.MetroLabel lblUser;
        private MetroFramework.Controls.MetroLabel lblFinish;
        private MetroFramework.Controls.MetroLabel lblExam;
        private MetroFramework.Controls.MetroLabel lblSubject;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroButton butLoadTest;
        private MetroFramework.Controls.MetroButton butCreate;
        public MetroFramework.Components.MetroStyleManager msmMain;
    }
}

