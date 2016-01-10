namespace Desktop_IDE
{
    partial class createTest
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
            this.butLoad = new MetroFramework.Controls.MetroButton();
            this.txtItems = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtTotal = new MetroFramework.Controls.MetroTextBox();
            this.lblItems = new MetroFramework.Controls.MetroLabel();
            this.butCreate = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // butLoad
            // 
            this.butLoad.Location = new System.Drawing.Point(50, 149);
            this.butLoad.Name = "butLoad";
            this.butLoad.Size = new System.Drawing.Size(123, 41);
            this.butLoad.TabIndex = 0;
            this.butLoad.Text = "Load Question Files";
            this.butLoad.UseSelectable = true;
            this.butLoad.Click += new System.EventHandler(this.clickLoad);
            // 
            // txtItems
            // 
            // 
            // 
            // 
            this.txtItems.CustomButton.Image = null;
            this.txtItems.CustomButton.Location = new System.Drawing.Point(12, 1);
            this.txtItems.CustomButton.Name = "";
            this.txtItems.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtItems.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtItems.CustomButton.TabIndex = 1;
            this.txtItems.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtItems.CustomButton.UseSelectable = true;
            this.txtItems.CustomButton.Visible = false;
            this.txtItems.Lines = new string[] {
        "0"};
            this.txtItems.Location = new System.Drawing.Point(192, 102);
            this.txtItems.MaxLength = 3;
            this.txtItems.Name = "txtItems";
            this.txtItems.PasswordChar = '\0';
            this.txtItems.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItems.SelectedText = "";
            this.txtItems.SelectionLength = 0;
            this.txtItems.SelectionStart = 0;
            this.txtItems.Size = new System.Drawing.Size(34, 23);
            this.txtItems.TabIndex = 18;
            this.txtItems.Text = "0";
            this.txtItems.UseSelectable = true;
            this.txtItems.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtItems.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(50, 106);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(91, 19);
            this.metroLabel2.TabIndex = 17;
            this.metroLabel2.Text = "Items needed:";
            // 
            // txtTotal
            // 
            // 
            // 
            // 
            this.txtTotal.CustomButton.Image = null;
            this.txtTotal.CustomButton.Location = new System.Drawing.Point(12, 1);
            this.txtTotal.CustomButton.Name = "";
            this.txtTotal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotal.CustomButton.TabIndex = 1;
            this.txtTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotal.CustomButton.UseSelectable = true;
            this.txtTotal.CustomButton.Visible = false;
            this.txtTotal.Enabled = false;
            this.txtTotal.Lines = new string[] {
        "0"};
            this.txtTotal.Location = new System.Drawing.Point(192, 73);
            this.txtTotal.MaxLength = 32767;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionLength = 0;
            this.txtTotal.SelectionStart = 0;
            this.txtTotal.Size = new System.Drawing.Size(34, 23);
            this.txtTotal.TabIndex = 16;
            this.txtTotal.Text = "0";
            this.txtTotal.UseSelectable = true;
            this.txtTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(50, 73);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(122, 19);
            this.lblItems.TabIndex = 13;
            this.lblItems.Text = "Total Items Loaded:";
            // 
            // butCreate
            // 
            this.butCreate.Enabled = false;
            this.butCreate.Location = new System.Drawing.Point(234, 149);
            this.butCreate.Name = "butCreate";
            this.butCreate.Size = new System.Drawing.Size(123, 41);
            this.butCreate.TabIndex = 12;
            this.butCreate.Text = "Create Test ";
            this.butCreate.UseSelectable = true;
            this.butCreate.Click += new System.EventHandler(this.butCreate_Click);
            // 
            // createTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 223);
            this.Controls.Add(this.txtItems);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.butCreate);
            this.Controls.Add(this.butLoad);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "createTest";
            this.Resizable = false;
            this.Text = "Create Test File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton butLoad;
        private MetroFramework.Controls.MetroTextBox txtItems;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtTotal;
        private MetroFramework.Controls.MetroLabel lblItems;
        private MetroFramework.Controls.MetroButton butCreate;
    }
}