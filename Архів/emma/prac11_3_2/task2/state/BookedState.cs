namespace state;

public class BookedState : RoomState
{
    public override void BookRoom()
    {
        Console.WriteLine("Помилка! Номер вже заброньовано кимось іншим.");
    }

    public override void PayForRoom()
    {
        Console.WriteLine("Оплату прийнято. Тепер ви можете заселитися.");
        _room.ChangeState(new PaidState());
    }

    public override void CancelBooking()
    {
        Console.WriteLine("Бронювання скасовано. Номер знову вільний.");
        _room.ChangeState(new AvailableState());
    }

    public override void CheckIn()
    {
        Console.WriteLine("Помилка! Спочатку потрібно оплатити номер.");
    }

    public override void CheckOut()
    {
        Console.WriteLine("Помилка! Ви ще не заселилися.");
    }
}