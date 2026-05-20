namespace solid
{
    // SRP, DIP
    public class NotificationRepository : INotificationRepository
    {
        public void Save(string message)
        {
            Console.WriteLine($"Збереження в базу даних: {message}");
        }
    }
}