namespace memento;

// manages saving and restoring snapshots, but does not have access to their internal data.
public class WarehouseHistory
{
    private List<IMemento> _mementos = new List<IMemento>();
    private Warehouse _warehouse;

    public WarehouseHistory(Warehouse warehouse)
    {
        _warehouse = warehouse;
    }

    public void Backup()
    {
        Console.WriteLine("\n[Історія] Робимо резервну копію стану складу...");
        _mementos.Add(_warehouse.Save());
    }

    public void Undo()
    {
        if (_mementos.Count == 0)
        {
            Console.WriteLine("[Історія] Немає збережених станів для відновлення!");
            return;
        }

        // get last saved snapshot
        var memento = _mementos.Last();
        _mementos.Remove(memento);

        Console.WriteLine($"\n[Історія] Відкат змін до стану: {memento.GetName()}");
            
        // restoring the state of warehouse
        _warehouse.Restore(memento);
    }

    public void ShowHistory()
    {
        Console.WriteLine("\nІсторія збережених станів");
        
        foreach (var memento in _mementos)
        {
            Console.WriteLine(memento.GetName());
        }
        
        Console.WriteLine("---------------------------------\n");
    }
}