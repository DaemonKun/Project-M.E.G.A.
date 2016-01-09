using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

using System.Threading;
using System.Net.Sockets;
using System.Net;
using MetroFramework.Controls;
using MySql.Data.MySqlClient;

namespace Desktop_IDE
{
    public partial class Main : MetroForm, IMain
    {
        public static Thread startserver;
        private static int Max;




        public Main()
        {
            startserver = new Thread(tcpserver.SetupServer);
            hotspot.initialize();
            strData.initialize();
            InitializeComponent();
            hotspot.main = this;
            strData.main = this;
            tcpserver.main = this;
            tcpserver.Server = this;
            cbNumber.SelectedIndex = 0;
            this.StyleManager = msmMain;
            tabMenu.SelectedTab = tabUser;
            butPrevious.Enabled = false;
            tcpserver.file = this.tbxFile.Text;


        }
        private void checkTheme(object sender, EventArgs e)
        {
            if (chkTheme.Checked)
            {
                msmMain.Theme = MetroFramework.MetroThemeStyle.Dark;
                msmMain.Style = MetroFramework.MetroColorStyle.Green;

            }
            else
            {
                msmMain.Style = MetroFramework.MetroColorStyle.Blue;
                msmMain.Theme = MetroFramework.MetroThemeStyle.Light;

            }
        }
        private void changeNum(object sender, EventArgs e)
        {
            lblQuestion.Text = "Question " + cbNumber.SelectedItem;

            strData.dispAnswer();
            strData.dispQuestion();
            otherFunctions.enableDisablePrevNext();
        }

        public void AddClient(IPEndPoint IpEndPoint)
        {

            if (lbxServer.Items.Contains(IpEndPoint.ToString()))
            {
                return;
            }
            else
            {
                lbxServer.BeginUpdate();
                lbxServer.Items.Add(IpEndPoint.ToString());
                lbxServer.EndUpdate();
            }

        }

        #region Click Events
        private void clickLogin(object sender, EventArgs e)
        {

        }

