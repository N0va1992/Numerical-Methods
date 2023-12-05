using System;
using System.Linq;
using System.Windows.Forms;
using MathNet.Numerics.Interpolation;

namespace numericalMethods
{
    public partial class InterpolationMenuControl : UserControl
    {
        public event EventHandler BackButtonClicked;

        public InterpolationMenuControl()
        {
            InitializeComponent();
            interTaskText.Text = "Napisz i uruchom aplikację komputerową, która na podstawie wprowadzonych czterech par wielkości (x, f(x)) znajduje wielomian interpolacyjny trzeciego stopnia przybliżający tę funkcję f(x).Jeżeli wykonanie tej operacji jest niemożliwe, to program powinien poinformować o tym użytkownika.";
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
                    var spline = CubicSpline.InterpolateNatural(xValues, fxValues);

                    // Generate textual representation of the polynomial
                    string polynomialText = GeneratePolynomialText(spline);

                    resultLabel.Text = polynomialText;
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

        private string GeneratePolynomialText(IInterpolation spline)
        {
            // Build textual representation of the polynomial
            string polynomialText = "P(x) = ";

            for (int i = 0; i < spline.PointCount - 1; i++)
            {
                if (i > 0)
                {
                    polynomialText += spline.Coefficients[i][2] > 0 ? " + " : " - ";
                }
                polynomialText += Math.Abs(spline.Coefficients[i][2]);

                if (i < spline.PointCount - 2)
                {
                    polynomialText += "(x - " + spline.Coefficients[i][1] + ")";
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
    }
}
