using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_IDE
{
    public static class testData
    {
        private static List<string> question = new List<string>();
        private static List<string> choice = new List<string>();
        private static List<string> ansA = new List<string>();
        private static List<string> ansB = new List<string>();
        private static List<string> ansC = new List<string>();
        private static List<string> ansD = new List<string>();
        static Random random = new Random();
        
        
        public static void clearItems()
        {
            strQuestion.Clear();
            strChoice.Clear();
            strA.Clear();
            strB.Clear();
            strC.Clear();
            strD.Clear();
        }

        
        public static bool save(string tmpfile)
        {
            SaveFileDialog sav = new SaveFileDialog()
            {
                Filter = "MEGA test file|*.mgt",
                Title = "Select test file"
            };
            if (sav.ShowDialog() == DialogResult.OK)
            {
                if (sav.FileName != "")
                {
                    
                    Crpyt.encrypt(tmpfile, sav.FileName);
                    otherFunctions.DeleteTmpFile(tmpfile);
                }
                return true;
            }
            else
                return false;
        }

        public static List<string> strQuestion
        {
            get { return question; }
            set { question = value; }
        }

        public static List<string> strChoice
        {
            get { return choice; }
            set { choice = value; }
        }
        public static List<string> strA
        {
            get { return ansA; }
            set { ansA = value; }
        }
        public static List<string> strB
        {
            get { return ansB; }
            set { ansB = value; }
        }
        public static List<string> strC
        {
            get { return ansC; }
            set { ansC = value; }
        }
        public static List<string> strD
        {
            get { return ansD; }
            set { ansD = value; }
        }

        
    }
}
