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
            label_A.Text = string.Empty;
            label_B.Text = string.Empty;
            Task31Task.Text = "Napisz i uruchom aplikację komputerową, która na podstawie poniższych danych:\r\n(0.955, 5.722), (1.38, 4.812), (1.854, 4.727), (2.093, 4.850), (2.674, 5.011), (3.006, 5.253), (3.255,\r\n5.617), (3.940, 6.282), (4.060, 6.255)\r\nużywając jako funkcji bazowych następujących funkcji: 1/x , x , x2, znajdzie funkcję aproksymacyjną.";
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
    }
}
