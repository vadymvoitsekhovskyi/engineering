namespace template;

public class PaperBookReturn : LibraryItemReturnProcess
{
    protected override void CheckCondition()
    {
        Console.WriteLine("2. Перевірка стану: гортання сторінок, перевірка обкладинки на розриви та плями.");
    }
    
    protected override void PlaceOnShelf()
    {
        Console.WriteLine("4. Розміщення: поставити на дерев'яну полицю у відповідному жанровому відділі.");
    }
}