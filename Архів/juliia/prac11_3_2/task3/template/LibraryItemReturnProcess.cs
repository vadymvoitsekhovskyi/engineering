namespace template;

public abstract class LibraryItemReturnProcess
{
    // Шаблонний метод. Задає жорстку послідовність дій алгоритму.
    public void ProcessReturn(string itemName)
    {
        Console.WriteLine($"\nПочаток обробки повернення: {itemName}");
            
        ReceiveItem();      
        CheckCondition();   
        UpdateDatabase();  
        PlaceOnShelf();    
            
        Console.WriteLine("Обробку завершено");
    }
    
    protected void ReceiveItem()
    {
        Console.WriteLine("1. Отримання предмета від читача.");
    }

    protected void UpdateDatabase()
    {
        Console.WriteLine("3. Зняття предмета з читача в базі даних. Статус: 'В наявності'.");
    }
    
    protected abstract void CheckCondition();
    protected abstract void PlaceOnShelf();
}