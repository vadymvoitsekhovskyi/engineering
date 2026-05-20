namespace state;

public class AvailableState : RoomState
{
    public override void BookRoom()
    {
        Console.WriteLine("Номер успішно заброньовано. Очікуємо оплати.");
        _room.ChangeState(new BookedState());
    }

    public override void PayForRoom()
    {
        Console.WriteLine("Помилка! Ви не можете оплатити номер, який ще не заброньовано.");
    }

    public override void CancelBooking()
    {
        Console.WriteLine("Помилка! Немає активного бронювання для скасування.");
    }

    public override void CheckIn()
    {
        Console.WriteLine("Помилка! Не можна заселитися у вільний номер без попереднього бронювання та оплати.");
    }

    public override void CheckOut()
    {
        Console.WriteLine("Помилка! Номер вже вільний.");
    }
}