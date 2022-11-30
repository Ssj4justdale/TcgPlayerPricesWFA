namespace TcgPlayerPricesWFA
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthlyButton = new System.Windows.Forms.Button();
            this.quarterButton = new System.Windows.Forms.Button();
            this.semiButton = new System.Windows.Forms.Button();
            this.annualButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // monthlyButton
            // 
            this.monthlyButton.Location = new System.Drawing.Point(634, 249);
            this.monthlyButton.Name = "monthlyButton";
            this.monthlyButton.Size = new System.Drawing.Size(75, 23);
            this.monthlyButton.TabIndex = 1;
            this.monthlyButton.Text = "1m";
            this.monthlyButton.UseVisualStyleBackColor = true;
            this.monthlyButton.Click += new System.EventHandler(this.monthlyButton_Click);
            // 
            // quarterButton
            // 
            this.quarterButton.Location = new System.Drawing.Point(715, 249);
            this.quarterButton.Name = "quarterButton";
            this.quarterButton.Size = new System.Drawing.Size(75, 23);
            this.quarterButton.TabIndex = 2;
            this.quarterButton.Text = "3m";
            this.quarterButton.UseVisualStyleBackColor = true;
            this.quarterButton.Click += new System.EventHandler(this.quarterButton_Click);
            // 
            // semiButton
            // 
            this.semiButton.Location = new System.Drawing.Point(634, 278);
            this.semiButton.Name = "semiButton";
            this.semiButton.Size = new System.Drawing.Size(75, 23);
            this.semiButton.TabIndex = 3;
            this.semiButton.Text = "6m";
            this.semiButton.UseVisualStyleBackColor = true;
            this.semiButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // annualButton
            // 
            this.annualButton.Location = new System.Drawing.Point(715, 278);
            this.annualButton.Name = "annualButton";
            this.annualButton.Size = new System.Drawing.Size(75, 23);
            this.annualButton.TabIndex = 4;
            this.annualButton.Text = "1y";
            this.annualButton.UseVisualStyleBackColor = true;
            this.annualButton.Click += new System.EventHandler(this.annualButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "https://i.pinimg.com/originals/c0/15/5d/c0155d9e78e5adda2187000349d06ac2.jpg";
            this.pictureBox1.Location = new System.Drawing.Point(634, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(819, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.annualButton);
            this.Controls.Add(this.semiButton);
            this.Controls.Add(this.quarterButton);
            this.Controls.Add(this.monthlyButton);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form2";
            this.Text = "Form2";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion
        private Button monthlyButton;
        private Button quarterButton;
        private Button semiButton;
        private Button annualButton;
        private PictureBox pictureBox1;
    }
}