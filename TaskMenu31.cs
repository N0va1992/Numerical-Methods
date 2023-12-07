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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace numericalMethods
{
    public partial class TaskMenu31 : UserControl
    {
        public EventHandler BackButtonClicked;

        private List<double> xValues = new List<double>();
        private List<double> yValues = new List<double>();

        public TaskMenu31()
        {
            InitializeComponent();
            UpdateLocalizedString();
            resultLabel.Text = string.Empty;
        }

        private void backBtn11_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            // Sprawdzenie poprawności danych
            if (!double.TryParse(textBoxXi.Text, out double x) || !double.TryParse(textBoxYi.Text, out double y))
            {
                MessageBox.Show("Wprowadź poprawne wartości x i y.", "Błąd danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Dodanie nowych danych do list
            xValues.Add(x);
            yValues.Add(y);

            // Obliczenia
            double n = xValues.Count;

            double xSum = xValues.Sum();
            double ySum = yValues.Sum();
            double xySum = xValues.Zip(yValues, (xi, yi) => xi * yi).Sum();
            double xSquaredSum = xValues.Sum(xi => xi * xi);

            // Współczynniki funkcji liniowej y = a + bx
            double b = (n * xySum - xSum * ySum) / (n * xSquaredSum - xSum * xSum);
            double a = (ySum - b * xSum) / n;

            // Wynik
            resultLabel.Text = $"y = {a} + {b}x";
        }

        private void UpdateLocalizedString()
        {
            approxFuncTask1Task.Text = LanguageManager.GetLocalizedString("approxFuncTask1Task");
            calculateBtn.Text = LanguageManager.GetLocalizedString("calculateBtn");
            resultTextLabel.Text = LanguageManager.GetLocalizedString("resultTextLabel");
            backBtn11.Text = LanguageManager.GetLocalizedString("backBtn");
        }
    }
}
