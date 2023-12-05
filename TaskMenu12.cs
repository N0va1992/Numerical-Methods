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
    public partial class TaskMenu12 : UserControl
    {
        public event EventHandler BackButtonClicked;
        public TaskMenu12()
        {
            InitializeComponent();
            UpdateLocalizedString();
            deficiencyResult.Text = string.Empty;
            surplusResult.Text = string.Empty;
        }

        private void backBtn112_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void calculateBtn12_Click(object sender, EventArgs e)
        {
            if (double.TryParse(approxValueTextBox.Text, out double approxValue) 
                && double.TryParse(absoluteValueTextBox.Text, out double absoluteError)) 
            {
                //obliczanie dokładnej wartości liczby
                double exactValueWithDeficiency = approxValue - absoluteError;
                double exactValueWithSurplus = approxValue + absoluteError;

                deficiencyResult.Text = exactValueWithDeficiency.ToString();
                surplusResult.Text = exactValueWithSurplus.ToString();
            }
            else
            {
                deficiencyResult.Text = LanguageManager.GetLocalizedString("invalidValue");
                surplusResult.Text = LanguageManager.GetLocalizedString("invalidValue");
            }
        }

        private void UpdateLocalizedString()
        {
            task12Task.Text = LanguageManager.GetLocalizedString("task12Task");
            appValue1.Text = LanguageManager.GetLocalizedString("appValue1");
            absError1.Text = LanguageManager.GetLocalizedString("absError1");
            calculateBtn12.Text = LanguageManager.GetLocalizedString("calculateBtn");
            underestimationText.Text = LanguageManager.GetLocalizedString("underestimationText");
            overestimationText.Text = LanguageManager.GetLocalizedString("overestimationText");
            backBtn112.Text = LanguageManager.GetLocalizedString("backBtn");
        }

        
    }
}
