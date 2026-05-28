namespace mediator;

public class CleaningService : HotelDepartment
{
    public void CleanRoom()
    {
        Console.WriteLine("Служба прибирання - виконується прибирання номера.");
        Console.WriteLine("Служба прибирання - номер прибрано та готовий до нових гостей.");
        _mediator.Notify(this, "RoomCleaned");
    }
}