// MainMenuControl.cs
using System;
using System.Windows.Forms;
using numericalMethods.Localization;

namespace metodyNumeryczne
{
    public partial class MainMenuControl : UserControl
    {
        public event EventHandler ApproximationsButtonClicked;
        public event EventHandler InterpolationsButtonClicked;
        public event EventHandler LanguageButtonClicked;

        public MainMenuControl()
        {
            InitializeComponent();
            UpdateLocalizedStrings();
        }

        private void UpdateLocalizedStrings()
        {
            approximationsBtn.Text = LanguageManager.GetLocalizedString("approximationsBtn");
            interpolationsBtn.Text = LanguageManager.GetLocalizedString("interpolationsBtn");
            approxfuncBnt.Text = LanguageManager.GetLocalizedString("approxfuncBnt");
            integrationsBtn.Text = LanguageManager.GetLocalizedString("integrationsBtn");
            differentiationBtn.Text = LanguageManager.GetLocalizedString("differentiationBtn");
            languageBtn.Text = LanguageManager.GetLocalizedString("languageBtn");
            title.Text = LanguageManager.GetLocalizedString("formTitle");
        }

        private void languageBtn_Click(object sender, EventArgs e)
        {
            // Przełącz język
            LanguageManager.ToggleLanguage();

            // Aktualizuj teksty po przełączeniu języka
            UpdateLocalizedStrings();

            // Wywołaj zdarzenie informujące o przełączeniu języka
            LanguageButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
