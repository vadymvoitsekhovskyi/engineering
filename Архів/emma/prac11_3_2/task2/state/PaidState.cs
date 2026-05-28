namespace state;

public class PaidState : RoomState
{
    public override void BookRoom()
    {
        Console.WriteLine("Помилка! Номер вже заброньовано та оплачено.");
    }

    public override void PayForRoom()
    {
        Console.WriteLine("Помилка! Номер вже оплачено.");
    }

    public override void CancelBooking()
    {
        Console.WriteLine("Бронювання скасовано. Кошти буде повернуто. Номер знову вільний.");
        _room.ChangeState(new AvailableState());
    }

    public override void CheckIn()
    {
        Console.WriteLine("Успішне заселення. Ласкаво просимо!");
        _room.ChangeState(new EngagedState());
    }

    public override void CheckOut()
    {
        Console.WriteLine("Помилка! Ви ще не заселилися, щоб виселятися.");
    }
}