using OxyPlot.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcgPlayerPricesWFA
{
    public partial class Form2 : Form
    {
        public Form2(PlotView myPlot)
        {
            InitializeComponent();
            Controls.Add(myPlot);
        }

        private void plotView1_Click(object sender, EventArgs e)
        {

        }

        private void plotView1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
