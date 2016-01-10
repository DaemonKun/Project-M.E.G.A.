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
using System.Reflection;

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
            fillcomboSubjects();
            dgUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dgUser.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgUser.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgUser.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            


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
            dgUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dgUser.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgUser.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgUser.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
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
            finally
            {
                lblMax.Text = cbNumber.Items.Count.ToString();
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
            finally
            {
                lblMax.Text = cbNumber.Items.Count.ToString();
            }
        }
        private void clickAdd(object sender, EventArgs e)
        {
            int count = cbNumber.Items.Count;
            cbNumber.Items.Add(cbNumber.Items.Count + 1);
            strData.strQuestion.Add(null);
            strData.strChoice.Add(null);
            strData.strA.Add(null);
            strData.strB.Add(null);
            strData.strC.Add(null);
            strData.strD.Add(null);
            if (count == cbNumber.SelectedIndex + 1)
            {
                cbNumber.SelectedIndex = cbNumber.Items.Count - 1;
            }
            lblMax.Text = cbNumber.Items.Count.ToString();
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
            strData.strQuestion.RemoveAt(prevIndex);
            strData.strChoice.RemoveAt(prevIndex);
            strData.strA.RemoveAt(prevIndex);
            strData.strB.RemoveAt(prevIndex);
            strData.strC.RemoveAt(prevIndex);
            strData.strD.RemoveAt(prevIndex);
            if ((prevIndex != 0) && (prevIndex != prevLastIndex))
                cbNumber.SelectedIndex = prevIndex;
            else if (prevIndex == prevLastIndex)
                cbNumber.SelectedIndex = prevIndex - 1;
            else
                cbNumber.SelectedIndex = 0;
            lblMax.Text = cbNumber.Items.Count.ToString();
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
            if (!string.IsNullOrWhiteSpace(Question) || !string.IsNullOrWhiteSpace(AnswerA) ||
                    !string.IsNullOrWhiteSpace(AnswerB) || !string.IsNullOrWhiteSpace(AnswerC) ||
                    !string.IsNullOrWhiteSpace(AnswerD))
            {
                strData.getQuestion();
                strData.getAnswer();
            }
                
            
            if (otherFunctions.saveFile())
            {
                MetroMessageBox.Show(this, "File has been saved", "Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            }
        }
        private void clickLoad(object sender, EventArgs e)
        {
            if (otherFunctions.openQuestion())
            {
                MetroMessageBox.Show(this, "File has been loaded", "Loaded",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);


                lblMax.Text = Max.ToString();
                cbNumber.Items.Clear();
                while (Max != cbNumber.Items.Count)
                {
                    cbNumber.Items.Add(cbNumber.Items.Count + 1);
                }
                cbNumber.SelectedIndex = 0;
                strData.dispAnswer();
                strData.dispQuestion();
                otherFunctions.enableDisablePrevNext();

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
                System.Windows.Forms.Application.Exit();
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
                catch (Exception)
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


            _crtTest.ShowDialog();
            _crtTest.Dispose();
            
            
        }

        void fillcomboExam()
        {
            DataTable schema = null;
            using (var con = mysqlCon.conn())
            {
                using (var schemaCommand = new MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM u614761466_mega."
                    + cmbSubject.SelectedItem.ToString() + ";", con))
                {
                    con.Open();
                    using (var reader = schemaCommand.ExecuteReader(CommandBehavior.SchemaOnly))
                    {
                        schema = reader.GetSchemaTable();
                    }
                }
            }
            foreach (DataRow col in schema.Rows)
            {
                if (col.Field<string>("ColumnName").Contains("Quiz")||col.Field<string>("ColumnName").Contains("ME")||
                    col.Field<string>("ColumnName").Contains("FE"))
                    cmbExam.Items.Add(col.Field<string>("ColumnName"));
            }
            
        }
        void fillcomboSubjects()
        {
            string query = "SELECT * FROM u614761466_mega.SubjectEnrolled;";
            var con = mysqlCon.conn();
            var cmd = new MySqlCommand(query, con);
            MySqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (!cmbSubject.Items.Contains(reader.GetString("Subject1")))
                        cmbSubject.Items.Add(reader.GetString("Subject1"));
                    else if (!cmbSubject.Items.Contains(reader.GetString("Subject2")))
                        cmbSubject.Items.Add(reader.GetString("Subject2"));
                    else if (!cmbSubject.Items.Contains(reader.GetString("Subject3")))
                        cmbSubject.Items.Add(reader.GetString("Subject3"));
                    else if (!cmbSubject.Items.Contains(reader.GetString("Subject4")))
                        cmbSubject.Items.Add(reader.GetString("Subject4"));
                }
                reader.Close();
            }
            catch(Exception)
            {
                
            }
            finally
            {
                con.Close();
            }

        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbExam.Items.Clear();
            fillcomboExam();
            lblSubject.Text = "Subject: " + cmbSubject.SelectedItem.ToString();
            tcpserver.subject = cmbSubject.SelectedItem.ToString();
            updateDG();
        }

        private void cmbExam_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblExam.Text = "Exam: " + cmbExam.SelectedItem.ToString();
            tcpserver.exam = cmbSubject.SelectedItem.ToString();
        }

        private void changeMenu(object sender, EventArgs e)
        {
            
        }


        private void ExportToExcel(DataGridView dgView)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = null;
            try
            {
                // instantiating the excel application class
                excelApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook currentWorkbook = excelApp.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel.Worksheet currentWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)currentWorkbook.ActiveSheet;
                currentWorksheet.Columns.ColumnWidth = 18;


                if (dgView.Rows.Count > 0)
                {
                    currentWorksheet.Cells[1, 1] = cmbSubject.SelectedItem.ToString();
                    int i = 1;
                    foreach (DataGridViewColumn dgviewColumn in dgView.Columns)
                    {
                        // Excel work sheet indexing starts with 1
                        currentWorksheet.Cells[2, i] = dgviewColumn.Name;
                        ++i;
                    }
                    Microsoft.Office.Interop.Excel.Range headerColumnRange = currentWorksheet.get_Range("A2", "T2");
                    headerColumnRange.Font.Bold = true;
                    headerColumnRange.Font.Color = 0xFF0000;
                    //headerColumnRange.EntireColumn.AutoFit();
                    int rowIndex = 0;
                    for (rowIndex = 0; rowIndex < dgView.Rows.Count; rowIndex++)
                    {
                        DataGridViewRow dgRow = dgView.Rows[rowIndex];
                        for (int cellIndex = 0; cellIndex < dgRow.Cells.Count; cellIndex++)
                        {
                            currentWorksheet.Cells[rowIndex + 3, cellIndex + 1] = dgRow.Cells[cellIndex].Value;
                        }
                    }
                    Microsoft.Office.Interop.Excel.Range fullTextRange = currentWorksheet.get_Range("A1", "G" + (rowIndex + 1).ToString());
                    fullTextRange.WrapText = true;
                    fullTextRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                }
                else
                {
                    currentWorksheet.Cells[1, 1] = tcpserver.subject;
                    
                }
                
                using (SaveFileDialog exportSaveFileDialog = new SaveFileDialog())
                {
                    exportSaveFileDialog.Title = "Select Excel File";
                    exportSaveFileDialog.Filter = "Microsoft Office Excel Workbook(*.xlsx)|*.xlsx";

                    if (DialogResult.OK == exportSaveFileDialog.ShowDialog())
                    {
                        string fullFileName = exportSaveFileDialog.FileName;
                        // currentWorkbook.SaveCopyAs(fullFileName);
                        // indicating that we already saved the workbook, otherwise call to Quit() will pop up
                        // the save file dialogue box

                        currentWorkbook.SaveAs(fullFileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbook, System.Reflection.Missing.Value, Missing.Value, false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Microsoft.Office.Interop.Excel.XlSaveConflictResolution.xlUserResolution, true, Missing.Value, Missing.Value, Missing.Value);
                        currentWorkbook.Saved = true;
                        MetroMessageBox.Show(this,"Database exported successfully", "Exported to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (excelApp != null)
                {
                    excelApp.Quit();
                }
            }



        }

        private void clickExport(object sender, EventArgs e)
        {
            ExportToExcel(dgUser);
        }
        private void updateDG()
        {
            if ((cmbSubject.SelectedItem != null))
            {
                string query = "SELECT * FROM u614761466_mega." + tcpserver.subject + " ;";
                using (var con = mysqlCon.conn())
                {
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var sda = new MySqlDataAdapter())
                        {
                            sda.SelectCommand = cmd;
                            DataTable dataset = new DataTable();
                            sda.Fill(dataset);
                            BindingSource bsource = new BindingSource();
                            bsource.DataSource = dataset;
                            dgUser.DataSource = bsource;
                            sda.Update(dataset);

                        }
                    }
                }
            }
        }










    }
}
