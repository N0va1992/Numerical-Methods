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

namespace metodyNumeryczne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            title.Text = "Introduction to Numerical Methods" +
                "\n Computer Application";
        }

        private void languageBtn_Click(object sender, EventArgs e)
        {
            // Change language to English (en-US)
            LanguageManager.ChangeLanguage("en-US");

            // Update form controls with localized strings
            UpdateLocalizedStrings();
        }

        // Add this method to update localized strings on the form
        private void UpdateLocalizedStrings()
        {
            approximationsBtn.Text = LanguageManager.GetLocalizedString("approximationsBtn");
            interpolationsBtn.Text = LanguageManager.GetLocalizedString("interpolationsBtn");
            approxfuncBnt.Text = LanguageManager.GetLocalizedString("approxfuncBnt");
            integrationsBtn.Text = LanguageManager.GetLocalizedString("integrationsBtn");
            differentiationBtn.Text = LanguageManager.GetLocalizedString("differentiationBtn");
            languageBtn.Text = LanguageManager.GetLocalizedString("languageBtn");
            title.Text = LanguageManager.GetLocalizedString("formTitle");
        }
    }
}
