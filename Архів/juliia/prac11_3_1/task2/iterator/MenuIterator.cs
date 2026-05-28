namespace iterator;

public class MenuIterator : IIterator
{
    private List<MenuItem> _menuItems;
    private int _position = 0;

    public MenuIterator(List<MenuItem> menuItems)
    {
        _menuItems = menuItems;
    }

    public bool HasNext()
    {
        return _position < _menuItems.Count;
    }

    public MenuItem Next()
    {
        if (HasNext())
        {
            MenuItem item = _menuItems[_position];
            _position++;
            return item;
        }
        
        return null;
    }
}