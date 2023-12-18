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
    public partial class ProgressiveMenuControl : UserControl
    {
        public event EventHandler BackButtonClicked;

        private List<double> xValues;
        private List<double> yValues;

        public ProgressiveMenuControl()
        {
            InitializeComponent();

            xValues = new List<double>();
            yValues = new List<double>();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            //dodawanie punktów do list
            double x, y;
            if (Double.TryParse(xTextBox.Text, out x) && Double.TryParse(fxTextBox.Text, out y))
            {
                xValues.Add(x);
                yValues.Add(y);
                MessageBox.Show(LanguageManager.GetLocalizedString("addMsg") + "(" + x + ", " + y + ")");
            }
            else
            {
                MessageBox.Show(LanguageManager.GetLocalizedString("errorMsg"));
            }
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            // sprawdzenie czy istnieje wystarczająca ilość punktów
            if (xValues.Count < 2)
            {
                MessageBox.Show(LanguageManager.GetLocalizedString("notEnoughtMsg"));
                return;
            }

            //obliczenia różnic progresywnych
            List<List<double>> progressiveDiff = CalculateProgDiff();

            //wyświetlanie wyników w DataGridView
            UpdateDataGridView(progressiveDiff);
        }

        private List<List<double>> CalculateProgDiff()
        {
            List<List<double>> progressiveDiff = new List<List<double>>();
            progressiveDiff.Add(new List<double>(yValues));

            for (int j = 1; j <yValues.Count; j++)
            {
                List<double> diffLevel = new List<double>();

                for (int i = 0; i < yValues.Count - j; i++)
                {
                    double diff = progressiveDiff[j - 1][i + 1] - progressiveDiff[j - 1][i];
                    diffLevel.Add(diff);
                }
                progressiveDiff.Add(diffLevel);
            }
            return progressiveDiff;
        }

        private void UpdateDataGridView(List<List<double>> progressiveDiff)
        {
            // wyczyszczenie tabeli
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            //dodanie kolumn do DGV
            for (int i = 0; i < progressiveDiff.Count; i++)
            {
                dataGridView1.Columns.Add(LanguageManager.GetLocalizedString("column") + i, LanguageManager.GetLocalizedString("different") + i);
            }

            //dodanie danych do DGV
            for (int i = 0; i < progressiveDiff[0].Count; i++)
            {
                List<string> row = new List<string>();

                for (int j = 0; j < progressiveDiff.Count;)
                {
                    //sprawdzenie czy lista ma wystarczająca pojemność
                    if (i < progressiveDiff[j].Count)
                    {
                        row.Add(progressiveDiff[j][i].ToString());
                    }
                    else
                    {
                        row.Add("");
                    }
                    
                }
                dataGridView1.Rows.Add(row.ToArray());
            }
        }

        private void backBtn11_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }
       
    }
}
