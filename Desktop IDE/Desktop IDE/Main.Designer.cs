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
            this.tabTitle = new MetroFramework.Controls.MetroTabPage();
            this.tabUser = new MetroFramework.Controls.MetroTabPage();
            this.tabQuestion = new MetroFramework.Controls.MetroTabPage();
            this.panelQuestion = new MetroFramework.Controls.MetroPanel();
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
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tabUdb = new MetroFramework.Controls.MetroTabPage();
            this.butHotspot = new MetroFramework.Controls.MetroButton();
            this.pb = new MetroFramework.Controls.MetroProgressBar();
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
            this.chkTheme.AutoSize = true;
            this.chkTheme.Location = new System.Drawing.Point(27, 372);
            this.chkTheme.Name = "chkTheme";
            this.chkTheme.Size = new System.Drawing.Size(87, 15);
            this.chkTheme.TabIndex = 0;
            this.chkTheme.Text = "Dark Theme";
            this.chkTheme.UseSelectable = true;
            this.chkTheme.CheckedChanged += new System.EventHandler(this.checkTheme);
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabTitle);
            this.tabMenu.Controls.Add(this.tabUser);
            this.tabMenu.Controls.Add(this.tabQuestion);
            this.tabMenu.Controls.Add(this.tabUdb);
            this.tabMenu.Location = new System.Drawing.Point(23, 55);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 2;
            this.tabMenu.Size = new System.Drawing.Size(696, 311);
            this.tabMenu.TabIndex = 1;
            this.tabMenu.UseSelectable = true;
            // 
            // tabTitle
            // 
            this.tabTitle.HorizontalScrollbarBarColor = true;
            this.tabTitle.HorizontalScrollbarHighlightOnWheel = false;
            this.tabTitle.HorizontalScrollbarSize = 10;
            this.tabTitle.Location = new System.Drawing.Point(4, 38);
            this.tabTitle.Name = "tabTitle";
            this.tabTitle.Size = new System.Drawing.Size(688, 269);
            this.tabTitle.TabIndex = 3;
            this.tabTitle.Text = "Main";
            this.tabTitle.VerticalScrollbarBarColor = true;
            this.tabTitle.VerticalScrollbarHighlightOnWheel = false;
            this.tabTitle.VerticalScrollbarSize = 10;
            // 
            // tabUser
            // 
            this.tabUser.HorizontalScrollbarBarColor = true;
            this.tabUser.HorizontalScrollbarHighlightOnWheel = false;
            this.tabUser.HorizontalScrollbarSize = 10;
            this.tabUser.Location = new System.Drawing.Point(4, 38);
            this.tabUser.Name = "tabUser";
            this.tabUser.Size = new System.Drawing.Size(688, 269);
            this.tabUser.TabIndex = 0;
            this.tabUser.Text = "Users";
            this.tabUser.VerticalScrollbarBarColor = true;
            this.tabUser.VerticalScrollbarHighlightOnWheel = false;
            this.tabUser.VerticalScrollbarSize = 10;
            // 
            // tabQuestion
            // 
            this.tabQuestion.Controls.Add(this.panelQuestion);
            this.tabQuestion.Controls.Add(this.butSave);
            this.tabQuestion.Controls.Add(this.butLoad);
            this.tabQuestion.Controls.Add(this.butAdd);
            this.tabQuestion.Controls.Add(this.metroComboBox2);
            this.tabQuestion.Controls.Add(this.metroLabel1);
            this.tabQuestion.HorizontalScrollbarBarColor = true;
            this.tabQuestion.HorizontalScrollbarHighlightOnWheel = false;
            this.tabQuestion.HorizontalScrollbarSize = 10;
            this.tabQuestion.Location = new System.Drawing.Point(4, 38);
            this.tabQuestion.Name = "tabQuestion";
            this.tabQuestion.Size = new System.Drawing.Size(688, 269);
            this.tabQuestion.TabIndex = 1;
            this.tabQuestion.Text = "Questions";
            this.tabQuestion.VerticalScrollbarBarColor = true;
            this.tabQuestion.VerticalScrollbarHighlightOnWheel = false;
            this.tabQuestion.VerticalScrollbarSize = 10;
            // 
            // panelQuestion
            // 
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
            this.txtD.Location = new System.Drawing.Point(317, 215);
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
            this.txtD.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtD.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.Location = new System.Drawing.Point(277, 220);
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
            this.txtB.Location = new System.Drawing.Point(317, 171);
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
            this.txtB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Location = new System.Drawing.Point(277, 176);
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
            this.txtC.Location = new System.Drawing.Point(63, 215);
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
            this.txtC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(23, 220);
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
            this.txtA.Location = new System.Drawing.Point(63, 171);
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
            this.txtA.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtA.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Location = new System.Drawing.Point(23, 176);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(34, 15);
            this.rbA.TabIndex = 3;
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
            this.txtQuestion.Lines = new string[0];
            this.txtQuestion.Location = new System.Drawing.Point(0, 0);
            this.txtQuestion.MaxLength = 32767;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.PasswordChar = '\0';
            this.txtQuestion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuestion.SelectedText = "";
            this.txtQuestion.SelectionLength = 0;
            this.txtQuestion.SelectionStart = 0;
            this.txtQuestion.Size = new System.Drawing.Size(498, 150);
            this.txtQuestion.TabIndex = 2;
            this.txtQuestion.UseSelectable = true;
            this.txtQuestion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuestion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(12, 231);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(75, 36);
            this.butSave.TabIndex = 6;
            this.butSave.Text = "Save";
            this.butSave.UseSelectable = true;
            // 
            // butLoad
            // 
            this.butLoad.Location = new System.Drawing.Point(12, 189);
            this.butLoad.Name = "butLoad";
            this.butLoad.Size = new System.Drawing.Size(75, 36);
            this.butLoad.TabIndex = 5;
            this.butLoad.Text = "Load";
            this.butLoad.UseSelectable = true;
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(12, 95);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 23);
            this.butAdd.TabIndex = 4;
            this.butAdd.Text = "Add Item";
            this.butAdd.UseSelectable = true;
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Items.AddRange(new object[] {
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
            this.metroComboBox2.Location = new System.Drawing.Point(132, 50);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(49, 29);
            this.metroComboBox2.TabIndex = 3;
            this.metroComboBox2.UseSelectable = true;
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
            this.tabUdb.Size = new System.Drawing.Size(688, 269);
            this.tabUdb.TabIndex = 2;
            this.tabUdb.Text = "User Database";
            this.tabUdb.VerticalScrollbarBarColor = true;
            this.tabUdb.VerticalScrollbarHighlightOnWheel = false;
            this.tabUdb.VerticalScrollbarSize = 10;
            // 
            // butHotspot
            // 
            this.butHotspot.Location = new System.Drawing.Point(554, 372);
            this.butHotspot.Name = "butHotspot";
            this.butHotspot.Size = new System.Drawing.Size(165, 21);
            this.butHotspot.TabIndex = 2;
            this.butHotspot.Text = "Start Hotspot";
            this.butHotspot.UseSelectable = true;
            this.butHotspot.Click += new System.EventHandler(this.clickHotspot);
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(27, 399);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(692, 23);
            this.pb.Style = MetroFramework.MetroColorStyle.Blue;
            this.pb.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 440);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.butHotspot);
            this.Controls.Add(this.tabMenu);
            this.Controls.Add(this.chkTheme);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
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
        private MetroFramework.Controls.MetroProgressBar pb;
        private MetroFramework.Controls.MetroTabPage tabUser;
        private MetroFramework.Controls.MetroTabPage tabQuestion;
        private MetroFramework.Controls.MetroTabPage tabUdb;
        private MetroFramework.Controls.MetroPanel panelQuestion;
        private MetroFramework.Controls.MetroButton butSave;
        private MetroFramework.Controls.MetroButton butLoad;
        private MetroFramework.Controls.MetroButton butAdd;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage tabTitle;
        private MetroFramework.Controls.MetroTextBox txtD;
        private MetroFramework.Controls.MetroRadioButton rbD;
        private MetroFramework.Controls.MetroTextBox txtB;
        private MetroFramework.Controls.MetroRadioButton rbB;
        private MetroFramework.Controls.MetroTextBox txtC;
        private MetroFramework.Controls.MetroRadioButton rbC;
        private MetroFramework.Controls.MetroTextBox txtA;
        private MetroFramework.Controls.MetroRadioButton rbA;
        private MetroFramework.Controls.MetroTextBox txtQuestion;
    }
}

