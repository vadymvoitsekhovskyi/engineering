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

            ILogger logger = new Logger();
            INotificationRepository repo = new NotificationRepository();

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