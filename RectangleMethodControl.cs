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
    public partial class RectangleMethodControl : UserControl
    {
        public event EventHandler BackButtonClicked;

        public RectangleMethodControl()
        {
            InitializeComponent();
            resultLabel.Text = string.Empty;
            UpdateLocalizedString();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            //pobieranie współczynników wielomianu
            string[] coefficientsStr = coefficientsTextBox.Text.Split(',');
            double[] coefficients = new double[coefficientsStr.Length];
            for (int i = 0; i < coefficientsStr.Length; i++)
            {
                coefficients[i] = double.Parse(coefficientsStr[i]);
            }

            //pobieranie przedziału [a, b] i dokładności
            double a = double.Parse(aTextBox.Text);
            double b = double.Parse(bTextBox.Text);
            double accuracy = double.Parse(accuracyTextBox.Text);

            //obliczanie wartości całko metodą prostokątów
            double result = RectangleMethod(a, b, accuracy, coefficients);

            //wyświetlanie wyniku
            resultLabel.Text = result.ToString();
        }

        private void backBtn11_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private double RectangleMethod(double a, double b, double accuracy, double[] coefficients)
        {
            int rectangleQuantity = 1000; //liczba prostokątów
            double h = (b - a) / rectangleQuantity;
            double sum = 0;

            for (int i = 0; i < rectangleQuantity; i++)
            {
                double x = a + i * h;
                double rectangleArea = h * PolynomialValue(x, coefficients);
                sum += rectangleArea;
            }
            return Math.Abs(sum);
        }

        private double PolynomialValue(double x, double[] coefficients)
        {
            double result = 0;

            for (int i = 0;i < coefficients.Length;i++)
            {
                result += coefficients[i] * Math.Pow(x, i);
            }

            return result;
        }

        private void UpdateLocalizedString()
        {
            calculateBtn.Text = LanguageManager.GetLocalizedString("calculateBtn");
            backBtn11.Text = LanguageManager.GetLocalizedString("backBtn");
            rectangleTitle.Text = LanguageManager.GetLocalizedString("rectangleTitle");
            coefficientsLabel.Text = LanguageManager.GetLocalizedString("coefficientsLabel");
            accuracyLabel.Text = LanguageManager.GetLocalizedString("accuracyLabel");
            resultTxt.Text = LanguageManager.GetLocalizedString("resultTxt");
        }

        
    }
}
