using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_IDE
{
    public partial class Start : MetroForm
    {
        public Main m = new Main();
        public Start()
        {
            InitializeComponent();
        }

        
        private void clickLogin(object sender, EventArgs e)
        {
            MySqlConnection conn = mysqlCon.conn();
            MySqlCommand selectCommand = new MySqlCommand("SELECT * FROM u614761466_mega.logindata WHERE user_name='"
                + this.textUsername.Text + "' AND password='" + this.textPassword.Text + "' ;", conn);
            MySqlDataReader reader;
            try
            {
                

                conn.Open();
                reader = selectCommand.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    string isAdmin = reader.GetString("isAdmin");
                    if (isAdmin.ToLower().Equals("false"))
                    {
                        m.tabMenu.TabPages.Remove(m.tabRegister);
                    }
                    count++;
                }
                if (count == 1)
                {

                    DialogResult dr = MetroMessageBox.Show(this, "Login successfully", "Succesful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        reader.Close();
                        conn.Close();
                        this.Hide();
                        
                        m.Show();
                        
                    }
                }
                else if (count > 1)
                {
                    MetroMessageBox.Show(this, "Multiple Accounts Registered. Login Failed", "Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MetroMessageBox.Show(this, "Wrong Username or Password. Login Failed", "Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conn.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
