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
    public partial class TaskMenu32 : UserControl
    {
        public event EventHandler BackButtonClicked;

        private List<double> xValues = new List<double>();
        private List<double> yValues = new List<double>();

        public TaskMenu32()
        {
            InitializeComponent();
            UpdateLocalizedString();

            label_A.Text = string.Empty;
            label_B.Text = string.Empty;
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // parsowanie danych wejściowych z text boxów
                ParseInput(textBox_X1.Text, textBox_Y1.Text);
                ParseInput(textBox_X2.Text, textBox_Y2.Text);
                ParseInput(textBox_X3.Text, textBox_Y3.Text);
                ParseInput(textBox_X4.Text, textBox_Y4.Text);
                ParseInput(textBox_X5.Text, textBox_Y5.Text);

                // wykonanie aproksymacji
                double[] coefficients = LinearApproximation(xValues, yValues);

                // wyświetlanie wyników w labelkach
                label_A.Text = $"a = {coefficients[0]:0.###}";
                label_B.Text = $"b = {coefficients[1]:0.###}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystapił błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backBtn11_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void ParseInput(string xText, string yText)
        {
            //parsowanie danych i dodawanie do list
            double x = double.Parse(xText);
            double y = double.Parse(yText);

            xValues.Add(x);
            yValues.Add(y);
        }

        private double[] LinearApproximation(List<double> xValues, List<double> yValues)
        {
            // implementacja aproksymacji liniowej
            double sumX = xValues.Sum();
            double sumY = yValues.Sum();
            double sumXY = xValues.Zip(yValues, (x, y)  => x * y).Sum();
            double sumXSquare = xValues.Sum(x => x * x);

            double a = (xValues.Count * sumXY - sumX * sumY) / (xValues.Count * sumXSquare - sumX * sumY);
            double b = (sumY - a * sumX) / xValues.Count;

            return new double[] { a, b };
        }

        private void UpdateLocalizedString()
        {
            Task31Task.Text = LanguageManager.GetLocalizedString("Task31Task");
            calculateBtn.Text = LanguageManager.GetLocalizedString("calculateBtn");
            backBtn11.Text = LanguageManager.GetLocalizedString("backBtn");
        }
    }
}
