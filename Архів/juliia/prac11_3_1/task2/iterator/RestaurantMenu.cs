namespace iterator;

public class RestaurantMenu : IMenu
{
    private List<MenuItem> _menuItems;

    public RestaurantMenu()
    {
        _menuItems = new List<MenuItem>();
    }

    public void AddItem(string name, double price)
    {
        _menuItems.Add(new MenuItem(name, price));
    }
    
    public IIterator CreateIterator()
    {
        return new MenuIterator(_menuItems);
    }
}