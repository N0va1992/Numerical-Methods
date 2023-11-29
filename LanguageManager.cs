using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Resources;

namespace MetodyNumeryczne
{
    public static class LanguageManager
    {
        private static ResourceManager _resourceManager;

        public static void Initialize(string languageCode)
        {
            _resourceManager = new ResourceManager($"MetodyNumeryczne.Resources_{languageCode}", typeof(LanguageManager).Assembly);
        }

        public static string GetLocalizedString(string key)
        {
            return _resourceManager.GetString(key) ?? key;
        }
    }
}
