using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using System.Security.Policy;
#pragma warning disable CS8622
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS0219

namespace TcgPlayerPricesWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.textBox1.KeyDown += textBox1_KeyDown;
            this.dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void UpdateDisplayData(string _input)
        {
            var myJSON = TcgParser.SearchCard(_input);
            var result = JsonConvert.DeserializeObject<dynamic>(myJSON);
            string[] AHRecord = new string[] { };

            var myInt = 0;

            dataGridView1.Rows.Clear();



            foreach (dynamic s in result.results[0].results)
            {
                if (s.marketPrice <= 0) continue;
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

            var myJSON = TcgParser.GetCardPriceHistory(row.Cells[5].Value.ToString());
            var result = JsonConvert.DeserializeObject<dynamic>(myJSON);

            double averagePrice = 0.00;
            int myCount = 0;

            foreach (dynamic s in result.result)
            {
                if (Double.TryParse(s.variants[0].marketPrice.ToString(), out double myDoub))
                {
                    averagePrice += myDoub;
                    myCount++;
                }
                else { break; }

            }

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
    }
}
