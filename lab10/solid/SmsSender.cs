namespace solid
{
    // SRP, OCP, LSP
    public class SmsSender : INotificationSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Відправлення sms-повідомлення: {message}");
        }
    }
}