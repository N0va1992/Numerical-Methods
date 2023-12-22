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
    public partial class CreditsControl : UserControl
    {
        public event EventHandler BackButtonClicked;
        public CreditsControl()
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
            creditsTitle.Text = LanguageManager.GetLocalizedString("creditsBtn");
            creditsLabel.Text = LanguageManager.GetLocalizedString("creditsLabel");
            backBtn11.Text = LanguageManager.GetLocalizedString("backBtn");
        }
    }
}
