namespace strategy {
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            RestaurantOrder order1 = new RestaurantOrder(1500.50m);

            Console.WriteLine("Клієнт 1 хоче оплатити готівкою:");
            order1.SetPaymentStrategy(new CashPaymentStrategy());
            order1.Checkout();

            Console.WriteLine("\nКлієнт 1 передумав і просить термінал:");
            order1.SetPaymentStrategy(new CardPaymentStrategy());
            order1.Checkout();

            Console.WriteLine("\nАйтішник за сусіднім столиком розраховується:");
            RestaurantOrder order2 = new RestaurantOrder(2300.00m);
            order2.SetPaymentStrategy(new CryptoPaymentStrategy());
            order2.Checkout();
        }
    }
}