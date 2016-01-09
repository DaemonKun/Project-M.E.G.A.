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
        private const int items = 1024;
        #region string declariations
        public static string[][] strAnswer =
            {
                new string[items],
                new string[items],
                new string[items],
                new string[items],
            };

        private static string[] question;
        private static string[] Choice;


        #endregion
        public static void initialize()
        {
            question = new string[items];
            Choice = new string[items];
        }
        public static void getQuestion()
        {
            strQuestion[main.Index] = main.Question;
        }
        public static void getAnswer()
        {
            strAnswer[0][main.Index] = main.AnswerA;
            strAnswer[1][main.Index] = main.AnswerB;
            strAnswer[2][main.Index] = main.AnswerC;
            strAnswer[3][main.Index] = main.AnswerD;
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
            main.AnswerA = strAnswer[0][main.Index];
            main.AnswerB = strAnswer[1][main.Index];
            main.AnswerC = strAnswer[2][main.Index];
            main.AnswerD = strAnswer[3][main.Index];
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
        public static string[] strQuestion
        {
            get { return question; }
            set { question = value; }
        }

        public static string[] strChoice
        {
            get { return Choice; }
            set { Choice  = value; }
        }

    }
}
