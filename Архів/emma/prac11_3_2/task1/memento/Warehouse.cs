namespace memento;

// this is class, whose state we want to save and restore.
public class Warehouse
{
    private int _productCount;

    public Warehouse(int initialCount)
    {
        _productCount = initialCount;
        Console.WriteLine($"[Склад] Відкрито склад. Початкова кількість товарів: {_productCount}");
    }

    public void AddProducts(int count)
    {
        _productCount += count;
        Console.WriteLine($"[Склад] Завезено {count} товарів. Поточний залишок: {_productCount}");
    }

    public void SellProducts(int count)
    {
        if (_productCount >= count)
        {
            _productCount -= count;
            Console.WriteLine($"[Склад] Продано {count} товарів. Поточний залишок: {_productCount}");
        }
        else
        {
            Console.WriteLine($"[Склад] ПОМИЛКА: Недостатньо товарів для продажу {count} одиниць!");
        }
    }

    // creates the snapshot with current state
    public IMemento Save()
    {
        return new WarehouseSnapshot(_productCount);
    }

    // restores the state from a snapshot
    public void Restore(IMemento memento)
    {
        if (!(memento is WarehouseSnapshot snapshot))
        {
            throw new Exception("Невідомий клас знімка: " + memento.ToString());
        }

        _productCount = snapshot.GetSavedProductCount();
        Console.WriteLine($"[Склад] СТАН ВІДНОВЛЕНО. Поточний залишок товару тепер: {_productCount}");
    }
}