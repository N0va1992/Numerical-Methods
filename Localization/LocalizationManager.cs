using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace numericalMethods.Localization
{
    public static class LanguageManager
    {
        private static ResourceManager _resourceManager;
        private static string _currentCulture = "pl-PL"; // Default to English

        static LanguageManager()
        {
            _resourceManager = new ResourceManager("numericalMethods.Resource", typeof(LanguageManager).Assembly);
        }

        public static void ToggleLanguage()
        {
            // Toggle between English and Polish
            _currentCulture = (_currentCulture == "pl-PL") ? "en-US" : "pl-PL";

            // Load the resource file for the current culture
            try
            {
                _resourceManager = new ResourceManager($"numericalMethods.Resource", typeof(LanguageManager).Assembly);
            }
            catch (MissingManifestResourceException)
            {
                // Handle exception if the specified culture is not available
            }

            // Set the current UI culture
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(_currentCulture);
        }

        public static string GetLocalizedString(string key)
        {
            return _resourceManager.GetString(key);
        }
    }
}
