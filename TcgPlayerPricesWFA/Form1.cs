using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using System.Security.Policy;
#pragma warning disable CS8622
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS0219
#pragma warning disable CS8600

namespace TcgPlayerPricesWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.textBox1.KeyDown += textBox1_KeyDown;
            this.dataGridView1.CellClick += dataGridView1_CellClick;
            this.dataGridView1.SortCompare += dataGridView1_SortCompare;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void UpdateDisplayData(string _input)
        {
            if (_input == "") return;
            var myQuery = TcgParser.SearchCard(_input);
            var myJSON = myQuery[0];
            var result = JsonConvert.DeserializeObject<dynamic>(myJSON);
            string[] AHRecord = new string[] { };

            var myInt = 0;

            dataGridView1.Rows.Clear();

            if ((myQuery[0] == "" || _input=="") || (myQuery[0] == null || _input == null || result == null)) return;

            foreach (dynamic s in result.results[0].results)
            {
                if (s.marketPrice <= 0 || s?.customAttributes?.number == null) continue;
                if (myQuery[1] != "")
                {
                    if (s.customAttributes.number.ToString() != myQuery[1]) continue;
                }
                AHRecord = new string[] { s.productName, s.customAttributes.number, s.rarityName, s.setName, string.Format("{0:C2}", s.marketPrice), s.productId.ToString() };
                dataGridView1.Rows.Add(AHRecord);
                myInt++;
            }
            

            
            /*
            while (myInt <= 18)
            {
                myInt++;
                AHRecord = new string[] { "", "", "", "", "" };
                dataGridView1.Rows.Add(AHRecord);
            }
            */
            //AHRecord = new string[] { result.results[0].results[0].setName };

            //string[] AHRecord = new string[] { "Adrian", "Hewitt", "Male", "Adrian", myInt.ToString() };//"test" };//result.data.results[0].results[0].rarityName};


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex > dataGridView1.Rows.Count) return;

            var rowIndex = e.RowIndex;
            var cIndex = 4;

            DataGridViewRow row = dataGridView1.Rows[rowIndex];

            //monthly view
            var myJSON = TcgParser.GetCardPriceHistory(row.Cells[5].Value.ToString());
            var result = JsonConvert.DeserializeObject<dynamic>(myJSON);

            double averagePrice = 0.00;
            int myCount = 0;


            PlotView _mPlotView = ThreadHandler.GeneratePlotView();
            LineSeries lineSeries = new LineSeries();

            foreach (dynamic s in result.result)
            {
                if (Double.TryParse(s.variants[0].marketPrice.ToString(), out double myDoub))
                {
                    ThreadHandler.PlotPoints(lineSeries, DateTimeAxis.ToDouble(DateTime.Parse(s.date.ToString())), myDoub);
                    averagePrice += myDoub;
                    myCount++;
                }
                else { break; }

            }

            ThreadHandler.GenerateAxesis(_mPlotView);
            ThreadHandler.GenerateModel(_mPlotView, lineSeries);

            //quarterly view
            PlotView _qPlotView = ThreadHandler.GeneratePlotView();
            Thread _qThread = new Thread((ThreadStart)delegate
            {
                var _qMyJSON = TcgParser.GetCardPriceHistory(row.Cells[5].Value.ToString(), "quarter");
                var _qResult = JsonConvert.DeserializeObject<dynamic>(_qMyJSON);

                LineSeries _qLineSeries = new LineSeries();

                foreach (dynamic s in _qResult.result)
                {
                    if (Double.TryParse(s.variants[0].marketPrice.ToString(), out double myDoub))
                    {
                        ThreadHandler.PlotPoints(_qLineSeries, DateTimeAxis.ToDouble(DateTime.Parse(s.date.ToString())), myDoub);
                    }
                    else { break; }

                }

                ThreadHandler.GenerateAxesis(_qPlotView);
                ThreadHandler.GenerateModel(_qPlotView, _qLineSeries);
            });
 

            //semi-annual view
            PlotView _sPlotView = ThreadHandler.GeneratePlotView();
            Thread _sThread = new Thread((ThreadStart)delegate {
                //semi-annual view
                var _sMyJSON = TcgParser.GetCardPriceHistory(row.Cells[5].Value.ToString(), "semi-annual");
                var _sResult = JsonConvert.DeserializeObject<dynamic>(_sMyJSON);

                
                LineSeries _sLineSeries = new LineSeries();

                foreach (dynamic s in _sResult.result)
                {
                    if (Double.TryParse(s.variants[0].marketPrice.ToString(), out double myDoub))
                    {
                        ThreadHandler.PlotPoints(_sLineSeries, DateTimeAxis.ToDouble(DateTime.Parse(s.date.ToString())), myDoub);
                    }
                    else { break; }

                }

                ThreadHandler.GenerateAxesis(_sPlotView);
                ThreadHandler.GenerateModel(_sPlotView, _sLineSeries);
            });




            //annual view
            PlotView _aPlotView = ThreadHandler.GeneratePlotView();
            Thread _aThread = new Thread((ThreadStart)delegate
            {
                var _aMyJSON = TcgParser.GetCardPriceHistory(row.Cells[5].Value.ToString(), "annual");
                var _aResult = JsonConvert.DeserializeObject<dynamic>(_aMyJSON);

                LineSeries _aLineSeries = new LineSeries();

                foreach (dynamic s in _aResult.result)
                {
                    if (Double.TryParse(s.variants[0].marketPrice.ToString(), out double myDoub))
                    {
                        ThreadHandler.PlotPoints(_aLineSeries, DateTimeAxis.ToDouble(DateTime.Parse(s.date.ToString())), myDoub);
                    }
                    else { break; }

                }

                ThreadHandler.GenerateAxesis(_aPlotView);
                ThreadHandler.GenerateModel(_aPlotView, _aLineSeries);

            });

            _qThread.Start();
            _sThread.Start();
            _aThread.Start();
           


            //end styles


            ThreadHandler.DisplayForm2(_mPlotView, _qPlotView, _sPlotView, _aPlotView, row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[5].Value.ToString());

            averagePrice = (double)averagePrice / (double)myCount;


            if (row.Cells[cIndex].Style.BackColor != Color.Red && row.Cells[cIndex].Style.BackColor != Color.Green)
            {
                row.Cells[cIndex].Style.WrapMode = DataGridViewTriState.True;
                if (Double.TryParse(row.Cells[cIndex].Value.ToString().Substring(1), out double myDoub))
                {
                    if (myDoub < averagePrice)
                    {

                        row.Cells[cIndex].Style.BackColor = Color.Red;
                        row.Cells[cIndex].Style.SelectionBackColor = Color.Red;
                    }
                    else
                    {
                        row.Cells[cIndex].Style.BackColor = Color.Green;
                        row.Cells[cIndex].Style.SelectionBackColor = Color.Green;
                    }

                    row.Cells[cIndex].Style.ForeColor = Color.Black;
                    row.Cells[cIndex].Style.SelectionForeColor = Color.Black;
                }


                row.Cells[cIndex].Value = row.Cells[cIndex].Value.ToString() + "\n\nAverage Price: " + string.Format("{0:C2}", Double.Parse(averagePrice.ToString())) + "\nMarket Price: " + row.Cells[cIndex].Value.ToString();

            }

            _qThread.Join();
            _sThread.Join();
            _aThread.Join();

            _qThread = null;
            _sThread = null;
            _aThread = null;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //UpdateDisplayData(textBox1.Text);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button1.PerformClick();
                e.Handled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateDisplayData(textBox1.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UpdateDisplayData(textBox1.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView1_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            // Try to sort based on the cells in the current column.
            if(e.Column.Index == 4)
            {
                e.SortResult = ColumnFourCompare(e.CellValue1.ToString(), e.CellValue2.ToString());

            } else
            {
                e.SortResult = System.String.Compare(e.CellValue1.ToString(), e.CellValue2.ToString());
            }

            e.Handled = true;
        }

        public int ColumnFourCompare(string X, string Y)
        {
            double _x = Double.Parse(X.Split("$")[1]);
            double _y = Double.Parse(Y.Split("$")[1]);

            int _return = 0;
            if(_x > _y)
            {
                _return = 1;
            } else if(_x == _y)
            {
                _return = 0;
            } else if(_x < _y)
            {
                _return = -1;
            }

            return _return;
        }
    }
}
