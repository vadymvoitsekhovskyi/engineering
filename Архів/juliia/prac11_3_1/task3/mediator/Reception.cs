namespace mediator;

public class Reception : HotelDepartment
{
    public void BookRoom()
    {
        Console.WriteLine("Ресепшн - гість успішно забронював номер.");
        _mediator.Notify(this, "RoomBooked");
    }

    public void Checkout()
    {
        Console.WriteLine("Ресепшн - гість виїхав з готелю. Номер вільний.");
        _mediator.Notify(this, "Checkout");
    }

    public void AddToBill(string item)
    {
        Console.WriteLine($"Ресепшн - додано до рахунку гостя. {item}.");
    }
}