// MainMenuControl.cs
using System;
using System.Diagnostics;
using System.Windows.Forms;
using numericalMethods.Localization;

namespace metodyNumeryczne
{
    public partial class MainMenuControl : UserControl
    {
        public event EventHandler ApproximationsButtonClicked;
        public event EventHandler InterpolationsButtonClicked;
        public event EventHandler ApproxFuncButtonClicked;
        public event EventHandler IntegrationsButtonClicked;
        public event EventHandler DifferentiationButtonClicked;
        public event EventHandler LanguageButtonClicked;

        public MainMenuControl()
        {
            InitializeComponent();
            UpdateLocalizedStrings();

            languageBtn.Click += languageBtn_Click;
        }        

        private void languageBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Language button clicked");
            // Obsługa przycisku zmiany języka
            LanguageButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void approximationsBtn_Click(object sender, EventArgs e)
        {
            ApproximationsButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void interpolationsBtn_Click(object sender, EventArgs e)
        {
            InterpolationsButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void approxfuncBnt_Click(object sender, EventArgs e)
        {
            ApproxFuncButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void integrationsBtn_Click(object sender, EventArgs e)
        {
            IntegrationsButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void differentiationBtn_Click(object sender, EventArgs e)
        {
            DifferentiationButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        public void UpdateLocalizedStrings()
        {
            // Kod aktualizacji lokalizowanych ciągów
            approximationsBtn.Text = LanguageManager.GetLocalizedString("approximationsBtn");
            interpolationsBtn.Text = LanguageManager.GetLocalizedString("interpolationsBtn");
            approxfuncBnt.Text = LanguageManager.GetLocalizedString("approxfuncBnt");
            integrationsBtn.Text = LanguageManager.GetLocalizedString("integrationsBtn");
            differentiationBtn.Text = LanguageManager.GetLocalizedString("differentiationBtn");
            languageBtn.Text = LanguageManager.GetLocalizedString("languageBtn");
            title.Text = LanguageManager.GetLocalizedString("formTitle");
        }
    }
}
