using numericalMethods.Localization;
using System;
using System.Linq;
using System.Windows.Forms;

namespace numericalMethods
{
    public partial class InterpolationMenuControl : UserControl
    {
        public event EventHandler BackButtonClicked;

        public InterpolationMenuControl()
        {
            InitializeComponent();
            resultLabel.Text = string.Empty;
            UpdateLocalizedStrings();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            string xInput = xTextBox.Text;
            string fxInput = fxTextBox.Text;

            try
            {
                double[] xValues = ParseInput(xInput);
                double[] fxValues = ParseInput(fxInput);

                if (xValues.Length == fxValues.Length && xValues.Length >= 4)
                {
                    // Create cubic spline interpolation
                    var coefficients = CubicSplineInterpolation(xValues, fxValues);

                    // sprawdzenie czy interopolacja jest możliwa
                    if (coefficients != null)
                    {
                        string polynomialText = GeneratePolynomialText(coefficients, xValues);
                        resultLabel.Text = polynomialText;
                    }
                }
                else
                {
                    MessageBox.Show("Wprowadź co najmniej 4 pary (x, f(x)) danych.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Nieprawidłowy format danych. Wprowadź liczby oddzielone przecinkiem.");
            }
        }

        private double[] CubicSplineInterpolation(double[] x, double[] y)
        {
            int n = x.Length;
            double[] h = new double[n - 1];
            double[] alpha = new double[n - 1];
            double[] l = new double[n];
            double[] mu = new double[n - 1];
            double[] z = new double[n];

            for (int i = 0; i < n - 1; i++)
            {
                h[i] = x[i + 1] - x[i];
                alpha[i] = (3.0 / h[i]) * (y[i + 1] - y[i]) - (3.0 / (i > 0 ? h[i - 1] : h[i])) * (i > 0 ? alpha[i - 1] : 0);
            }

            l[0] = 1.0;
            mu[0] = 0.0;
            z[0] = 0.0;

            for (int i = 1; i < n - 1; i++)
            {
                l[i] = 2.0 * (x[i + 1] - x[i - 1]) - h[i - 1] * mu[i - 1];
                mu[i] = h[i] / l[i];
                z[i] = (alpha[i] - h[i - 1] * z[i - 1]) / l[i];
            }

            l[n - 1] = 1.0;
            z[n - 1] = 0.0;
            double[] c = new double[n];
            double[] b = new double[n - 1];
            double[] d = new double[n - 1];

            for (int j = n - 2; j >= 0; j--)
            {
                c[j] = z[j] - mu[j] * c[j + 1];
                b[j] = (y[j + 1] - y[j]) / h[j] - h[j] * (c[j + 1] + 2.0 * c[j]) / 3.0;
                d[j] = (c[j + 1] - c[j]) / (3.0 * h[j]);
            }

            double[] coefficients = new double[4 * (n - 1)];

            for (int i = 0; i < n - 1; i++)
            {
                coefficients[4 * i] = y[i];
                coefficients[4 * i + 1] = b[i];
                coefficients[4 * i + 2] = c[i];
                coefficients[4 * i + 3] = d[i];
            }

            return coefficients;
        }

        private string GeneratePolynomialText(double[] coefficients, double[] xValues)
        {
            // Build textual representation of the polynomial
            string polynomialText = "P(x) = ";

            for (int i = 0; i < coefficients.Length; i += 4)
            {
                if (i > 0)
                {
                    polynomialText += coefficients[i + 1] > 0 ? " + " : " - ";
                }
                polynomialText += Math.Abs(coefficients[i + 1]).ToString("0.00"); // Formatowanie do 2 miejsc po przecinku

                if (i < coefficients.Length - 4)
                {
                    polynomialText += "(x - " + xValues[(i / 4)] + ")";
                }
            }
            return polynomialText;
        }

        private double[] ParseInput(string input)
        {
            // Split input data using a comma
            string[] values = input.Split(',');

            // Convert strings to numbers
            return values.Select(v => double.Parse(v)).ToArray();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        public void UpdateLocalizedStrings()
        {
            // Kod aktualizacji lokalizowanych ciągów
            interpolationTitle.Text = LanguageManager.GetLocalizedString("interpolationTitle");
            interTaskText.Text = LanguageManager.GetLocalizedString("interTaskText");
            interLabel.Text = LanguageManager.GetLocalizedString("interLabel");
            calculateBtn.Text = LanguageManager.GetLocalizedString("calculateBtn");
            backBtn.Text = LanguageManager.GetLocalizedString("backBtn");
        }
    }

}
