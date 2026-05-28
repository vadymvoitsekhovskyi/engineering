namespace solid
{
    // SRP - відповідає лише за координацію процесу сповіщення
    public class NotificationService
    {
        private readonly INotificationSender _sender;
        private readonly INotificationRepository _repository;
        private readonly ILogger _logger;

        // DIP - клас залежить виключно від абстракцій
        public NotificationService(INotificationSender sender, INotificationRepository repository, ILogger logger)
        {
            _sender = sender;
            _repository = repository;
            _logger = logger;
        }

        public void ProcessNotification(string message)
        {
            _logger.Log("Початок процесу відправки..."); // SRP
            _sender.Send(message); // OCP, LSP
            _repository.Save(message); // SRP
            _logger.Log("Процес відправки успішний.");
        }
    }
}