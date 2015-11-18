using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace function
{
    public static class otherFunctions
    {

        private static IMain main = strData.main;
        public static OpenFileDialog open = new OpenFileDialog();
        public static SaveFileDialog save = new SaveFileDialog();
        public static void enableDisablePrevNext()
        {
            try
            {
                if (main.Index == 0)
                {
                    main.StatusPrev = false;
                    main.StatusNext = true;
                }
                else if (main.Index == (main.Count - 1))
                {
                    main.StatusNext = false;
                    main.StatusPrev = true;
                }
                else
                {
                    main.StatusPrev = true;
                    main.StatusNext = true;
                }
            }
            catch(NullReferenceException)
            {
                return;
            }
        }
        public static bool openFile()
        {
            
            open.Filter = "MEGA questions|*.mgq";
            open.Title = "Select Question File";
            open.ShowDialog();
            if (open.FileName != "")
            {
                string temp = TmpFile();
                Crpyt.decrpyt(open.FileName, temp);
                ReadTmpFile(temp);
                strData.dispAnswer();
                strData.dispQuestion();
                DeleteTmpFile(temp);
                return true;
            }
            else
                return false;
        }
        public static bool saveFile()
        {
            
            strData.getAnswer();
            strData.getQuestion();
            save.Filter = "MEGA questions|*.mgq";
            save.Title = "Save Question File";
            save.ShowDialog();
            if (save.FileName != "")
            {
                string temp = TmpFile();
                WriteQuestions(temp);
                Crpyt.encrypt(temp, save.FileName);
                DeleteTmpFile(temp);
                return true;
            }
            else
                return false;
            
        }
        public static string TmpFile()
        {
            string fileName = string.Empty;
            try
            {
                fileName = Path.GetTempFileName();
                FileInfo fileInfo = new FileInfo(fileName);
                fileInfo.Attributes = FileAttributes.Temporary;

            }
            catch 
            {
                //
            }
            return fileName;
        }
        public static void DeleteTmpFile(string tmpFile)
        {
            try
            {
                // Delete the temp file (if it exists)
                if (File.Exists(tmpFile))
                {
                    File.Delete(tmpFile);
                    
                }
            }
            catch 
            {
               
            }
        }
        public static void WriteQuestions(string filename)
        {
            StreamWriter sw = new StreamWriter(filename);
            for (int i = 0; i < strData.strQuestion.Length; i++)
            {
                if ((strData.strQuestion[i] != null) && (strData.strAnswer[0][i] != null)
                    && (strData.strChoice[i] != null) && (strData.strAnswer[1][i] != null)
                    && (strData.strAnswer[2][i] != null) && (strData.strAnswer[3][i] != null))
                {
                    sw.WriteLine("<"+ (i + 1).ToString() + ">" + "<Q>:" + strData.strQuestion[i]);
                    sw.WriteLine("<"+ (i + 1).ToString() + ">" + "<A>:" + strData.strAnswer[0][i]);
                    sw.WriteLine("<" + (i + 1).ToString() + ">" + "<B>:" + strData.strAnswer[1][i]);
                    sw.WriteLine("<" + (i + 1).ToString() + ">" + "<C>:" + strData.strAnswer[2][i]);
                    sw.WriteLine("<" + (i + 1).ToString() + ">" + "<D>:" + strData.strAnswer[3][i]);
                    sw.WriteLine("<" + (i + 1).ToString() + ">" + "<Answer" + (i + 1).ToString() + ">:" + strData.strChoice[i] + "\n");
                    sw.Flush();
                }
                else
                    continue;
            }
            sw.Close();
        }

        public static void ReadTmpFile(string tmpfile)
        {
            string[] result = File.ReadAllLines(tmpfile);
            
            for(int i = 0;i<strData.strQuestion.Length;i++)
            {
                for(int j = 0;j<result.Length;j++)
                {
                    if(result[j].Contains("<"+(i+1).ToString()+">"))
                    {
                        if(result[j].Contains("<Q>:"))
                        {
                            strData.strQuestion[i] = result[j].Remove(0, result[j].IndexOf(":")+1);
                            
                        }
                        else if (result[j].Contains("<A>:"))
                        {
                            strData.strAnswer[0][i] = result[j].Remove(0, result[j].IndexOf(":")+1);
                            
                        }
                        else if (result[j].Contains("<B>:"))
                        {
                            strData.strAnswer[1][i] = result[j].Remove(0, result[j].IndexOf(":")+1);
                            
                        }
                        else if (result[j].Contains("<C>:"))
                        {
                            strData.strAnswer[2][i] = result[j].Remove(0, result[j].IndexOf(":")+1);
                            
                        }
                        else if (result[j].Contains("<D>:"))
                        {
                            strData.strAnswer[3][i] = result[j].Remove(0, result[j].IndexOf(":")+1);
                            
                        }
                        else if (result[j].Contains("<Answer>:"))
                        {
                            strData.strChoice[i] = result[j].Remove(0, result[j].IndexOf(":")+1);
                            
                        }
                        
                    }
                    
                }
            }
        }
        
    }
}
