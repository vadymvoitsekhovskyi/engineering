namespace visitor;

public class Book : ILibraryItem
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int DaysLate { get; set; }

    public Book(string title, string author, int daysLate)
    {
        Title = title;
        Author = author;
        DaysLate = daysLate;
    }
    
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}