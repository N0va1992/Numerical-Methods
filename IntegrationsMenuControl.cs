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

namespace numericalMethods
{
    public partial class IntegrationsMenuControl : UserControl
    {
        public event EventHandler BackButtonClicked;
        public IntegrationsMenuControl()
        {
            InitializeComponent();
            UpdateLocalizedString();
        }

        private void backBtn11_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void UpdateLocalizedString()
        {
            integrationsTitle.Text = LanguageManager.GetLocalizedString("integrationsTitle");
            integrationsTask.Text = LanguageManager.GetLocalizedString("integrationsTask");
            rectangleMethodBtn.Text = LanguageManager.GetLocalizedString("rectangleMethodBtn");
            trapezoidalMethodBtn.Text = LanguageManager.GetLocalizedString("trapezoidalMethodBtn");
            parabolicMethodBtn.Text = LanguageManager.GetLocalizedString("parabolicMethodBtn");
            backBtn11.Text = LanguageManager.GetLocalizedString("backBtn");
        }
    }
}
