using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_IDE
{
    public static class strData
    {
        public static IMain main;
        private const int items = 10;
        #region string declariations
        
        private static List<string> question = new List<string>();
        private static List<string> choice = new List<string>();
        private static List<string> ansA = new List<string>();
        private static List<string> ansB = new List<string>();
        private static List<string> ansC = new List<string>();
        private static List<string> ansD = new List<string>();

        #endregion
        public static void initialize()
        {
            clearItems();
            for (int i = 0; i < items; i++)
            {
                question.Add(null);
                choice.Add(null);
                ansA.Add(null);
                ansB.Add(null);
                ansC.Add(null);
                ansD.Add(null);

            }
        }
        public static void getQuestion()
        {
            strQuestion[main.Index] = main.Question;
        }
        public static void getAnswer()
        {
            strA[main.Index] = main.AnswerA;
            strB[main.Index] = main.AnswerB;
            strC[main.Index] = main.AnswerC;
            strD[main.Index] = main.AnswerD;
            if (main.A)
            {
                strChoice[main.Index] = "A";
            }
            else if (main.B)
            {
                strChoice[main.Index] = "B";
            }
            else if (main.C)
            {
                strChoice[main.Index] = "C";
            }
            else
                strChoice[main.Index] = "D";


        }
        public static void dispQuestion()
        {
            try
            {
                main.Question = strQuestion[main.Index];
            }
            catch (NullReferenceException)
            {

            }


        }
        public static void dispAnswer()
        {
            main.AnswerA = strA[main.Index];
            main.AnswerB = strB[main.Index];
            main.AnswerC = strC[main.Index];
            main.AnswerD = strD[main.Index];
            try
            {
                if (strChoice[main.Index] == "A")
                {
                    main.A = true;
                }
                else if (strChoice[main.Index] == "B")
                {
                    main.B = true;
                }
                else if (strChoice[main.Index] == "C")
                {
                    main.C = true;
                }
                else if (strChoice[main.Index] == "D")
                {
                    main.D = true;
                }
                else
                    main.A = true;
            }
            catch (System.NullReferenceException)
            {

            }
        }
        public static void deleteNull()
        {
            strQuestion.RemoveAll(item => item == null);
            strChoice.RemoveAll(item => item == null);
            strA.RemoveAll(item => item == null);
            strB.RemoveAll(item => item == null);
            strC.RemoveAll(item => item == null);
            strD.RemoveAll(item => item == null);
        }
        public static void clearItems()
        {
            strQuestion.Clear();
            strChoice.Clear();
            strA.Clear();
            strB.Clear();
            strC.Clear();
            strD.Clear();
        }
        public static List<string> strQuestion
        {
            get { return question; }
            set { question = value; }
        }

        public static List<string> strChoice
        {
            get { return choice; }
            set { choice  = value; }
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
