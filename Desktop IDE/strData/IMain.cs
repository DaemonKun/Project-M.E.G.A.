using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strData
{
    public interface IMain
    {
        string Question { get; set; }
        string AnswerA { get; set; }
        string AnswerB { get; set; }
        string AnswerC { get; set; }
        string AnswerD { get; set; }
        int Index { get; set; }
        bool A { get; set; }
        bool B { get; set; }
        bool C { get; set; }
        bool D { get; set; }

    }
}
