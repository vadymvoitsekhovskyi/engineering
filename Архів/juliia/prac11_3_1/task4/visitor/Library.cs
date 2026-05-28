namespace visitor;

public class Library
{
    private List<ILibraryItem> _items = new List<ILibraryItem>();

    public void AddItem(ILibraryItem item)
    {
        _items.Add(item);
    }
    
    public void AcceptVisitor(IVisitor visitor)
    {
        foreach (var item in _items)
        {
            item.Accept(visitor);
        }
    }
}