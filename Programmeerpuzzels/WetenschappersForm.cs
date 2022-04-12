using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programmeerpuzzels.wetenschappers
{
    public partial class WetenschappersForm : Form
    {
        BestTimeForWettenschappers bestTime = new BestTimeForWettenschappers();
        public WetenschappersForm()
        {
            InitializeComponent();
            bestTime.Generate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(bestTime.MostAlive().ToString());
        }
    }
}
