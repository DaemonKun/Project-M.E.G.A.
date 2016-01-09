namespace Desktop_IDE
{
    partial class Start
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
            this.panelLogin = new MetroFramework.Controls.MetroPanel();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.butLogin = new MetroFramework.Controls.MetroButton();
            this.textPassword = new MetroFramework.Controls.MetroTextBox();
            this.textUsername = new MetroFramework.Controls.MetroTextBox();
            this.panelLogin.SuspendLayout();
            this.gbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.gbLogin);
            this.panelLogin.HorizontalScrollbarBarColor = true;
            this.panelLogin.HorizontalScrollbarHighlightOnWheel = false;
            this.panelLogin.HorizontalScrollbarSize = 10;
            this.panelLogin.Location = new System.Drawing.Point(26, 63);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(690, 316);
            this.panelLogin.TabIndex = 9;
            this.panelLogin.VerticalScrollbarBarColor = true;
            this.panelLogin.VerticalScrollbarHighlightOnWheel = false;
            this.panelLogin.VerticalScrollbarSize = 10;
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.butLogin);
            this.gbLogin.Controls.Add(this.textPassword);
            this.gbLogin.Controls.Add(this.textUsername);
            this.gbLogin.Location = new System.Drawing.Point(434, 57);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(244, 229);
            this.gbLogin.TabIndex = 11;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Login";
            // 
            // butLogin
            // 
            this.butLogin.Location = new System.Drawing.Point(92, 157);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(117, 23);
            this.butLogin.TabIndex = 3;
            this.butLogin.Text = "Login";
            this.butLogin.UseSelectable = true;
            this.butLogin.Click += new System.EventHandler(this.clickLogin);
            // 
            // textPassword
            // 
            // 
            // 
            // 
            this.textPassword.CustomButton.Image = null;
            this.textPassword.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.textPassword.CustomButton.Name = "";
            this.textPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textPassword.CustomButton.TabIndex = 1;
            this.textPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textPassword.CustomButton.UseSelectable = true;
            this.textPassword.CustomButton.Visible = false;
            this.textPassword.Lines = new string[0];
            this.textPassword.Location = new System.Drawing.Point(39, 99);
            this.textPassword.MaxLength = 10;
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textPassword.SelectedText = "";
            this.textPassword.SelectionLength = 0;
            this.textPassword.SelectionStart = 0;
            this.textPassword.Size = new System.Drawing.Size(171, 23);
            this.textPassword.TabIndex = 2;
            this.textPassword.UseSelectable = true;
            this.textPassword.WaterMark = "Password";
            this.textPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textUsername
            // 
            // 
            // 
            // 
            this.textUsername.CustomButton.Image = null;
            this.textUsername.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.textUsername.CustomButton.Name = "";
            this.textUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textUsername.CustomButton.TabIndex = 1;
            this.textUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textUsername.CustomButton.UseSelectable = true;
            this.textUsername.CustomButton.Visible = false;
            this.textUsername.Lines = new string[0];
            this.textUsername.Location = new System.Drawing.Point(39, 46);
            this.textUsername.MaxLength = 10;
            this.textUsername.Name = "textUsername";
            this.textUsername.PasswordChar = '\0';
            this.textUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textUsername.SelectedText = "";
            this.textUsername.SelectionLength = 0;
            this.textUsername.SelectionStart = 0;
            this.textUsername.Size = new System.Drawing.Size(171, 23);
            this.textUsername.TabIndex = 1;
            this.textUsername.UseSelectable = true;
            this.textUsername.WaterMark = "Username";
            this.textUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 442);
            this.Controls.Add(this.panelLogin);
            this.Name = "Start";
            this.Text = "Project M.E.G.A.";
            this.panelLogin.ResumeLayout(false);
            this.gbLogin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelLogin;
        private System.Windows.Forms.GroupBox gbLogin;
        private MetroFramework.Controls.MetroButton butLogin;
        private MetroFramework.Controls.MetroTextBox textPassword;
        private MetroFramework.Controls.MetroTextBox textUsername;
    }
}