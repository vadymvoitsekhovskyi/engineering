namespace mediator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            Reception reception = new Reception();
            CleaningService cleaning = new CleaningService();
            Restaurant restaurant = new Restaurant();
            
            HotelManagementMediator mediator = new HotelManagementMediator(reception, cleaning, restaurant);
            
            Console.WriteLine("Гість заселяється в готель");
            reception.BookRoom();
            Console.WriteLine();
            Console.WriteLine("Гість замовляє їжу");
            restaurant.DeliverFood();
            Console.WriteLine();
            Console.WriteLine("Гість виїжджає з номера");
            reception.Checkout();
        }
    }
}