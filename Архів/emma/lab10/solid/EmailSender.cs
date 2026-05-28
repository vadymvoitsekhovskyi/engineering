namespace solid
{
    public class EmailSender : INotificationSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Відправлення email: {message}");
        }
    }
}