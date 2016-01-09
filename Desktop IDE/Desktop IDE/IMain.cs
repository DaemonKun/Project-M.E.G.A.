
namespace Desktop_IDE
{
    public interface IMain
    {
        string Question { get; set; }
        string AnswerA { get; set; }
        string AnswerB { get; set; }
        string AnswerC { get; set; }
        string AnswerD { get; set; }
        string Hotspot { get; set; }
        string Server { get; set; }
        int Index { get; }
        int Count { get; }
        bool A { get; set; }
        bool B { get; set; }
        bool C { get; set; }
        bool D { get; set; }
        bool StatusPrev { get; set; }
        bool StatusNext { get; set; }
        int MAX { get; set; }
        

    }
}
