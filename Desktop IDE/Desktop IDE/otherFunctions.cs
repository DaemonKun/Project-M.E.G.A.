using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace Desktop_IDE
{
    public static class otherFunctions
    {

        private static IMain main = strData.main;
        public static string savefile = string.Empty;
        public static string openfile = string.Empty;
        public static string tmpTest = string.Empty;
        public static void enableDisablePrevNext()
        {
            try
            {
                if (main.Index == 0)
                {
                    main.StatusPrev = false;
                    main.StatusNext = true;
                }
                else if (main.Index == 1)
                {
                    main.StatusNext = false;
                    main.StatusPrev = false;
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
        public static bool openTest()
        {
            OpenFileDialog open = new OpenFileDialog() { 
            Filter = "MEGA test file|*.mgt",
            Title = "Select test file"
            };

            if (open.ShowDialog() == DialogResult.OK)
            {
                if ((open.FileName != "") && (open.FileName.Contains(".mgt")))
                {
                    tmpTest = TmpFile();
                    Crpyt.decrpyt(open.FileName, tmpTest);
                    ReadTmpFile(tmpTest);
                    openfile = open.FileName;
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
            
        }
        public static bool openQuestion()
        {
            OpenFileDialog open = new OpenFileDialog()
            {
                Filter = "MEGA question file|*.mgq",
                Title = "Select test file"
            };
            if (!open.FileName.Equals(""))
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

            SaveFileDialog save = new SaveFileDialog()
            {
                Filter = "MEGA questions|*.mgq",
                Title = "Save Question File"
            };
            strData.getAnswer();
            strData.getQuestion();
            save.ShowDialog();
            if (save.FileName != "")
            {
                string temp = TmpFile();
                WriteQuestions(temp);
                Crpyt.encrypt(temp, save.FileName);
                DeleteTmpFile(temp);
                savefile = save.FileName;
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
            
            
            sw.Close();
        }
        public static void ReadTmpFile(string tmpfile)
        {
            
            string[] result = File.ReadAllLines(tmpfile);

        }

        public static int checkAnswers(string tmpfile)
        {
            int score = 0;
            string[] result = File.ReadAllLines(tmpfile);

            for (int i = 1; i < result.Length; i++)
            {

                if (result[i].Contains(i.ToString()))
                {

                    result[i] = result[i].Remove(0, result[i].IndexOf(":") + 1);
                    if (strData.strChoice[i-1].Equals(result[i]))
                    {
                        score++;
                    }
                }
            }


            return score;
        }
    }
}
