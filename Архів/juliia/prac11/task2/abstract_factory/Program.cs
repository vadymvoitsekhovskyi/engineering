namespace abstract_factory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
                
            string currentOS = "Windows";

            Application app = ConfigureApplication(currentOS);

            if (app != null)
            {
                app.RenderUI();
                app.SimulateUserInteraction();
            }
        }

        static Application ConfigureApplication(string os)
        {
            IUIFactory factory;

            if (os.Equals("Windows", StringComparison.OrdinalIgnoreCase))
            {
                factory = new WindowsFactory();
            }
            else if (os.Equals("Mac", StringComparison.OrdinalIgnoreCase))
            {
                factory = new MacFactory();
            }
            else
            {
                Console.WriteLine($"Помилка: ОС '{os}' не підтримується.");
                return null;
            }

            return new Application(factory);
        }
    }
}