namespace state;

public class HotelRoom
{
    // current room's state
    private RoomState _state = null;

    public HotelRoom(RoomState initialState)
    {
        ChangeState(initialState);
    }
    
    public void ChangeState(RoomState newState)
    {
        _state = newState;
        _state.SetContext(this);
        Console.WriteLine($"Стан номера змінено на: {_state.GetType().Name}");
    }
    
    public void RequestBooking()
    {
        _state.BookRoom();
    }

    public void RequestPayment()
    {
        _state.PayForRoom();
    }

    public void RequestCancel()
    {
        _state.CancelBooking();
    }

    public void RequestCheckIn()
    {
        _state.CheckIn();
    }

    public void RequestCheckOut()
    {
        _state.CheckOut();
    }
}