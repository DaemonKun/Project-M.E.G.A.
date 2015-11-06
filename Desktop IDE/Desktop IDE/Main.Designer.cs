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
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.chkTheme = new MetroFramework.Controls.MetroCheckBox();
            this.tabMenu = new MetroFramework.Controls.MetroTabControl();
            this.tabUser = new MetroFramework.Controls.MetroTabPage();
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
            this.butHotspot = new MetroFramework.Controls.MetroButton();
            this.butServer = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            this.tabMenu.SuspendLayout();
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
            this.chkTheme.Location = new System.Drawing.Point(40, 615);
            this.chkTheme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.tabMenu.Location = new System.Drawing.Point(34, 85);
            this.tabMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 1;
            this.tabMenu.Size = new System.Drawing.Size(1044, 522);
            this.tabMenu.TabIndex = 1;
            this.tabMenu.UseSelectable = true;
            // 
            // tabUser
            // 
            this.tabUser.HorizontalScrollbarBarColor = true;
            this.tabUser.HorizontalScrollbarHighlightOnWheel = false;
            this.tabUser.HorizontalScrollbarSize = 15;
            this.tabUser.Location = new System.Drawing.Point(4, 38);
            this.tabUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabUser.Name = "tabUser";
            this.tabUser.Size = new System.Drawing.Size(1036, 480);
            this.tabUser.TabIndex = 0;
            this.tabUser.Text = "Users";
            this.tabUser.VerticalScrollbarBarColor = true;
            this.tabUser.VerticalScrollbarHighlightOnWheel = false;
            this.tabUser.VerticalScrollbarSize = 15;
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
            this.tabQuestion.HorizontalScrollbarSize = 15;
            this.tabQuestion.Location = new System.Drawing.Point(4, 38);
            this.tabQuestion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabQuestion.Name = "tabQuestion";
            this.tabQuestion.Size = new System.Drawing.Size(1036, 480);
            this.tabQuestion.TabIndex = 1;
            this.tabQuestion.Text = "Questions";
            this.tabQuestion.VerticalScrollbarBarColor = true;
            this.tabQuestion.VerticalScrollbarHighlightOnWheel = false;
            this.tabQuestion.VerticalScrollbarSize = 15;
            // 
            // butClear
            // 
            this.butClear.Location = new System.Drawing.Point(18, 191);
            this.butClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(254, 35);
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
            this.butNext.Location = new System.Drawing.Point(915, 420);
            this.butNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butNext.Name = "butNext";
            this.butNext.Size = new System.Drawing.Size(112, 35);
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
            this.butPrevious.Location = new System.Drawing.Point(658, 420);
            this.butPrevious.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butPrevious.Name = "butPrevious";
            this.butPrevious.Size = new System.Drawing.Size(112, 35);
            this.butPrevious.TabIndex = 9;
            this.butPrevious.Text = "<<Previous";
            this.butPrevious.UseSelectable = true;
            this.butPrevious.Click += new System.EventHandler(this.clickPrevious);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(159, 146);
            this.butDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(112, 35);
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
            this.panelQuestion.HorizontalScrollbarSize = 15;
            this.panelQuestion.Location = new System.Drawing.Point(280, 5);
            this.panelQuestion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelQuestion.Name = "panelQuestion";
            this.panelQuestion.Size = new System.Drawing.Size(747, 406);
            this.panelQuestion.TabIndex = 7;
            this.panelQuestion.VerticalScrollbarBarColor = true;
            this.panelQuestion.VerticalScrollbarHighlightOnWheel = false;
            this.panelQuestion.VerticalScrollbarSize = 15;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(4, 12);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.txtD.CustomButton.Location = new System.Drawing.Point(324, 2);
            this.txtD.CustomButton.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtD.CustomButton.Name = "";
            this.txtD.CustomButton.Size = new System.Drawing.Size(50, 51);
            this.txtD.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtD.CustomButton.TabIndex = 1;
            this.txtD.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtD.CustomButton.UseSelectable = true;
            this.txtD.CustomButton.Visible = false;
            this.txtD.Lines = new string[0];
            this.txtD.Location = new System.Drawing.Point(476, 354);
            this.txtD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtD.MaxLength = 32767;
            this.txtD.Name = "txtD";
            this.txtD.PasswordChar = '\0';
            this.txtD.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtD.SelectedText = "";
            this.txtD.SelectionLength = 0;
            this.txtD.SelectionStart = 0;
            this.txtD.Size = new System.Drawing.Size(250, 35);
            this.txtD.TabIndex = 13;
            this.txtD.UseSelectable = true;
            this.txtD.WaterMark = "Type option D here...";
            this.txtD.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtD.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.Location = new System.Drawing.Point(416, 362);
            this.rbD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.txtB.CustomButton.Location = new System.Drawing.Point(324, 2);
            this.txtB.CustomButton.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtB.CustomButton.Name = "";
            this.txtB.CustomButton.Size = new System.Drawing.Size(50, 51);
            this.txtB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtB.CustomButton.TabIndex = 1;
            this.txtB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtB.CustomButton.UseSelectable = true;
            this.txtB.CustomButton.Visible = false;
            this.txtB.Lines = new string[0];
            this.txtB.Location = new System.Drawing.Point(476, 286);
            this.txtB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtB.MaxLength = 32767;
            this.txtB.Name = "txtB";
            this.txtB.PasswordChar = '\0';
            this.txtB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtB.SelectedText = "";
            this.txtB.SelectionLength = 0;
            this.txtB.SelectionStart = 0;
            this.txtB.Size = new System.Drawing.Size(250, 35);
            this.txtB.TabIndex = 11;
            this.txtB.UseSelectable = true;
            this.txtB.WaterMark = "Type option C here...";
            this.txtB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Location = new System.Drawing.Point(416, 294);
            this.rbB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.txtC.CustomButton.Location = new System.Drawing.Point(324, 2);
            this.txtC.CustomButton.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtC.CustomButton.Name = "";
            this.txtC.CustomButton.Size = new System.Drawing.Size(50, 51);
            this.txtC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtC.CustomButton.TabIndex = 1;
            this.txtC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtC.CustomButton.UseSelectable = true;
            this.txtC.CustomButton.Visible = false;
            this.txtC.Lines = new string[0];
            this.txtC.Location = new System.Drawing.Point(94, 354);
            this.txtC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtC.MaxLength = 32767;
            this.txtC.Name = "txtC";
            this.txtC.PasswordChar = '\0';
            this.txtC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtC.SelectedText = "";
            this.txtC.SelectionLength = 0;
            this.txtC.SelectionStart = 0;
            this.txtC.Size = new System.Drawing.Size(250, 35);
            this.txtC.TabIndex = 9;
            this.txtC.UseSelectable = true;
            this.txtC.WaterMark = "Type option B here...";
            this.txtC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(34, 362);
            this.rbC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.txtA.CustomButton.Location = new System.Drawing.Point(324, 2);
            this.txtA.CustomButton.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtA.CustomButton.Name = "";
            this.txtA.CustomButton.Size = new System.Drawing.Size(50, 51);
            this.txtA.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtA.CustomButton.TabIndex = 1;
            this.txtA.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtA.CustomButton.UseSelectable = true;
            this.txtA.CustomButton.Visible = false;
            this.txtA.Lines = new string[0];
            this.txtA.Location = new System.Drawing.Point(94, 286);
            this.txtA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtA.MaxLength = 32767;
            this.txtA.Name = "txtA";
            this.txtA.PasswordChar = '\0';
            this.txtA.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtA.SelectedText = "";
            this.txtA.SelectionLength = 0;
            this.txtA.SelectionStart = 0;
            this.txtA.Size = new System.Drawing.Size(250, 35);
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
            this.rbA.Location = new System.Drawing.Point(34, 294);
            this.rbA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.txtQuestion.CustomButton.Location = new System.Drawing.Point(776, 2);
            this.txtQuestion.CustomButton.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtQuestion.CustomButton.Name = "";
            this.txtQuestion.CustomButton.Size = new System.Drawing.Size(344, 352);
            this.txtQuestion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuestion.CustomButton.TabIndex = 1;
            this.txtQuestion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuestion.CustomButton.UseSelectable = true;
            this.txtQuestion.CustomButton.Visible = false;
            this.txtQuestion.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtQuestion.Lines = new string[0];
            this.txtQuestion.Location = new System.Drawing.Point(0, 46);
            this.txtQuestion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuestion.MaxLength = 32767;
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.PasswordChar = '\0';
            this.txtQuestion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuestion.SelectedText = "";
            this.txtQuestion.SelectionLength = 0;
            this.txtQuestion.SelectionStart = 0;
            this.txtQuestion.Size = new System.Drawing.Size(747, 231);
            this.txtQuestion.TabIndex = 2;
            this.txtQuestion.UseSelectable = true;
            this.txtQuestion.WaterMark = "Type the question here...";
            this.txtQuestion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuestion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15.4F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(159, 355);
            this.butSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(112, 55);
            this.butSave.TabIndex = 6;
            this.butSave.Text = "Save";
            this.butSave.UseSelectable = true;
            this.butSave.Click += new System.EventHandler(this.clickSave);
            // 
            // butLoad
            // 
            this.butLoad.Location = new System.Drawing.Point(18, 355);
            this.butLoad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butLoad.Name = "butLoad";
            this.butLoad.Size = new System.Drawing.Size(112, 55);
            this.butLoad.TabIndex = 5;
            this.butLoad.Text = "Load";
            this.butLoad.UseSelectable = true;
            this.butLoad.Click += new System.EventHandler(this.clickLoad);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(18, 146);
            this.butAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(112, 35);
            this.butAdd.TabIndex = 4;
            this.butAdd.Text = "Add Item";
            this.butAdd.UseSelectable = true;
            this.butAdd.Click += new System.EventHandler(this.clickAdd);
            // 
            // cbNumber
            // 
            this.cbNumber.FormattingEnabled = true;
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
            this.cbNumber.Location = new System.Drawing.Point(198, 77);
            this.cbNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbNumber.Name = "cbNumber";
            this.cbNumber.Size = new System.Drawing.Size(72, 29);
            this.cbNumber.TabIndex = 3;
            this.cbNumber.UseSelectable = true;
            this.cbNumber.SelectedIndexChanged += new System.EventHandler(this.changeNum);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(18, 77);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(114, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Question Number";
            // 
            // tabUdb
            // 
            this.tabUdb.HorizontalScrollbarBarColor = true;
            this.tabUdb.HorizontalScrollbarHighlightOnWheel = false;
            this.tabUdb.HorizontalScrollbarSize = 15;
            this.tabUdb.Location = new System.Drawing.Point(4, 38);
            this.tabUdb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabUdb.Name = "tabUdb";
            this.tabUdb.Size = new System.Drawing.Size(1036, 480);
            this.tabUdb.TabIndex = 2;
            this.tabUdb.Text = "User Database";
            this.tabUdb.VerticalScrollbarBarColor = true;
            this.tabUdb.VerticalScrollbarHighlightOnWheel = false;
            this.tabUdb.VerticalScrollbarSize = 15;
            // 
            // butHotspot
            // 
            this.butHotspot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butHotspot.Location = new System.Drawing.Point(418, 615);
            this.butHotspot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butHotspot.Name = "butHotspot";
            this.butHotspot.Size = new System.Drawing.Size(248, 32);
            this.butHotspot.TabIndex = 2;
            this.butHotspot.Text = "Start Hotspot";
            this.butHotspot.UseSelectable = true;
            this.butHotspot.Click += new System.EventHandler(this.clickHotspot);
            // 
            // butServer
            // 
            this.butServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butServer.Location = new System.Drawing.Point(831, 615);
            this.butServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butServer.Name = "butServer";
            this.butServer.Size = new System.Drawing.Size(248, 32);
            this.butServer.TabIndex = 4;
            this.butServer.Text = "Start Server";
            this.butServer.UseSelectable = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 680);
            this.Controls.Add(this.butServer);
            this.Controls.Add(this.butHotspot);
            this.Controls.Add(this.tabMenu);
            this.Controls.Add(this.chkTheme);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Project M.E.G.A.";
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.tabMenu.ResumeLayout(false);
            this.tabQuestion.ResumeLayout(false);
            this.tabQuestion.PerformLayout();
            this.panelQuestion.ResumeLayout(false);
            this.panelQuestion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager msmMain;
        private MetroFramework.Controls.MetroCheckBox chkTheme;
        private MetroFramework.Controls.MetroTabControl tabMenu;
        private MetroFramework.Controls.MetroButton butHotspot;
        private MetroFramework.Controls.MetroTabPage tabUser;
        private MetroFramework.Controls.MetroTabPage tabQuestion;
        private MetroFramework.Controls.MetroTabPage tabUdb;
        private MetroFramework.Controls.MetroPanel panelQuestion;
        private MetroFramework.Controls.MetroButton butSave;
        private MetroFramework.Controls.MetroButton butLoad;
        private MetroFramework.Controls.MetroButton butAdd;
        private MetroFramework.Controls.MetroComboBox cbNumber;
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
    }
}

