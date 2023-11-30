using numericalMethods;
using numericalMethods.Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metodyNumeryczne
{
    public partial class Form1 : Form
    {
        private ApproximationsViewControl approximationsView;
        private InterpolationsViewControl interpolationsView;
        private Form1 originalForm;
        private Control currentView;

        public Form1()
        {
            InitializeComponent();
            title.Text = "Wstęp do Metod Numerycznych";

            originalForm = this;
            approximationsView = new ApproximationsViewControl();
            interpolationsView = new InterpolationsViewControl();

            approximationsView.BackButtonClicked += UserControl_BackButtonClicked;
        }

        private void approximationsBtn_Click(object sender, EventArgs e)
        {
            // Pokaż widok przybliżeń
            ShowView(approximationsView);
        }

        private void interpolationsBtn_Click(object sender, EventArgs e)
        {
            // Pokaż widok interpolacji
            ShowView(interpolationsView);
        }

        private void languageBtn_Click(object sender, EventArgs e)
        {
            // Toggle between English and Polish
            LanguageManager.ToggleLanguage();

            // Update form controls with localized strings
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

        private void ShowView(Control view)
        {
            // Ukryj bieżący widok
            if (currentView != null)
            {
                currentView.Hide();
            }

            // Pokaż nowy widok
            view.Dock = DockStyle.Fill;
            view.Show();

            // Ustaw nowy widok jako bieżący
            currentView = view;

            // Zaktualizuj lokalizację po zmianie widoku
            UpdateLocalizedStrings();
        }

        private Form GetMainForm()
        {
            return Application.OpenForms.OfType<Form>().FirstOrDefault(f => f is Form1);
        }

        private void UserControl_BackButtonClicked(object sender, EventArgs e)
        {
            // Powrót do głównego menu
            Form mainForm = GetMainForm();
            if (mainForm != null)
            {
                if (currentView != null)
                {
                    currentView.Dispose(); // Zwolnij zasoby kontrolki (opcjonalne)
                }
                ShowView(mainForm);
            }
        }

    }
}


//naprawić wyświetlanie kontrolek. być może będzie trzeba całe główne menu przenieść do formularza
