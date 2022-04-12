using Programmeerpuzzels.wetenschappers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programmeerpuzzels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PoolseVlag vlag = new PoolseVlag();
            vlag.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WetenschappersForm wetenschappers = new WetenschappersForm();
            wetenschappers.ShowDialog();
        }
    }
}
