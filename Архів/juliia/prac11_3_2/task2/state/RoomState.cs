namespace state;

public abstract class RoomState
{
    protected HotelRoom _room;

    public void SetContext(HotelRoom room)
    {
        _room = room;
    }
    
    public abstract void BookRoom();
    public abstract void PayForRoom();
    public abstract void CancelBooking();
    public abstract void CheckIn();
    public abstract void CheckOut();
}