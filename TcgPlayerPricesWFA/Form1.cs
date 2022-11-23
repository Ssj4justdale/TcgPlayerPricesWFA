using Newtonsoft.Json;

namespace TcgPlayerPricesWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.textBox1.KeyDown += textBox1_KeyDown;
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
                AHRecord = new string[] { s.productName, s.customAttributes.number, s.rarityName, s.setName, string.Format("{0:C2}", s.marketPrice) };
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
