namespace solid
{
    // ISP, DIP
    public interface INotificationRepository
    {
        void Save(string message);
    }
}