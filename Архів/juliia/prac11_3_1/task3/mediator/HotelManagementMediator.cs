namespace mediator;

public class HotelManagementMediator : IMediator
{
    private Reception _reception;
    private CleaningService _cleaningService;
    private Restaurant _restaurant;

    public HotelManagementMediator(Reception reception, CleaningService cleaningService, Restaurant restaurant)
    {
        _reception = reception;
        _reception.SetMediator(this);

        _cleaningService = cleaningService;
        _cleaningService.SetMediator(this);

        _restaurant = restaurant;
        _restaurant.SetMediator(this);
    }
    
    public void Notify(object sender, string ev)
    {
        if (ev == "RoomBooked")
        {
            Console.WriteLine("[ПОСЕРЕДНИК] - отримано сигнал про заселення. Повідомляю ресторан підготувати вітальний напій для гостя.");
        }
        else if (ev == "Checkout")
        {
            Console.WriteLine("[ПОСЕРЕДНИК] - отримано сигнал про виселення. Відправляю запит на прибирання.");
            _cleaningService.CleanRoom();
        }
        else if (ev == "FoodDelivered")
        {
            Console.WriteLine("[ПОСЕРЕДНИК] - ресторан доставив замовлення. Повідомляю ресепшн оновити рахунок.");
            _reception.AddToBill("Обслуговування номерів (ресторан)");
        }
        else if (ev == "RoomCleaned")
        {
            Console.WriteLine("[ПОСЕРЕДНИК] - номер прибрано. Оновлюю статус у системі (номер доступний).");
        }
    }
}