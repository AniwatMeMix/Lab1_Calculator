namespace LAB1_Calculator1
{
    public partial class Form1 : Form
    {
        double input1 = 0.00;
        double input2 = 0.00;
        string GG = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "1";
            if (this.textBox1.Text.Length % 4 == 0)
            {
                this.textBox1.Text = string.Format("{0:0,0.00}", this.textBox1.Text);
            }
            double.Parse(this.textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "2";
            if (this.textBox1.Text.Length % 4 == 0)
            {
                this.textBox1.Text = string.Format("{0:0,0.00}", this.textBox1.Text);
            }
            double.Parse(this.textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "3";
            if (this.textBox1.Text.Length % 4 == 0)
            {
                this.textBox1.Text = string.Format("{0:0,0.00}", this.textBox1.Text);
            }
            double.Parse(this.textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "4";
            if (this.textBox1.Text.Length % 4 == 0)
            {
                this.textBox1.Text = string.Format("{0:0,0.00}", this.textBox1.Text);
            }
            double.Parse(this.textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "5";
            if (this.textBox1.Text.Length % 4 == 0)
            {
                this.textBox1.Text = string.Format("{0:0,0.00}", this.textBox1.Text);
            }
            double.Parse(this.textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "6";
            if (this.textBox1.Text.Length % 4 == 0)
            {
                this.textBox1.Text = string.Format("{0:0,0.00}", this.textBox1.Text);
            }
            double.Parse(this.textBox1.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "7";
            if (this.textBox1.Text.Length % 4 == 0)
            {
                this.textBox1.Text = string.Format("{0:0,0.00}", this.textBox1.Text);
            }
            double.Parse(this.textBox1.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "8";
            if (this.textBox1.Text.Length % 4 == 0)
            {
                this.textBox1.Text = string.Format("{0:0,0.00}", this.textBox1.Text);
            }
            double.Parse(this.textBox1.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "9";
            if (this.textBox1.Text.Length % 4 == 0)
            {
                this.textBox1.Text = string.Format("{0:0,0.00}", this.textBox1.Text);
            }
            double.Parse(this.textBox1.Text);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "0";
            if (this.textBox1.Text.Length % 4 == 0)
            {
                this.textBox1.Text = string.Format("{0:0,0.00}", this.textBox1.Text);
            }
            double.Parse(this.textBox1.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + ".";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (this.GG == "+")
            {
                this.input2 = double.Parse(this.textBox1.Text);
                this.textBox1.Text = string.Format("{0:0,0.00}", input1 + input2);
            }
            else if (this.GG == "-")
            {
                this.input2 = double.Parse(this.textBox1.Text);
                this.textBox1.Text = string.Format("{0:0,0.00}", input1 - input2);
            }
            else if (this.GG == "*")
            {
                this.input2 = double.Parse(this.textBox1.Text);
                this.textBox1.Text = string.Format("{0:0,0.00}", input1 * input2);
            }
            else if (this.GG == "/")
            {
                this.input2 = double.Parse(this.textBox1.Text);
                this.textBox1.Text = string.Format("{0:0,0.00}", input1 / input2);
            }
            this.textBox2.Text = this.textBox2.Text + string.Format("{0:0,0.00}", input2) + "=";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.input1 = double.Parse(this.textBox1.Text);
            this.GG = "+";
            this.textBox2.Text = string.Format("{0:0,0.00}", input1) + "+";
            this.textBox1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.input1 = double.Parse(this.textBox1.Text);
            this.GG = "-";
            this.textBox2.Text = string.Format("{0:0,0.00}", input1) + "-";
            this.textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.input1 = double.Parse(this.textBox1.Text);
            this.GG = "*";
            this.textBox2.Text = string.Format("{0:0,0.00}", input1) + "x";
            this.textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.input1 = double.Parse(this.textBox1.Text);
            this.GG = "/";
            this.textBox2.Text = string.Format("{0:0,0.00}", input1) + "÷";
            this.textBox1.Text = "";
        }
    }
}