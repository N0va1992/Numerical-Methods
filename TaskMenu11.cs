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
    {
    public partial class TaskMenu11 : UserControl
        public TaskMenu11()
        {
            InitializeComponent();
            task11Task.Text = "Napisz i uruchom aplikację komputerową obliczającą błąd względny i bezwzględny po wprowadzeniu\r\ndwu liczb: dokładnej i przybliżonej.";
        }

        private void backBtn111_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
