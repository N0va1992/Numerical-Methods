using MathNet.Numerics;
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
    public partial class ParabolicMethodControl : UserControl
    {
        public event EventHandler BackButtonClicked;
        public ParabolicMethodControl()
        {
            InitializeComponent();
            resultLabel.Text = string.Empty;
            iterationsLabel.Text = string.Empty;
            UpdateLocalizedString();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            // pobieranie współczynników wielomianu
            string[] coefficientsStr = coefficientsTextBox.Text.Split(',');
            double[] coefficients = new double[coefficientsStr.Length];

            for (int i = 0; i < coefficientsStr.Length; i++)
            {
                coefficients[i] = double.Parse(coefficientsStr[i]);
            }

            //pobieranie przedziału [a, b] oraz dokładności
            double a = double.Parse(aTextBox.Text);
            double b = double.Parse(bTextBox.Text);
            double accuracy = double.Parse(accuracyTextBox.Text);

            //wywołanie metody parabol i otrzymanie wyniku i liczby iteracji
            int iterations;
            double result = ParabolicMethod(a, b, accuracy, coefficients, out iterations);

            //wyświetlanie wyników
            resultLabel.Text = result.ToString();
            iterationsLabel.Text = iterations.ToString();
        }

        private void backBtn11_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void UpdateLocalizedString()
        {
            calculateBtn.Text = LanguageManager.GetLocalizedString("calculateBtn");
            backBtn11.Text = LanguageManager.GetLocalizedString("backBtn");
            parabolicTitle.Text = LanguageManager.GetLocalizedString("parabolicTitle");
            coefficientsLabel.Text = LanguageManager.GetLocalizedString("coefficientsLabel");
            accuracyLabel.Text = LanguageManager.GetLocalizedString("accuracyLabel");
            resultTxt.Text = LanguageManager.GetLocalizedString("resultTxt");
            iterationsTxt.Text = LanguageManager.GetLocalizedString("iterationsTxt");
        }

        private double ParabolicMethod(double a, double b, double accuracy, double[] coefficients, out int iterations)
        {
            int subintervalsNumber = 1000; // początkowa liczba podprzedziałów
            double h = (b - a) / subintervalsNumber;
            double previousApprox = double.MaxValue;
            iterations = 0;

            while (true)
            {
                double sum = 0;

                for (int i = 0; i < subintervalsNumber; i++)
                {
                    double x1 = a + i * h;
                    double x2 = a + (i + 1) * h;
                    double x3 = a + (i + 2) * h;

                    sum += (h / 3) * (PolynomialValue(x1, coefficients) + 4 * PolynomialValue(x2, coefficients) + PolynomialValue(x3, coefficients));
                }

                // odejmujemy błąd
                sum -= (h / 3) * (PolynomialValue(a, coefficients) + PolynomialValue(b, coefficients));

                // zliczanie iteracji na koniec pętli
                iterations += subintervalsNumber;

                // sprawdzenie warunków dokładności
                if (Math.Abs(previousApprox - sum) < accuracy)
                    break;

                previousApprox = sum;
                subintervalsNumber *= 2;
                h /= 2;
            }

            return Math.Abs(previousApprox);
        }

        private double PolynomialValue(double x, double[] coefficients)
        {
            double result = 0;

            for (int i = 0; i<coefficients.Length; i++)
            {
                result += coefficients[i] * Math.Pow(x, i);
            }

            return result;
        }

    }
}
