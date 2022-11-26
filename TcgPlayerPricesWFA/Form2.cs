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
        private PlotView monthView;
        private PlotView quarterView;
        private PlotView semiView;
        private PlotView annualView;

        public Form2(PlotView _mView, PlotView _qView, PlotView _sView, PlotView _aView)
        {
            InitializeComponent();
            Controls.Add(_mView);
            Controls.Add(_qView);
            Controls.Add(_sView);
            Controls.Add(_aView);

            this.monthView = _mView;
            this.quarterView = _qView;
            this.semiView = _sView;
            this.annualView = _aView;
        }

        private void plotView1_Click(object sender, EventArgs e)
        {

        }

        private void plotView1_Click_1(object sender, EventArgs e)
        {

        }

        public void monthChartView()
        {
            DisplayThisChart(this.monthView);
        }

        public void quarterChartView()
        {
            DisplayThisChart(this.quarterView);
        }

        public void semiChartView()
        {
            DisplayThisChart(this.semiView);
        }

        public void annualChartView()
        {
            DisplayThisChart(this.annualView);
        }

        public void DisplayThisChart(PlotView _plot)
        {
            this.monthView.Visible = false;
            this.quarterView.Visible = false;
            this.semiView.Visible = false;
            this.annualView.Visible = false;
            _plot.Visible = true;
        }

        private void monthlyButton_Click(object sender, EventArgs e)
        {
            monthChartView();
        }

        private void quarterButton_Click(object sender, EventArgs e)
        {
            quarterChartView();
        }
    }
}
