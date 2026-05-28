namespace solid
{
    public class PushSender : INotificationSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Відправлення push-повідомлення: {message}");
        }
    }
}