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
        public static Test test;
        public static string savefile = string.Empty;
        public static string openfile = string.Empty;
        public static string tmpTest = string.Empty;
        public static void enableDisablePrevNext()
        {
            try
            {
                if ((main.Index == 0) && (main.Count == 1))
                {
                    main.StatusPrev = false;
                    main.StatusNext = false;
                }
                else if ((main.Index == 0))
                {
                    main.StatusNext = true;
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
                    testData.clearItems();
                    tmpTest = TmpFile();
                    Crpyt.decrpyt(open.FileName, tmpTest);
                    ReadTestData(tmpTest);
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
            open.ShowDialog();
            if ((open.FileName != "")&&(open.FileName.EndsWith(".mgq")))
            {
                string temp = TmpFile();
                Crpyt.decrpyt(open.FileName, temp);
                strData.clearItems();
                ReadTmpFile(temp);
                
                DeleteTmpFile(temp);
                return true;
            }
            else
                return false;
        }
        public static bool LoadQuestions()
        {
            OpenFileDialog open = new OpenFileDialog()
            {
                Filter = "MEGA question file|*.mgq",
                Title = "Select question file(s)",
                Multiselect = true
            };
            if (open.ShowDialog() == DialogResult.OK)
            {
                strData.clearItems();
                foreach (string file in open.FileNames)
                {
                    string temp = TmpFile();
                    Crpyt.decrpyt(file, temp);
                    ReadTmpFile(temp);
                    DeleteTmpFile(temp);
                }
                test.max = strData.strQuestion.Count;
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
            strData.deleteNull();

            for (int i = 0; i < strData.strQuestion.Count; i++)
            {
                sw.WriteLine("<" + (i + 1).ToString() + "><Q>:" + strData.strQuestion[i]);
                sw.WriteLine("<" + (i + 1).ToString() + "><A>:" + strData.strA[i]);
                sw.WriteLine("<" + (i + 1).ToString() + "><B>:" + strData.strB[i]);
                sw.WriteLine("<" + (i + 1).ToString() + "><C>:" + strData.strC[i]);
                sw.WriteLine("<" + (i + 1).ToString() + "><D>:" + strData.strD[i]);
                sw.WriteLine("<" + (i + 1).ToString() + "><Answer>:" + strData.strChoice[i]);
            }
                sw.Close();
        }
        public static void ReadTmpFile(string tmpfile)
        {
            
            string[] result = File.ReadAllLines(tmpfile);
            for (int i = 0; i < 1024; i++)
            {
                for (int j = 0; j < result.Length; j++ )
                {
                    if (result[j].Contains((i + 1).ToString()))
                    {
                        if (result[j].Contains("<Q>"))
                        {
                            strData.strQuestion.Add(result[j].Remove(0, result[j].IndexOf(":") + 1));
                        }
                        else if (result[j].Contains("<A>"))
                        {
                            strData.strA.Add(result[j].Remove(0, result[j].IndexOf(":") + 1));
                        }
                        else if (result[j].Contains("<B>"))
                        {
                            strData.strB.Add(result[j].Remove(0, result[j].IndexOf(":") + 1));
                        }
                        else if (result[j].Contains("<C>"))
                        {
                            strData.strC.Add(result[j].Remove(0, result[j].IndexOf(":") + 1));
                        }
                        else if (result[j].Contains("<D>"))
                        {
                            strData.strD.Add(result[j].Remove(0, result[j].IndexOf(":") + 1));
                        }
                        else if (result[j].Contains("<Answer>"))
                        {
                            strData.strChoice.Add(result[j].Remove(0, result[j].IndexOf(":") + 1));
                        }
                    }
                }
                
            }
            main.MAX = strData.strQuestion.Count;

        }
        public static void ReadTestData(string tmpfile)
        {
            string[] result = File.ReadAllLines(tmpfile);
            for (int i = 0; i < 1024; i++)
            {
                for (int j = 0; j < result.Length; j++)
                {
                    if (result[j].Contains((i + 1).ToString()))
                    {
                        if (result[j].Contains("<Q>"))
                        {
                            testData.strQuestion.Add(result[j].Remove(0, result[j].IndexOf(":") + 1));
                        }
                        else if (result[j].Contains("<A>"))
                        {
                            testData.strA.Add(result[j].Remove(0, result[j].IndexOf(":") + 1));
                        }
                        else if (result[j].Contains("<B>"))
                        {
                            testData.strB.Add(result[j].Remove(0, result[j].IndexOf(":") + 1));
                        }
                        else if (result[j].Contains("<C>"))
                        {
                            testData.strC.Add(result[j].Remove(0, result[j].IndexOf(":") + 1));
                        }
                        else if (result[j].Contains("<D>"))
                        {
                            testData.strD.Add(result[j].Remove(0, result[j].IndexOf(":") + 1));
                        }
                        else if (result[j].Contains("<Answer>"))
                        {
                            testData.strChoice.Add(result[j].Remove(0, result[j].IndexOf(":") + 1));
                        }
                    }
                }

            }
            
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
                    if (testData.strChoice[i-1].Equals(result[i]))
                    {
                        score++;
                    }
                }
            }


            return score;
        }
    }
}
