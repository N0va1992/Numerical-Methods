// Form1.cs
using System;
using System.Windows.Forms;
using numericalMethods;
using numericalMethods.Localization;

namespace metodyNumeryczne
{
    public partial class Form1 : Form
    {
        private MainMenuControl mainMenuControl;
        private ApproxMenuControl approxMenuControl;
        private TaskMenu11 taskMenu11;

        public Form1()
        {
            InitializeComponent();

            mainMenuControl = new MainMenuControl();
            mainMenuControl.Dock = DockStyle.Fill;

            approxMenuControl = new ApproxMenuControl(); // Dodaj tę linię
            approxMenuControl.Dock = DockStyle.Fill;

            // Podpięcie obsługi zdarzeń z UserControl

            mainMenuControl.ApproximationsButtonClicked += MainMenuControl_ApproximationsButtonClicked;
            mainMenuControl.InterpolationsButtonClicked += MainMenuControl_InterpolationsButtonClicked;
            mainMenuControl.LanguageButtonClicked += MainMenuControl_LanguageButtonClicked;

            Controls.Add(mainMenuControl);
        }

        private void MainMenuControl_ApproximationsButtonClicked(object sender, EventArgs e)
        {
            ShowApproxMenuContol();
        }

        private void MainMenuControl_InterpolationsButtonClicked(object sender, EventArgs e)
        {
            // Obsługa przycisku Interpolations
            // Tu możesz wywołać kod związany z Interpolations
        }

        private void MainMenuControl_LanguageButtonClicked(object sender, EventArgs e)
        {
            // Obsługa przycisku Language
            // Tutaj dodaj kod do ponownego załadowania całego interfejsu użytkownika
            // z nowymi tekstami w nowym języku.
            LanguageManager.ToggleLanguage();
            mainMenuControl.UpdateLocalizedStrings();
        }

        private void ApproxMenuControl_BackButtonClicked(object sender, EventArgs e)
        {
            ShowMainMenuControl();
        }

        private void ApproxMenuControl_Task11ButtonClicked(object sender, EventArgs e) 
        {
            ShowTask11Control();
        }

        private void Task11Control_BackButtonClicked(object sender, EventArgs e) 
        {
            ShowApproxMenuContol();
        }

        private void ShowMainMenuControl()
        {
            // Tworzenie nowej instancji MainMenuControl
            mainMenuControl = new MainMenuControl();
            mainMenuControl.Dock = DockStyle.Fill;

            // Usuwanie ApproxMenuControl z Controls
            Controls.Clear();

            // Dodawanie MainMenuControl do Controls
            Controls.Add(mainMenuControl);

            //przypisanie Event Handlerów
            mainMenuControl.ApproximationsButtonClicked += MainMenuControl_ApproximationsButtonClicked;
            mainMenuControl.LanguageButtonClicked += MainMenuControl_LanguageButtonClicked;
        }

        private void ShowApproxMenuContol()
        {
            // Tworzenie nwoej instacji ApproxMenuControl
            approxMenuControl = new ApproxMenuControl();
            approxMenuControl.Dock = DockStyle.Fill;

            // Usuwanie MainMenuControl z Controls
            Controls.Clear();

            // Dodawanie ApproxMenuControl do Controls
            Controls.Add(approxMenuControl);

            // Przypisanie Event Handlera do przycisku powrotu
            approxMenuControl.BackButtonClicked += ApproxMenuControl_BackButtonClicked;
            approxMenuControl.Task11ButtonClicked += ApproxMenuControl_Task11ButtonClicked;

        }

        private void ShowTask11Control()
        {
            taskMenu11 = new TaskMenu11();
            taskMenu11.Dock = DockStyle.Fill;

            Controls.Clear();

            Controls.Add(taskMenu11);

            taskMenu11.BackButtonClicked += Task11Control_BackButtonClicked;
        }
    }
}
