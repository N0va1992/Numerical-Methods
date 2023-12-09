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

        public TaskMenu32()
        {
            InitializeComponent();
            Task31Task.Text = "Napisz i uruchom aplikację komputerową, która na podstawie poniższych danych:\r\n(0.955, 5.722), (1.38, 4.812), (1.854, 4.727), (2.093, 4.850), (2.674, 5.011), (3.006, 5.253), (3.255,\r\n5.617), (3.940, 6.282), (4.060, 6.255)\r\nużywając jako funkcji bazowych następujących funkcji: 1/x , x , x2, znajdzie funkcję aproksymacyjną.";
        }

        private void backBtn11_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
