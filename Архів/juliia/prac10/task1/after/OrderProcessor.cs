namespace after
{
    public class OrderProcessor
    {
        private OrderRepository _orderRepository;
        private NotificationService _notificationService;

        public OrderProcessor(OrderRepository orderRepository, NotificationService notificationService)
        {
            _orderRepository = orderRepository;
            _notificationService = notificationService;
        }

        public void ProcessOrder(string item)
        {
            _orderRepository.SaveToDb(item);
            _notificationService.Send(item);
        }
    }
}