namespace decorator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            Subscription subscription = new BasicSubscription();

            Console.WriteLine();
            Console.WriteLine("1. Базова підписка:");
            Console.WriteLine("Опис: " + subscription.GetDescription());
            Console.WriteLine("Вартість: $" + subscription.GetCost().ToString("F2"));
            Console.WriteLine();

            subscription = new HdDecorator(subscription);
            Console.WriteLine("2. Після додавання HD:");
            Console.WriteLine("Опис: " + subscription.GetDescription());
            Console.WriteLine("Вартість: $" + subscription.GetCost().ToString("F2"));
            Console.WriteLine();

            subscription = new OfflineDecorator(subscription);
            Console.WriteLine("3. Після додавання Offline:");
            Console.WriteLine("Опис: " + subscription.GetDescription());
            Console.WriteLine("Вартість: $" + subscription.GetCost().ToString("F2"));
            Console.WriteLine();

            subscription = new AdFreeDecorator(subscription);
            Console.WriteLine("4. Повна підписка:");
            Console.WriteLine("Опис: " + subscription.GetDescription());
            Console.WriteLine("Вартість: $" + subscription.GetCost().ToString("F2"));
            Console.WriteLine();
        }
    }
}