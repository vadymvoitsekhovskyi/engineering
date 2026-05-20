namespace solid
{
    // SRP, DIP
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Логування повідомлення: {message}");
        }
    }
}