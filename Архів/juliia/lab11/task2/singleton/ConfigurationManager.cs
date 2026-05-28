using System.Text.Json;

namespace singleton
{
    public sealed class ConfigurationManager
    {
        private static readonly Lazy<ConfigurationManager> _instance = new Lazy<ConfigurationManager>(() => new ConfigurationManager());
        private Dictionary<string, string> _settings;
        private readonly string _configFilePath = "config.json";
        
        private ConfigurationManager()
        {
            _settings = new Dictionary<string, string>();
            LoadConfiguration();
        }
        
        public static ConfigurationManager Instance
        {
            get
            {
                return _instance.Value;
            }
        }
        
        private void LoadConfiguration()
        {
            try
            {
                if (File.Exists(_configFilePath))
                {
                    string json = File.ReadAllText(_configFilePath);
                    _settings = JsonSerializer.Deserialize<Dictionary<string, string>>(json) ?? new Dictionary<string, string>();
                    Console.WriteLine("Файл конфігурації успішно завантажено.");
                }
                else
                {
                    Console.WriteLine($"Файл конфігурації {_configFilePath} не знайдено. Будуть використані порожні налаштування.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Не вдалося завантажити конфігурацію: {ex.Message}");
            }
        }
        
        public string GetSetting(string key)
        {
            if (_settings.TryGetValue(key, out string value))
            {
                return value;
            }

            return null;
        }
    }
}