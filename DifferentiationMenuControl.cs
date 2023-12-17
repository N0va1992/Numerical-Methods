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
    public partial class DifferentiationMenuControl : UserControl
    {
        public event EventHandler BackButtonClicked;
        public DifferentiationMenuControl()
        {
            InitializeComponent();
            UpdateLocalizedString();
        }

        private void backBtn11_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        public void UpdateLocalizedString()
        {
            differentiationTitle.Text = LanguageManager.GetLocalizedString("differentiationTitle");
            differentiationTask.Text = LanguageManager.GetLocalizedString("differentiationTask");
            progressiveBtn.Text = LanguageManager.GetLocalizedString("progressiveBtn");
            backwardBtn.Text = LanguageManager.GetLocalizedString("backwardBtn");
            dividedBtn.Text = LanguageManager.GetLocalizedString("dividedBtn");
            backBtn11.Text = LanguageManager.GetLocalizedString("backBtn");
        } 
    }
}
