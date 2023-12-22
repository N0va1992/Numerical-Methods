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
        private IntegrationsMenuControl integrationsMenuControl;
        private DifferentiationMenuControl differentiationMenuControl;
        private TaskMenu11 taskMenu11;
        private TaskMenu12 taskMenu12;
        private TaskMenu31 taskMenu31;
        private TaskMenu32 taskMenu32;
        private RectangleMethodControl rectMethodControl;
        private TrapezodialMethodControl trapezodialMethodControl;
        private ParabolicMethodControl parabolicMethodControl;
        private ProgressiveMenuControl progressiveMenuControl;
        private BackwardMenuControl backwardMenuControl;
        private DividedMenuControl dividedMenuControl;
        private CreditsControl creditsControl;

        public Form1()
        {
            InitializeComponent();

            mainMenuControl = new MainMenuControl();
            mainMenuControl.Dock = DockStyle.Fill;

            // Podpięcie obsługi zdarzeń z UserControl

            mainMenuControl.ApproximationsButtonClicked += MainMenuControl_ApproximationsButtonClicked;
            mainMenuControl.InterpolationsButtonClicked += MainMenuControl_InterpolationsButtonClicked;
            mainMenuControl.ApproxFuncButtonClicked += MainMenuControl_ApproxFuncButtonClicked;
            mainMenuControl.IntegrationsButtonClicked += MainMenuControl_IntegrationsButtonClicked;
            mainMenuControl.DifferentiationButtonClicked += MainMenuCOntrol_DifferentiationButtonClicked;
            mainMenuControl.CreditsButtonClicked += MainMenuControl_CreditsButtonClicked;
            mainMenuControl.LanguageButtonClicked += MainMenuControl_LanguageButtonClicked;

            Controls.Add(mainMenuControl);
        }

        //obsluga przycisków w menu
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

        private void MainMenuControl_IntegrationsButtonClicked(object sender, EventArgs e)
        {
            ShowIntegrationsMenuControl();
        }

        private void MainMenuCOntrol_DifferentiationButtonClicked(object sender, EventArgs e)
        {
            ShowDifferentiationMenuControl();
        }

        private void MainMenuControl_CreditsButtonClicked(object sender, EventArgs e)
        {
            ShowCreditsControl();
        }

        private void MainMenuControl_LanguageButtonClicked(object sender, EventArgs e)
        {
            // Obsługa przycisku Language
            LanguageManager.ToggleLanguage();
            mainMenuControl.UpdateLocalizedStrings();
        }

        //obsługa przycisków w zadaniach
        private void ApproxMenuControl_Task11ButtonClicked(object sender, EventArgs e) 
        {
            ShowTask11Control();
        }

        private void ApproxMenuControl_Task12ButtonClicked(object sender, EventArgs e)
        {
            ShowTask12Control();
        }

        private void ApproxFuncMenuControl_BackButtonClicked(object sender, EventArgs e)
        {
            ShowMainMenuControl();
        }

        private void IntegrationsMenuControl_RectangleButtonClicked(object sender, EventArgs e)
        {
            ShowRectangleMethodControl();
        }

        private void IntegrationsMenuControl_TrapezodialButtonClicked(object sender, EventArgs e)
        {
            ShowTrapezodialMethodControl();
        }

        private void IntegrationsMenuControl_ParabolicButtonClicked(object sender, EventArgs e)
        {
            ShowParabolicMethodControl();
        }

        private void DifferentiationMenuControl_ProgressiveButtonClicked(object sender, EventArgs e)
        {
            ShowProgressiveMenuControl();
        }

        private void DifferentiationMenuControl_DividedButtonClicked(object sender, EventArgs e)
        {
            ShowDividedMenuControl();
        }

        private void DifferentiationMenuControl_BackwardButtonClicked(object sender, EventArgs e)
        {
            ShowBackwardMenuControl();
        }

        // przyciski powrotu
        private void ApproxMenuControl_BackButtonClicked(object sender, EventArgs e)
        {
            ShowMainMenuControl();
        }

        private void InterpolationMenuControl_BackButtonClicked(object sender, EventArgs e)
        {
            ShowMainMenuControl();
        }

        private void IntegrationsMenuControl_BackButtonClicked(object sender, EventArgs e)
        {
            ShowMainMenuControl();
        }

        public void DifferentiationMenuControl_BackButtonClicked(object sender, EventArgs e)
        {
            ShowMainMenuControl();
        }

        private void ApproxFuncMenuControl_Task31ButtonClicked(object sender, EventArgs e)
        {
            ShowTask31Control();
        }

        private void ApproxFuncMenuControl_Task32ButtonClicked(object sender, EventArgs e)
        {
            ShowTask32Control();
        }

        private void Task11Control_BackButtonClicked(object sender, EventArgs e) 
        {
            ShowApproxMenuContol();
        }

        private void Task12Control_BackButtonClicked(object sender, EventArgs e)
        {
            ShowApproxMenuContol();
        }

        private void Task31Control_BackButtonClicked(object sender, EventArgs e)
        {
            ShowApproxFuncMenuControl();
        }

        private void Task32Control_BackButtonClicked(object sender, EventArgs e)
        {
            ShowApproxFuncMenuControl();
        }

        private void RectangleMethodControl_BackButtonClicked(object sender, EventArgs e)
        {
            ShowIntegrationsMenuControl();
        }

        private void TrapezodialMethodControl_BackButtonClicked(object sender, EventArgs e)
        {
            ShowIntegrationsMenuControl();
        }

        private void ParabolicMethodControl_BackButtonClicked(object sender, EventArgs e)
        {
            ShowIntegrationsMenuControl();
        }

        private void ProgressiveMenuControl_BackButtonClicked(object sender, EventArgs e)
        {
            ShowDifferentiationMenuControl();
        }

        private void BackwardMenuControl_BackButtonClicked(object sender, EventArgs e)
        {
            ShowDifferentiationMenuControl();
        }

        private void DividedMenuControl_BackButtonClicked(object sender, EventArgs e)
        {
            ShowDifferentiationMenuControl();
        }

        private void CreditsControl_BackButtonClicked(object sender, EventArgs e)
        {
            ShowMainMenuControl();
        }

        // metody generujące kontrolki
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
            mainMenuControl.IntegrationsButtonClicked += MainMenuControl_IntegrationsButtonClicked;
            mainMenuControl.DifferentiationButtonClicked += MainMenuCOntrol_DifferentiationButtonClicked;
            mainMenuControl.CreditsButtonClicked += MainMenuControl_CreditsButtonClicked;
            mainMenuControl.LanguageButtonClicked += MainMenuControl_LanguageButtonClicked;
        }

        private void ShowApproxMenuContol()
        {
            approxMenuControl = new ApproxMenuControl();
            approxMenuControl.Dock = DockStyle.Fill;

            Controls.Clear();
            Controls.Add(approxMenuControl);

            approxMenuControl.BackButtonClicked += ApproxMenuControl_BackButtonClicked;
            approxMenuControl.Task11ButtonClicked += ApproxMenuControl_Task11ButtonClicked;
            approxMenuControl.Task12ButtonClicked += ApproxMenuControl_Task12ButtonClicked;

        }
        
        private void ShowInterMenuControl()
        {
            interpolationMenuControl = new InterpolationMenuControl();
            interpolationMenuControl.Dock = DockStyle.Fill;

            Controls.Clear();
            Controls.Add(interpolationMenuControl);

            interpolationMenuControl.BackButtonClicked += InterpolationMenuControl_BackButtonClicked;
        }

        private void ShowApproxFuncMenuControl()
        {
            approxFuncControl = new ApproxFuncControl();
            approxFuncControl.Dock = DockStyle.Fill;

            Controls.Clear();
            Controls.Add(approxFuncControl);

            approxFuncControl.BackButtonClicked += ApproxFuncMenuControl_BackButtonClicked;
            approxFuncControl.Task31ButtonClicked += ApproxFuncMenuControl_Task31ButtonClicked;
            approxFuncControl.Task32ButtonClicked += ApproxFuncMenuControl_Task32ButtonClicked;
        }

        private void ShowIntegrationsMenuControl()
        {
            integrationsMenuControl = new IntegrationsMenuControl();
            integrationsMenuControl.Dock = DockStyle.Fill;

            Controls.Clear();
            Controls.Add(integrationsMenuControl);

            integrationsMenuControl.RectangleButtonClicked += IntegrationsMenuControl_RectangleButtonClicked;
            integrationsMenuControl.TrapezodialButtonClicked += IntegrationsMenuControl_TrapezodialButtonClicked;
            integrationsMenuControl.ParabolicButtonClicked += IntegrationsMenuControl_ParabolicButtonClicked;
            integrationsMenuControl.BackButtonClicked += IntegrationsMenuControl_BackButtonClicked;
        }

        private void ShowDifferentiationMenuControl()
        {
            differentiationMenuControl = new DifferentiationMenuControl();
            differentiationMenuControl.Dock = DockStyle.Fill;

            Controls.Clear();
            Controls.Add(differentiationMenuControl);

            differentiationMenuControl.ProgressiveButtonClicked += DifferentiationMenuControl_ProgressiveButtonClicked;
            differentiationMenuControl.BackwardButtonClicked += DifferentiationMenuControl_BackwardButtonClicked;
            differentiationMenuControl.DividedButtonClicked += DifferentiationMenuControl_DividedButtonClicked;
            differentiationMenuControl.BackButtonClicked += DifferentiationMenuControl_BackButtonClicked;
        }

        //metody do wyświetlania kontrolek zadań
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

        private void ShowTask31Control()
        {
            taskMenu31 = new TaskMenu31();
            taskMenu31.Dock = DockStyle.Fill;

            Controls.Clear();
            Controls.Add(taskMenu31);

            taskMenu31.BackButtonClicked += Task31Control_BackButtonClicked;
        }

        private void ShowTask32Control()
        {
            taskMenu32 = new TaskMenu32();
            taskMenu32.Dock = DockStyle.Fill;

            Controls.Clear();
            Controls.Add(taskMenu32);

            taskMenu32.BackButtonClicked += Task32Control_BackButtonClicked;
        }

        private void ShowRectangleMethodControl()
        {
            rectMethodControl = new RectangleMethodControl();
            rectMethodControl.Dock = DockStyle.Fill;

            Controls.Clear();
            Controls.Add(rectMethodControl);

            rectMethodControl.BackButtonClicked += RectangleMethodControl_BackButtonClicked;
        }

        private void ShowTrapezodialMethodControl()
        {
            trapezodialMethodControl = new TrapezodialMethodControl();
            trapezodialMethodControl.Dock = DockStyle.Fill;

            Controls.Clear();
            Controls.Add(trapezodialMethodControl);

            trapezodialMethodControl.BackButtonClicked += TrapezodialMethodControl_BackButtonClicked;
        }

        private void ShowParabolicMethodControl()
        {
            parabolicMethodControl = new ParabolicMethodControl();
            parabolicMethodControl.Dock = DockStyle.Fill;

            Controls.Clear();
            Controls.Add(parabolicMethodControl);

            parabolicMethodControl.BackButtonClicked += ParabolicMethodControl_BackButtonClicked;
        }

        private void ShowProgressiveMenuControl()
        {
            progressiveMenuControl = new ProgressiveMenuControl();
            progressiveMenuControl.Dock = DockStyle.Fill;

            Controls.Clear();
            Controls.Add(progressiveMenuControl);

            progressiveMenuControl.BackButtonClicked += ProgressiveMenuControl_BackButtonClicked;
        }

        private void ShowBackwardMenuControl()
        {
            backwardMenuControl = new BackwardMenuControl();
            backwardMenuControl.Dock = DockStyle.Fill;

            Controls.Clear();
            Controls.Add(backwardMenuControl);

            backwardMenuControl.BackButtonClicked += BackwardMenuControl_BackButtonClicked;
        }

        private void ShowDividedMenuControl()
        {
            dividedMenuControl = new DividedMenuControl();
            dividedMenuControl.Dock = DockStyle.Fill;

            Controls.Clear();
            Controls.Add(dividedMenuControl);

            dividedMenuControl.BackButtonClicked += DividedMenuControl_BackButtonClicked;
        }

        private void ShowCreditsControl()
        {
            creditsControl = new CreditsControl();
            creditsControl.Dock = DockStyle.Fill;

            Controls.Clear();
            Controls.Add(creditsControl);

            creditsControl.BackButtonClicked += CreditsControl_BackButtonClicked;
        }
    }
}
