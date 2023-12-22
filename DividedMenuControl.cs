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
    public partial class DividedMenuControl : UserControl
    {
        public event EventHandler BackButtonClicked;

        private List<double> xValues = new List<double>();
        private List<double> yValues = new List<double>();

        public DividedMenuControl()
        {
            InitializeComponent();
            UpdateLocalizedString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            double x, y;

            if (Double.TryParse(xTextBox.Text, out x) && Double.TryParse(yTextBox.Text, out y))
            {
                xValues.Add(x);
                yValues.Add(y);

                pointsListBox.Items.Add($"({x}, {y})");

                xTextBox.Clear();
                yTextBox.Clear();
            }
            else
            {
                MessageBox.Show(LanguageManager.GetLocalizedString("wrongXYMsg"), LanguageManager.GetLocalizedString("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            if (xValues.Count < 4)
            {
                MessageBox.Show(LanguageManager.GetLocalizedString("notEnoughtMsg2"), LanguageManager.GetLocalizedString("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //obliczanie ilorazów różnicowych
            List<double> dividedDifferences = CalculateDividedDifferences(yValues);

            //wyświetlanie wyników w list boxie
            resultListBox.Items.Clear();
            for (int i = 0; i < dividedDifferences.Count; i++)
            {
                resultListBox.Items.Add(LanguageManager.GetLocalizedString("dividedMsg") + (i + 1) + ":" + dividedDifferences[i]);
            }
        }

        private void backBtn11_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private List<double> CalculateDividedDifferences(List<double> values)
        {
            List<double> result = new List<double>();

            for (int i = 1; i < values.Count; i++)
            {
                result.Add((values[i] - values[i -1]) / (xValues[i] - xValues[i - 1]));
            }
            return result;
        }

        private void UpdateLocalizedString()
        {
            dividedTitle.Text = LanguageManager.GetLocalizedString("dividedTitle");
            addBtn.Text = LanguageManager.GetLocalizedString("addBtn");
            calculateBtn.Text = LanguageManager.GetLocalizedString("calculateBtn");
            pointsLabel.Text = LanguageManager.GetLocalizedString("pointsLabel");
            resultLabel.Text = LanguageManager.GetLocalizedString("resultLabel");
            backBtn11.Text = LanguageManager.GetLocalizedString("backBtn");
        }
    }
}
