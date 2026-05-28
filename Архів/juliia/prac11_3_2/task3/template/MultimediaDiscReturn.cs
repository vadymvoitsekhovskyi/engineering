namespace template;

public class MultimediaDiscReturn : LibraryItemReturnProcess
{
    protected override void CheckCondition()
    {
        Console.WriteLine("2. Перевірка стану: візуальний огляд поверхні диска на наявність подряпин та тріщин.");
    }
    
    protected override void PlaceOnShelf()
    {
        Console.WriteLine("4. Розміщення: покласти в захищений пластиковий бокс у відділі мультимедіа.");
    }
}