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
    public partial class ApproxFuncControl : UserControl
    {
        public event EventHandler Task31ButtonClicked;
        public event EventHandler Task32ButtonClicked;
        public event EventHandler BackButtonClicked;

        public ApproxFuncControl()
        {
            InitializeComponent();
            UpdateLocalizedString();

            task11Btn.Click += Task31ButtonClicked;
            task12Btn.Click += Task32ButtonClicked;
        }

        private void task11Btn_Click(object sender, EventArgs e)
        {
            Task31ButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void task12Btn_Click_1(object sender, EventArgs e)
        {
            Task32ButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void backBtn11_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void UpdateLocalizedString()
        {
            approxFuncTitle.Text = LanguageManager.GetLocalizedString("approxFuncTitle");
            task11Btn.Text = LanguageManager.GetLocalizedString("task11Btn");
            task12Btn.Text = LanguageManager.GetLocalizedString("task12Btn");
            backBtn11.Text = LanguageManager.GetLocalizedString("backBtn");
        }

        
    }
}
