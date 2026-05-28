namespace solid
{
    public class NotificationService
    {
        private readonly INotificationSender _sender;
        private readonly INotificationRepository _repository;
        private readonly ILogger _logger;

        public NotificationService(INotificationSender sender, INotificationRepository repository, ILogger logger)
        {
            _sender = sender;
            _repository = repository;
            _logger = logger;
        }

        public void ProcessNotification(string message)
        {
            _logger.Log("Початок процесу відправки...");
            _sender.Send(message); 
            _repository.Save(message);
            _logger.Log("Процес відправки успішний.");
        }
    }
}