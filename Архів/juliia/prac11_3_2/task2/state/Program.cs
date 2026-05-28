namespace state
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            HotelRoom room = new HotelRoom(new AvailableState());
            
            Console.WriteLine("Сценарій 1.");
            room.RequestBooking(); 
            room.RequestPayment(); 
            room.RequestCheckIn(); 
            room.RequestCheckOut(); 
            
            Console.WriteLine("\nСценарій 2.");
            
            room.RequestPayment(); 
            room.RequestCheckIn(); 
            room.RequestBooking();
            room.RequestCheckIn();
            room.RequestCancel();
        }
    }
}