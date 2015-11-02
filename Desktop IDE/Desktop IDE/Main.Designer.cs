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
            this.Users = new System.Windows.Forms.TabPage();
            this.Question = new System.Windows.Forms.TabPage();
            this.Database = new System.Windows.Forms.TabPage();
            this.butHotspot = new MetroFramework.Controls.MetroButton();
            this.pb = new MetroFramework.Controls.MetroProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            this.tabMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msmMain
            // 
            this.msmMain.Owner = this;
            this.msmMain.Style = MetroFramework.MetroColorStyle.White;
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
            this.tabMenu.Controls.Add(this.Users);
            this.tabMenu.Controls.Add(this.Question);
            this.tabMenu.Controls.Add(this.Database);
            this.tabMenu.Location = new System.Drawing.Point(23, 55);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(570, 311);
            this.tabMenu.Style = MetroFramework.MetroColorStyle.Black;
            this.tabMenu.TabIndex = 1;
            this.tabMenu.UseSelectable = true;
            // 
            // Users
            // 
            this.Users.Location = new System.Drawing.Point(4, 38);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(562, 269);
            this.Users.TabIndex = 0;
            this.Users.Text = "Users";
            // 
            // Question
            // 
            this.Question.Location = new System.Drawing.Point(4, 38);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(562, 269);
            this.Question.TabIndex = 1;
            this.Question.Text = "Questions";
            // 
            // Database
            // 
            this.Database.Location = new System.Drawing.Point(4, 38);
            this.Database.Name = "Database";
            this.Database.Size = new System.Drawing.Size(562, 269);
            this.Database.TabIndex = 2;
            this.Database.Text = "Database";
            // 
            // butHotspot
            // 
            this.butHotspot.Location = new System.Drawing.Point(424, 372);
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
            this.pb.Size = new System.Drawing.Size(562, 23);
            this.pb.Style = MetroFramework.MetroColorStyle.Blue;
            this.pb.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 440);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.butHotspot);
            this.Controls.Add(this.tabMenu);
            this.Controls.Add(this.chkTheme);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Project M.E.G.A.";
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.tabMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager msmMain;
        private MetroFramework.Controls.MetroCheckBox chkTheme;
        private MetroFramework.Controls.MetroTabControl tabMenu;
        private MetroFramework.Controls.MetroButton butHotspot;
        private System.Windows.Forms.TabPage Users;
        private System.Windows.Forms.TabPage Question;
        private System.Windows.Forms.TabPage Database;
        private MetroFramework.Controls.MetroProgressBar pb;
    }
}