        private void clickPrevious(object sender, EventArgs e)
        {
            try
            {
                cbNumber.SelectedIndex -= 1;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }

        }
        private void clickNext(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Question) || string.IsNullOrWhiteSpace(AnswerA) ||
                    string.IsNullOrWhiteSpace(AnswerB) || string.IsNullOrWhiteSpace(AnswerC) ||
                    string.IsNullOrWhiteSpace(AnswerD))
                {
                    MetroMessageBox.Show(this, "You must fill the fields before pressing next", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    strData.getQuestion();
                    strData.getAnswer();
                    cbNumber.SelectedIndex += 1;
                }
            }

            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }
        }
        private void clickAdd(object sender, EventArgs e)
        {
            int count = cbNumber.Items.Count;
            cbNumber.Items.Add(cbNumber.Items.Count + 1);
            if (count == cbNumber.SelectedIndex + 1)
            {
                cbNumber.SelectedIndex = cbNumber.Items.Count - 1;
            }
        }
        private void clickDelete(object sender, EventArgs e)
        {
            int prevIndex = cbNumber.SelectedIndex;
            int prevLastIndex = cbNumber.Items.Count - 1;
            int count = cbNumber.Items.Count;
            if (count == 1)
            {
                butDelete.Enabled = false;
                return;

            }
            else
            {
                cbNumber.Items.RemoveAt(cbNumber.SelectedIndex);
            }

            cbNumber.Items.Clear();
            for (int i = 1; i <= (count - 1); i++)
            {
                cbNumber.Items.Add(i);
            }
            strData.strQuestion = strData.strQuestion.Where((s, i) => i != prevIndex).ToArray();
            strData.strChoice = strData.strChoice.Where((s, i) => i != prevIndex).ToArray();
            strData.strAnswer[0] = strData.strAnswer[0].Where((s, i) => i != prevIndex).ToArray();
            strData.strAnswer[1] = strData.strAnswer[1].Where((s, i) => i != prevIndex).ToArray();
            strData.strAnswer[2] = strData.strAnswer[2].Where((s, i) => i != prevIndex).ToArray();
            strData.strAnswer[3] = strData.strAnswer[3].Where((s, i) => i != prevIndex).ToArray();
            if ((prevIndex != 0) && (prevIndex != prevLastIndex))
                cbNumber.SelectedIndex = prevIndex;
            else if (prevIndex == prevLastIndex)
                cbNumber.SelectedIndex = prevIndex - 1;
            else
                cbNumber.SelectedIndex = 0;

        }
        private void clickClear(object sender, EventArgs e)
        {
            Question = null;
            AnswerA = null;
            AnswerB = null;
            AnswerC = null;
            AnswerD = null;
            strData.getAnswer();
            strData.getQuestion();
        }
        private void clickHotspot(object sender, EventArgs e)
        {
            hotspot.startStop();
        }
        private void clickSave(object sender, EventArgs e)
        {
            if (otherFunctions.saveFile())
            {
                MetroMessageBox.Show(this, "File has been saved", "Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxFile.Text = otherFunctions.savefile;

            }
        }
        private void clickLoad(object sender, EventArgs e)
        {
            if (otherFunctions.openQuestion())
            {
                MetroMessageBox.Show(this, "File has been loaded", "Loaded",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                

                if (Max < 10)
                {
                    while (Max != cbNumber.Items.Count)
                    {
                        cbNumber.Items.RemoveAt(cbNumber.Items.Count - 1);
                    }
                }
                else
                {
                    while ((Max != cbNumber.Items.Count) && (Max > 10))
                    {
                        cbNumber.Items.Add(cbNumber.Items.Count + 1);
                    }
                }

            }

        }
        private void clickServer(object sender, EventArgs e)
        {

            startserver.IsBackground = true;
            startserver.Start();
            butHotspot.Enabled = false;
            butServer.Enabled = false;
        }

        #endregion

        #region DLL Variable Declarations

        public string Question
        {
            get { return txtQuestion.Text; }
            set { txtQuestion.Text = value; }
        }
        public string AnswerA
        {
            get { return txtA.Text; }
            set { txtA.Text = value; }
        }
        public string AnswerB
        {
            get { return txtB.Text; }
            set { txtB.Text = value; }
        }
        public string AnswerC
        {
            get { return txtC.Text; }
            set { txtC.Text = value; }
        }
        public string AnswerD
        {
            get { return txtD.Text; }
            set { txtD.Text = value; }
        }
        public string Hotspot
        {
            get { return butHotspot.Text; }
            set { butHotspot.Text = value; }
        }
        public string Server
        {
            get { return butServer.Text; }
            set { butServer.Text = value; }
        }
        public int Index
        {
            get { return cbNumber.SelectedIndex; }
        }
        public int Count
        {
            get { return cbNumber.Items.Count; }
        }
        public bool A
        {
            get { return rbA.Checked; }
            set { rbA.Checked = value; }
        }
        public bool B
        {
            get { return rbB.Checked; }
            set { rbB.Checked = value; }
        }
        public bool C
        {
            get { return rbC.Checked; }
            set { rbC.Checked = value; }
        }
        public bool D
        {
            get { return rbD.Checked; }
            set { rbD.Checked = value; }
        }
        public bool StatusPrev
        {
            get { return butPrevious.Enabled; }
            set { butPrevious.Enabled = value; }
        }
        public bool StatusNext
        {
            get { return butNext.Enabled; }
            set { butNext.Enabled = value; }
        }
        public int MAX
        {
            get { return Max; }
            set { Max = value; }
        }
        #endregion

        private void atClose(object sender, FormClosingEventArgs e)
        {
            try
            {

                startserver.Abort();
                hotspot.exit();

            }
            catch (SocketException)
            {
                //nothing;
            }
            finally
            {
                Application.Exit();
            }

        }

        private void selectClient(object sender, EventArgs e)
        {

            mpUser.Visible = true;
            if (tcpserver.user.ContainsKey(lbxServer.SelectedItem.ToString()))
            {
                string query = "SELECT * FROM u614761466_mega.users WHERE RFID_tags='"
                    + tcpserver.user[lbxServer.SelectedItem.ToString()] + "' ;";

                MySqlConnection conn = mysqlCon.conn();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader;
                try
                {
                    conn.Open();
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        lblId.Text = "ID number: " +  reader.GetInt32("studentnum").ToString();
                        lblUser.Text = "User: " +  reader.GetString("FirstName") + " " 
                            + reader.GetString("LastName");
                        
                    }
                    reader.Close();
                }
                catch (Exception x)
                {

                }
                finally
                {
                    conn.Close();
                }
            }

        }

        private void butLoadTest_Click(object sender, EventArgs e)
        {
            if (otherFunctions.openTest())
            {
                MetroMessageBox.Show(this, "File has been loaded", "Loaded",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxFile.Text = otherFunctions.openfile;
            }
        }

        private void clickCreate(object sender, EventArgs e)
        {
            createTest _crtTest = new createTest();
            _crtTest.StyleManager = msmMain;

            _crtTest.ShowDialog();
            
            _crtTest.Dispose();
        }

        














    }
}
