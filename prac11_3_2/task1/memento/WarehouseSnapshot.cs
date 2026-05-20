namespace memento;

// this is specific snapshot
public class WarehouseSnapshot : IMemento
{
    private readonly int _productCount;
    private readonly DateTime _date;

    public WarehouseSnapshot(int productCount)
    {
        _productCount = productCount;
        _date = DateTime.Now;
    }

    // this is method that only the Warehouse itself uses to restore its state
    public int GetSavedProductCount()
    {
        return _productCount;
    }

    public string GetName()
    {
        return $"{_date:HH:mm:ss} | Збережена кількість товарів: {_productCount}";
    }

    public DateTime GetDate()
    {
        return _date;
    }
}