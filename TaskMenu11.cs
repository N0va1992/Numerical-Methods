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
    
    public partial class TaskMenu11 : UserControl
    {

        public event EventHandler BackButtonClicked;
        public TaskMenu11()
        {
            InitializeComponent();
            UpdateLocalizedString();
            absResult.Text = string.Empty;
            relResult.Text = string.Empty;
        }

        private void backBtn111_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }
        private void calculateBtn11_Click(object sender, EventArgs e)
        {
            //Pobranie wartości z textboxów dla liczb dokładnej i przybliżonej
            if (double.TryParse(exactTextBox.Text, out double exactValue) 
                && double.TryParse(approximateTextBox.Text, out double approxValue))
            {
                //Obliczanie błędu względnego i bezwzględnego
                double absoluteError = Math.Abs(exactValue - approxValue);
                double relativeError = absoluteError / Math.Abs(exactValue);

                //Wyświetlanie wyniku w labelkach
                absResult.Text = absoluteError.ToString("F2");
                relResult.Text = (relativeError * 100).ToString("F2") + "%";  // wyświetlanie błędu względnego w %              
            }
            else
            {
                absResult.Text = LanguageManager.GetLocalizedString("invalidValues");
                relResult.Text = LanguageManager.GetLocalizedString("invalidValues");

            }
        }

        private void UpdateLocalizedString()
        {
            task11Task.Text = LanguageManager.GetLocalizedString("task11Task");
            exNumber.Text = LanguageManager.GetLocalizedString("exNumber");
            appNumber.Text = LanguageManager.GetLocalizedString("appNumber");
            calculateBtn11.Text = LanguageManager.GetLocalizedString("calculateBtn");
            absoluteErrorLabel.Text = LanguageManager.GetLocalizedString("absoluteErrorLabel");
            relativeErrorLabel.Text = LanguageManager.GetLocalizedString("relativeErrorLabel");
            backBtn111.Text = LanguageManager.GetLocalizedString("backBtn");
            
            
        }
    }
}
