using MetodyNumeryczne;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace metodyNumeryczne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.Add("en-US");
            comboBox1.Items.Add("pl-PL");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ustaw domyślny język
            LanguageManager.Initialize("en-US");
            UpdateUI();
        }

        private void UpdateUI()
        {
            title.Text = LanguageManager.GetLocalizedString("Label1Text");
            approximationsBtn.Text = LanguageManager.GetLocalizedString("Approximations");
            // Dodaj kolejne kontrolki, które chcesz tłumaczyć
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string selectedLanguageCode = comboBox1.SelectedItem.ToString();
                LanguageManager.Initialize(selectedLanguageCode);
                UpdateUI();
            }
        }
    }
}
