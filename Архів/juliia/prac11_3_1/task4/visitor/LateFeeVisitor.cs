namespace visitor;

public class LateFeeVisitor : IVisitor
{
    public decimal TotalPenalty { get; private set; } = 0;
    
    public void Visit(Book book)
    {
        if (book.DaysLate > 0)
        {
            decimal penalty = book.DaysLate * 5.0m;
            Console.WriteLine($"Книга '{book.Title}' протермінована на {book.DaysLate} днів. Штраф: {penalty} грн.");
            TotalPenalty += penalty;
        }
    }
    
    public void Visit(Magazine magazine)
    {
        if (magazine.DaysLate > 0)
        {
            decimal penalty = magazine.DaysLate * 2.0m;
            Console.WriteLine($"Журнал '{magazine.Title}' (Випуск {magazine.IssueNumber}) протермінований на {magazine.DaysLate} днів. Штраф: {penalty} грн.");
            TotalPenalty += penalty;
        }
    }
}