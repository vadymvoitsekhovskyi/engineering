using System.Text;

namespace solid
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            string message = "Hello SOLID!";

            // DIP - конкретні реалізації створюються тут і передаються через конструктор
            ILogger logger = new Logger();
            INotificationRepository repo = new NotificationRepository();

            // LSP - кожен з сендерів повноцінно замінює INotificationSender
            // OCP - щоб додати новий канал, достатньо створити новий клас-сендер
            List<INotificationSender> senders = new List<INotificationSender>
            {
                new EmailSender(),
                new TelegramSender(),
                new PushSender(),
                new SmsSender()
            };
            
            foreach (var sender in senders)
            {
                NotificationService service = new NotificationService(sender, repo, logger);
                service.ProcessNotification(message);
            }
        }
    }
}