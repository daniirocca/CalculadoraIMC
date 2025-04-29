namespace CalculadoraIMC.Services
{
    public class JsonTranslator : ITranslator
    {
        private readonly IWebHostEnvironment _env;
        private readonly Dictionary<string, string> _translations = new();
        private string _culture = "pt-BR";

        public JsonTranslator(IWebHostEnvironment env)
        {
            _env = env;
            LoadCulture(_culture);
        }

        public string this[string key] => _translations.TryGetValue(key, out var value) ? value : $"[{key}]";

        public void SetCulture(string culture)
        {
            if (_culture != culture)
            {
                _culture = culture;
                LoadCulture(culture);
            }
        }

        private void LoadCulture(string culture)
        {
            _translations.Clear();
            var filePath = Path.Combine(_env.WebRootPath, "i18n", $"{culture}.json");

            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                var data = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(json);
                if (data is not null)
                    foreach (var item in data)
                        _translations[item.Key] = item.Value;
            }
        }
    }
}
