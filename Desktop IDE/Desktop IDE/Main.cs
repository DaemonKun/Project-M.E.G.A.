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
using function;
using System.Threading;
using System.Net.Sockets;
using System.Net;

namespace Desktop_IDE
{
    public partial class Main : MetroForm,IMain
    {
        private static bool ServerHasStartup = false;
        public Main()
        {
            hotspot.initialize();
            InitializeComponent();
            strData.main = this;
            cbNumber.SelectedIndex = 0;
            this.StyleManager = msmMain;
            tabMenu.SelectedTab = tabQuestion;
            butPrevious.Enabled = false;
            tcpserver.Server = this;
            Thread startserver = new Thread(new ThreadStart(tcpserver.SetupServer));
            startserver.IsBackground = true;
            startserver.Start();            
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
            
            if(lbxServer.Items.Contains(IpEndPoint.ToString()))
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
            cbNumber.Items.Add(cbNumber.Items.Count + 1);
        }
        private void clickDelete(object sender, EventArgs e)
        {
            int prevIndex = cbNumber.SelectedIndex;
            int prevLastIndex = cbNumber.Items.Count - 1;
            int count = cbNumber.Items.Count;
            if ( count== 1)
            {
                butDelete.Enabled = false;
                return;
                
            }
            else
            {
                cbNumber.Items.RemoveAt(cbNumber.SelectedIndex);
            }

            cbNumber.Items.Clear();
            for(int i = 1; i<=(count-1);i++)
            {
                cbNumber.Items.Add(i);
            }
            strData.strQuestion = strData.strQuestion.Where((s, i) => i != prevIndex).ToArray();
            strData.strChoice = strData.strQuestion.Where((s, i) => i != prevIndex).ToArray();
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
                tbxFile.Text = otherFunctions.save.FileName;
                
            }
        }
        private void clickLoad(object sender, EventArgs e)
        {
            if (otherFunctions.openFile())
            {
                MetroMessageBox.Show(this, "File has been loaded", "Loaded",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbxFile.Text = otherFunctions.open.FileName;
                
            }
            
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
            set{rbA.Checked = value;}
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
        #endregion



        


                        
    }
}
