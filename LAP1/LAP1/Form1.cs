using System.Globalization;

namespace LAP1
{
    public partial class Form1 : Form
    {
        double input1 = 0;
        string GG = "";
        
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string number1 = this.NUM1.Text;
            string number2 = this.NUM2.Text;

            double dnumber1 = 0.0;
            double dnumber2 = 0.0;
            //convert string to double
            dnumber1 = double.Parse(number1);
            dnumber2 = double.Parse(number2);
            // convert double to string for display
            double result =(dnumber1 + dnumber2);
            this.ANS.Text = result.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NUM1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NUM2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ANS_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string number1 = this.NUM1.Text;
            string number2 = this.NUM2.Text;

            double dnumber1 = 0.0;
            double dnumber2 = 0.0;
            //convert steing to double
            dnumber1 = double.Parse(number1);
            dnumber2 = double.Parse(number2);
            // convert double to string for display
            double result = (dnumber1 - dnumber2);
            this.ANS.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string number1 = this.NUM1.Text;
            string number2 = this.NUM2.Text;

            double dnumber1 = 0.0;
            double dnumber2 = 0.0;
            //convert steing to double
            dnumber1 = double.Parse(number1);
            dnumber2 = double.Parse(number2);
            // convert double to string for display
            double result = (dnumber1 * dnumber2);
            this.ANS.Text = result.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string number1 = this.NUM1.Text;
            string number2 = this.NUM2.Text;

            double dnumber1 = 0.0;
            double dnumber2 = 0.0;
            //convert steing to double
            dnumber1 = double.Parse(number1);
            dnumber2 = double.Parse(number2);
            // convert double to string for display
            double result = (dnumber1 / dnumber2);
            this.ANS.Text = result.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.ANS3.Text = this.ANS3.Text + "=";


            if (this.GG == "+")
                {
                    
                    double inpul2 = double.Parse(this.ANS2.Text);
                    this.ANS2.Text = (input1 + inpul2).ToString("#,###.00");
               
                }
                else if (this.GG == "-")
                {
                    double inpul2 = double.Parse(this.ANS2.Text);
                    this.ANS2.Text = (input1 - inpul2).ToString("#,###.00");
                
                }
                else if (this.GG == "*")
                {
                    double inpul2 = double.Parse(this.ANS2.Text);
                    this.ANS2.Text = (input1 * inpul2).ToString("#,###.00");
                }
                else if (this.GG == "/")
                {
                    double inpul2 = double.Parse(this.ANS2.Text);
                    this.ANS2.Text = (input1 / inpul2).ToString("#,###.00");

            }
             

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (ANS2.Text.Length > 0)
            {
                ANS2.Text = Convert.ToDouble(ANS2.Text).ToString("#,###");
                ANS2.SelectionStart = ANS2.Text.Length;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ANS2.Text = this.ANS2.Text + "1";
            this.ANS3.Text = this.ANS3.Text + "1";
            
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            this.ANS2.Text = this.ANS2.Text + "2";
            this.ANS3.Text = this.ANS3.Text + "2";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.ANS2.Text = this.ANS2.Text + "3";
            this.ANS3.Text = this.ANS3.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.ANS2.Text = this.ANS2.Text + "4";
            this.ANS3.Text = this.ANS3.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.ANS2.Text = this.ANS2.Text + "5";
            this.ANS3.Text = this.ANS3.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.ANS2.Text = this.ANS2.Text + "6";
            this.ANS3.Text = this.ANS3.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.ANS2.Text = this.ANS2.Text + "7";
            this.ANS3.Text = this.ANS3.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.ANS2.Text = this.ANS2.Text + "8";
            this.ANS3.Text = this.ANS3.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.ANS2.Text = this.ANS2.Text + "9";
            this.ANS3.Text = this.ANS3.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.ANS2.Text = this.ANS2.Text + "0";
            this.ANS3.Text = this.ANS3.Text + "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            input1 = double.Parse(this.ANS2.Text);
            GG = "+";
            this.ANS2.Text = "";
            this.ANS3.Text = this.ANS3.Text + "+";
        }

        private void button11_Click(object sender, EventArgs e)
        {
           
            this.ANS2.Text = "";
            this.ANS3.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            input1 = double.Parse(this.ANS2.Text);
            GG = "-";
            this.ANS2.Text = "";
            this.ANS3.Text = this.ANS3.Text + "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            input1 = double.Parse(this.ANS2.Text);
            GG = "*";
            this.ANS2.Text = "";
            this.ANS3.Text = this.ANS3.Text + "*";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            input1 = double.Parse(this.ANS2.Text);
            GG = "/";
            this.ANS2.Text = "";
            this.ANS3.Text = this.ANS3.Text + "/";
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
            
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            this.ANS2.Text = this.ANS2.Text + ".";
            this.ANS3.Text = this.ANS3.Text + ".";
        }
    }
}