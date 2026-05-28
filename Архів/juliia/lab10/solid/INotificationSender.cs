namespace solid
{
    // ISP, DIP
    public interface INotificationSender
    {
        void Send(string message);
    }
}