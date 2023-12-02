// Form1.cs
using System;
using System.Windows.Forms;

namespace metodyNumeryczne
{
    public partial class Form1 : Form
    {
        private MainMenuControl mainMenuControl;

        public Form1()
        {
            InitializeComponent();

            mainMenuControl = new MainMenuControl();
            mainMenuControl.Dock = DockStyle.Fill;

            // Podpięcie obsługi zdarzeń z UserControl
            mainMenuControl.ApproximationsButtonClicked += MainMenuControl_ApproximationsButtonClicked;
            mainMenuControl.InterpolationsButtonClicked += MainMenuControl_InterpolationsButtonClicked;
            mainMenuControl.LanguageButtonClicked += MainMenuControl_LanguageButtonClicked;

            Controls.Add(mainMenuControl);
        }

        private void MainMenuControl_ApproximationsButtonClicked(object sender, EventArgs e)
        {
            // Obsługa przycisku Approximations
            // Tu możesz wywołać kod związany z Approximations
        }

        private void MainMenuControl_InterpolationsButtonClicked(object sender, EventArgs e)
        {
            // Obsługa przycisku Interpolations
            // Tu możesz wywołać kod związany z Interpolations
        }

        private void MainMenuControl_LanguageButtonClicked(object sender, EventArgs e)
        {
            // Obsługa przycisku Language
            // Tu możesz wywołać kod związany z Language
        }
    }
}
