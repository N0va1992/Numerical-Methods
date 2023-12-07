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
        private InterpolationMenuControl interpolationMenuControl;
        private ApproxFuncControl approxFuncControl;
        private TaskMenu11 taskMenu11;
        private TaskMenu12 taskMenu12;
        private TaskMenu31 taskMenu31;

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
            mainMenuControl.ApproxFuncButtonClicked += MainMenuControl_ApproxFuncButtonClicked;
            mainMenuControl.LanguageButtonClicked += MainMenuControl_LanguageButtonClicked;

            Controls.Add(mainMenuControl);
        }

        private void MainMenuControl_ApproximationsButtonClicked(object sender, EventArgs e)
        {
            ShowApproxMenuContol();
        }

        private void MainMenuControl_InterpolationsButtonClicked(object sender, EventArgs e)
        {
            ShowInterMenuControl();
        }

        private void MainMenuControl_ApproxFuncButtonClicked(object sender, EventArgs e)
        {
            ShowApproxFuncMenuControl();
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

        private void ApproxMenuControl_Task12ButtonClicked(object sender, EventArgs e)
        {
            ShowTask12Control();
        }

        private void InterpolationMenuControl_BackButtonClicked(object sender, EventArgs e)
        {
            ShowMainMenuControl();
        }

        private void ApproxFuncMenuControl_BackButtonClicked(object sender, EventArgs e)
        {
            ShowMainMenuControl();
        }

        private void ApproxFuncMenuControl_Task31ButtonClicked(object sender, EventArgs e)
        {
            ShowTask31Control();
        }

        private void Task11Control_BackButtonClicked(object sender, EventArgs e) 
        {
            ShowApproxMenuContol();
        }

        private void Task12Control_BackButtonClicked(object sender, EventArgs e)
        {
            ShowApproxMenuContol();
        }

        private void Task31Control_BackButtonClicked(Object sender, EventArgs e)
        {
            ShowApproxFuncMenuControl();
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
            mainMenuControl.InterpolationsButtonClicked += MainMenuControl_InterpolationsButtonClicked;
            mainMenuControl.ApproxFuncButtonClicked += MainMenuControl_ApproxFuncButtonClicked;
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
            approxMenuControl.Task12ButtonClicked += ApproxMenuControl_Task12ButtonClicked;

        }

        private void ShowTask11Control()
        {
            taskMenu11 = new TaskMenu11();
            taskMenu11.Dock = DockStyle.Fill;

            Controls.Clear();

            Controls.Add(taskMenu11);

            taskMenu11.BackButtonClicked += Task11Control_BackButtonClicked;
        }

        private void ShowTask12Control()
        {
            taskMenu12 = new TaskMenu12();
            taskMenu12.Dock = DockStyle.Fill;

            Controls.Clear();

            Controls.Add(taskMenu12);

            taskMenu12.BackButtonClicked += Task12Control_BackButtonClicked;
        }

        private void ShowInterMenuControl()
        {
            // Tworzenie nwoej instacji InterpolationsMenuControl
            interpolationMenuControl = new InterpolationMenuControl();
            interpolationMenuControl.Dock = DockStyle.Fill;

            // Usuwanie MainMenuControl z Controls
            Controls.Clear();

            // Dodawanie ApproxMenuControl do Controls
            Controls.Add(interpolationMenuControl);

            // Przypisanie Event Handlera do przycisku powrotu
            interpolationMenuControl.BackButtonClicked += InterpolationMenuControl_BackButtonClicked;
        }

        private void ShowApproxFuncMenuControl()
        {
            // Tworzenie nwoej instacji InterpolationsMenuControl
            approxFuncControl = new ApproxFuncControl();
            approxFuncControl.Dock = DockStyle.Fill;

            // Usuwanie MainMenuControl z Controls
            Controls.Clear();

            // Dodawanie ApproxMenuControl do Controls
            Controls.Add(approxFuncControl);

            // Przypisanie Event Handlera do przycisku powrotu
            approxFuncControl.BackButtonClicked += ApproxFuncMenuControl_BackButtonClicked;
            approxFuncControl.Task31ButtonClicked += ApproxFuncMenuControl_Task31ButtonClicked;
        }

        private void ShowTask31Control()
        {
            taskMenu31 = new TaskMenu31();
            taskMenu31.Dock = DockStyle.Fill;

            Controls.Clear();

            Controls.Add(taskMenu31);

            taskMenu31.BackButtonClicked += Task31Control_BackButtonClicked;
        }
    }
}
