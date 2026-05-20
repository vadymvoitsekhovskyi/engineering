namespace after
{
    public class EmailService : NotificationService
    {
        public override void Send(string order)
        {
            Console.WriteLine("Відправлення листа підтвердження.");
        }
    }
}