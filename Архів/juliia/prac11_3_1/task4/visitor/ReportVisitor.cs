namespace visitor;

public class ReportVisitor : IVisitor
{
    public void Visit(Book book)
    {
        Console.WriteLine($"[ЗВІТ - Книга] Назва: '{book.Title}', Автор: {book.Author}");
    }

    public void Visit(Magazine magazine)
    {
        Console.WriteLine($"[ЗВІТ - Журнал] Назва: '{magazine.Title}', Випуск: №{magazine.IssueNumber}");
    }
}