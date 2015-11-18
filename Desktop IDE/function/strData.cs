using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function
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
            
            public static string[] strQuestion = new string[items];
            public static string[] strChoice = new string[items];
            #endregion
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
                catch(NullReferenceException)
                {
                    return;
                }
            }
            public static void dispAnswer()
            {
                try
                {
                    main.AnswerA = strAnswer[0][main.Index];
                    main.AnswerB = strAnswer[1][main.Index];
                    main.AnswerC = strAnswer[2][main.Index];
                    main.AnswerD = strAnswer[3][main.Index];

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
                catch(NullReferenceException)
                {
                    return;
                }

            }
    }
}
