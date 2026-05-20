namespace singleton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CreateDummyConfigFile();

            Console.WriteLine("Звернення до ConfigurationManager.Instance (Екземпляр 1)...");
            ConfigurationManager config1 = ConfigurationManager.Instance;
            Console.WriteLine($"Налаштування 'Theme': {config1.GetSetting("Theme")}");
            Console.WriteLine($"Налаштування 'Language': {config1.GetSetting("Language")}");

            Console.WriteLine("\nЗвернення до ConfigurationManager.Instance (Екземпляр 2)...");
            ConfigurationManager config2 = ConfigurationManager.Instance;
            Console.WriteLine($"Налаштування 'MaxConnections': {config2.GetSetting("MaxConnections")}");
            Console.WriteLine("\n--- Перевірка на ідентичність ---");

            if (ReferenceEquals(config1, config2))
            {
                Console.WriteLine("config1 та config2 є посиланнями на один і той самий екземпляр.");
                Console.WriteLine("Патерн Singleton працює коректно.");
            }
            else
            {
                Console.WriteLine("Створено різні екземпляри.");
            }
        }

        private static void CreateDummyConfigFile()
        {
            string filePath = "config.json";

            if (!File.Exists(filePath))
            {
                string jsonContent = @"{
                    ""Theme"": ""Dark"",
                    ""Language"": ""uk-UA"",
                    ""MaxConnections"": ""100"",
                    ""ApiUrl"": ""https://api.example.com/v1""
                }";
                File.WriteAllText(filePath, jsonContent);
            }
        }
    }
}