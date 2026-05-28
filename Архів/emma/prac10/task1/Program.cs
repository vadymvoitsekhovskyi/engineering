using System.Text;

namespace after
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            OrderRepository orderRepository = new OrderRepository();
            EmailService emailService = new EmailService();

            OrderProcessor orderProcessor = new OrderProcessor(orderRepository, emailService);
            orderProcessor.ProcessOrder("Ноутбук");
            orderProcessor.ProcessOrder("Мишка");
            orderProcessor.ProcessOrder("Навушники");
        }
    }
}