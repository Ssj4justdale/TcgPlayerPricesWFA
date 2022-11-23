namespace TcgPlayerPricesWFA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cardName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardRarity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardSet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.Location = new System.Drawing.Point(63, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1017, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cardName,
            this.cardNumber,
            this.cardRarity,
            this.cardSet,
            this.cardPrice});
            this.dataGridView1.Location = new System.Drawing.Point(12, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1069, 403);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cardName
            // 
            this.cardName.HeaderText = "Card Name";
            this.cardName.Name = "cardName";
            this.cardName.ReadOnly = true;
            this.cardName.Width = 300;
            // 
            // cardNumber
            // 
            this.cardNumber.HeaderText = "Card Number";
            this.cardNumber.Name = "cardNumber";
            this.cardNumber.ReadOnly = true;
            this.cardNumber.Width = 125;
            // 
            // cardRarity
            // 
            this.cardRarity.HeaderText = "Card Rarity";
            this.cardRarity.Name = "cardRarity";
            this.cardRarity.ReadOnly = true;
            this.cardRarity.Width = 200;
            // 
            // cardSet
            // 
            this.cardSet.HeaderText = "Card Set";
            this.cardSet.Name = "cardSet";
            this.cardSet.ReadOnly = true;
            this.cardSet.Width = 300;
            // 
            // cardPrice
            // 
            this.cardPrice.HeaderText = "Market Price";
            this.cardPrice.Name = "cardPrice";
            this.cardPrice.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(960, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 12);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn cardName;
        private DataGridViewTextBoxColumn cardNumber;
        private DataGridViewTextBoxColumn cardRarity;
        private DataGridViewTextBoxColumn cardSet;
        private DataGridViewTextBoxColumn cardPrice;
        private Button button1;
    }
}