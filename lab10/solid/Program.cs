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
            INotificationSender emailSender = new EmailSender();

            NotificationService emailService = new NotificationService(emailSender, repo, logger);
            emailService.ProcessNotification(message);

            INotificationSender telegramSender = new TelegramSender(); // OCP
            NotificationService telegramService = new NotificationService(telegramSender, repo, logger);
            telegramService.ProcessNotification(message);

            INotificationSender pushSender = new PushSender();
            NotificationService pushService = new NotificationService(pushSender, repo, logger);
            pushService.ProcessNotification(message);

            INotificationSender smsSender = new SmsSender();
            NotificationService smsService = new NotificationService(smsSender, repo, logger);
            smsService.ProcessNotification(message);
        }
    }
}