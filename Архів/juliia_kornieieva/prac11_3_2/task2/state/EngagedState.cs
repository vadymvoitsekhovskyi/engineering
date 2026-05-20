namespace state;

public class EngagedState : RoomState
{
    public override void BookRoom()
    {
        Console.WriteLine("Помилка! Номер зараз зайнятий.");
    }

    public override void PayForRoom()
    {
        Console.WriteLine("Помилка! Номер вже оплачено.");
    }

    public override void CancelBooking()
    {
        Console.WriteLine("Помилка! Неможливо скасувати бронювання після заселення.");
    }

    public override void CheckIn()
    {
        Console.WriteLine("Помилка! У номер вже хтось заселений.");
    }

    public override void CheckOut()
    {
        Console.WriteLine("Виселення пройшло успішно. До побачення! Номер потребує прибирання.");
        _room.ChangeState(new AvailableState());
    }
}