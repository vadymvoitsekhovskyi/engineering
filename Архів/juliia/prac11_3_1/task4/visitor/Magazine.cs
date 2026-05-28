namespace visitor;

public class Magazine : ILibraryItem
{
    public string Title { get; set; }
    public int IssueNumber { get; set; }
    public int DaysLate { get; set; }

    public Magazine(string title, int issueNumber, int daysLate)
    {
        Title = title;
        IssueNumber = issueNumber;
        DaysLate = daysLate;
    }
    
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}