namespace solid
{
    public class TelegramSender : INotificationSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Відправлення Telegram повідомлення: {message}");
        }
    }
}