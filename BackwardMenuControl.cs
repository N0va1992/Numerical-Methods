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
    public partial class BackwardMenuControl : UserControl
    {
        public event EventHandler BackButtonClicked;

        private List<double> xValues = new List<double>();
        private List<double> yValues = new List<double>();

        public BackwardMenuControl()
        {
            InitializeComponent();
            UpdateLocalizedString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            //dodanie punktu do listy
            if(double.TryParse(xTextBox.Text, out double x) && double.TryParse(yTextBox.Text, out double y)) 
            {
                xValues.Add(x);
                yValues.Add(y);
                pointsListBox.Items.Add($"({x}, {y})");
            }
            else
            {
                MessageBox.Show(LanguageManager.GetLocalizedString("wrongXYMsg"), LanguageManager.GetLocalizedString("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            xTextBox.Clear();
            yTextBox.Clear();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            //sprawdzenie czy mamy wystarczającą ilośc punktów
            if (xValues.Count < 4)
            {
                MessageBox.Show(LanguageManager.GetLocalizedString("notEnoughtMsg2"), LanguageManager.GetLocalizedString("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //obliczanie różnic wstecznych i ilorazów różnicowych
            double[] backwardDifferences = CalculateBackwardDifferences(yValues.ToArray());
            double[] differenceQuotients = CalculateDifferenceQuotients(backwardDifferences);

            //wyświetlanie wyników
            resultListBox.Items.Clear();
            resultListBox.Items.Add(LanguageManager.GetLocalizedString("backwardTitle") + ":");
            for (int i = 0; i <backwardDifferences.Length; i++)
            {
                resultListBox.Items.Add($"Δ^{i}y = {backwardDifferences[i]}");
            }

            resultListBox.Items.Add("\n" + LanguageManager.GetLocalizedString("quotientsMsg") +":");
            for (int i = 0; i < differenceQuotients.Length; i++)
            {
                resultListBox.Items.Add($"f[{i},{i + 1}] = {differenceQuotients[i]}");
            }
        }

        private double[] CalculateBackwardDifferences(double[] values)
        {
            int n = values.Length;
            double[] differences = new double[n];
            differences[0] = values[n - 1];

            for (int i = 1; i < n; i++)
            {
                for (int j = n - 1; j >= i; j--)
                {
                    values[j] = (values[j] - values[j - 1]) / (xValues[j] - xValues[j - 1]);
                }
                differences[i] = values[n - 1];
            }
            return differences;
        }

        private double[] CalculateDifferenceQuotients(double[] backwardDifferences)
        {
            int n = backwardDifferences.Length;
            double[] quotients = new double[n - 1];

            for (int i = 0; i < n - 1; i++)
            {
                quotients[i] = backwardDifferences[i + 1];
            }
            return quotients;
        }


        private void backBtn11_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void UpdateLocalizedString()
        {
            backwardTitle.Text = LanguageManager.GetLocalizedString("backwardTitle");
            addBtn.Text = LanguageManager.GetLocalizedString("addBtn");
            calculateBtn.Text = LanguageManager.GetLocalizedString("calculateBtn");
            pointsLabel.Text = LanguageManager.GetLocalizedString("pointsLabel");
            resultLabel.Text = LanguageManager.GetLocalizedString("resultLabel");
        }
        
    }
}
