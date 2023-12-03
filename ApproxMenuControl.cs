using metodyNumeryczne;
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
    public partial class ApproxMenuControl : UserControl
    {
        public event EventHandler BackButtonClicked;
        public event EventHandler Task11ButtonClicked;
        private ApproxMenuControl approxMenuControl;

        public ApproxMenuControl()
        {
            InitializeComponent();
            UpdateLocalizedString();

            //obsługa zdarzenia SizeChanged
            this.SizeChanged += ApproxMenuControl_SizeChanged;
            approxMenuControl.Task11ButtonClicked += ApproxMenuControl_Task11ButtonClicked;
        }

        private void task11Btn_Click(object sender, EventArgs e)
        {
            Task11ButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void backBtn11_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void UpdateLocalizedString()
        {
            approxTitle.Text = LanguageManager.GetLocalizedString("approxTitle");
            task11Btn.Text = LanguageManager.GetLocalizedString("task11Btn");
            task12Btn.Text = LanguageManager.GetLocalizedString("task12Btn");
            backBtn11.Text = LanguageManager.GetLocalizedString("backBtn11");
        }

        private void ApproxMenuControl_SizeChanged(object sender, EventArgs e)
        {
            approxTitle.Width = this.Width;
            task11Btn.Width = this.Width - 10;
            task12Btn.Width = this.Width - 10;
        }

    }
}
