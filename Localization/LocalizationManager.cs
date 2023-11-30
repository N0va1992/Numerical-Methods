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
        private static readonly ResourceManager _resourceManager;

        static LanguageManager()
        {
            _resourceManager = new ResourceManager("numericalMethods.Resource", typeof(LanguageManager).Assembly);
        }

        public static void ChangeLanguage(string culture)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
        }

        public static string GetLocalizedString(string key)
        {
            return _resourceManager.GetString(key);
        }
    }
}
