namespace LAP1
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
            this.NUM1 = new System.Windows.Forms.TextBox();
            this.SUM = new System.Windows.Forms.Button();
            this.NUM2 = new System.Windows.Forms.TextBox();
            this.ANS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.D = new System.Windows.Forms.Button();
            this.Dx2 = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ANS2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.ANS3 = new System.Windows.Forms.TextBox();
            this.button17 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NUM1
            // 
            this.NUM1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.NUM1.Location = new System.Drawing.Point(6, 12);
            this.NUM1.Name = "NUM1";
            this.NUM1.Size = new System.Drawing.Size(125, 27);
            this.NUM1.TabIndex = 3;
            this.NUM1.TextChanged += new System.EventHandler(this.NUM1_TextChanged);
            // 
            // SUM
            // 
            this.SUM.BackColor = System.Drawing.SystemColors.Info;
            this.SUM.Location = new System.Drawing.Point(6, 45);
            this.SUM.Name = "SUM";
            this.SUM.Size = new System.Drawing.Size(96, 45);
            this.SUM.TabIndex = 2;
            this.SUM.Text = "บวก";
            this.SUM.UseVisualStyleBackColor = false;
            this.SUM.Click += new System.EventHandler(this.button2_Click);
            // 
            // NUM2
            // 
            this.NUM2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.NUM2.Location = new System.Drawing.Point(162, 12);
            this.NUM2.Name = "NUM2";
            this.NUM2.Size = new System.Drawing.Size(125, 27);
            this.NUM2.TabIndex = 5;
            this.NUM2.TextChanged += new System.EventHandler(this.NUM2_TextChanged);
            // 
            // ANS
            // 
            this.ANS.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ANS.Location = new System.Drawing.Point(318, 12);
            this.ANS.Name = "ANS";
            this.ANS.Size = new System.Drawing.Size(125, 27);
            this.ANS.TabIndex = 7;
            this.ANS.TextChanged += new System.EventHandler(this.ANS_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 8;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "=";
            // 
            // D
            // 
            this.D.BackColor = System.Drawing.SystemColors.Info;
            this.D.Location = new System.Drawing.Point(210, 45);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(96, 45);
            this.D.TabIndex = 10;
            this.D.Text = "ลบ";
            this.D.UseVisualStyleBackColor = false;
            this.D.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Dx2
            // 
            this.Dx2.BackColor = System.Drawing.SystemColors.Info;
            this.Dx2.Location = new System.Drawing.Point(312, 45);
            this.Dx2.Name = "Dx2";
            this.Dx2.Size = new System.Drawing.Size(96, 45);
            this.Dx2.TabIndex = 11;
            this.Dx2.Text = "หาร";
            this.Dx2.UseVisualStyleBackColor = false;
            this.Dx2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // X
            // 
            this.X.BackColor = System.Drawing.SystemColors.Info;
            this.X.Location = new System.Drawing.Point(108, 45);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(96, 45);
            this.X.TabIndex = 12;
            this.X.Text = "คูณ";
            this.X.UseVisualStyleBackColor = false;
            this.X.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "+";
            // 
            // ANS2
            // 
            this.ANS2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ANS2.Location = new System.Drawing.Point(483, 76);
            this.ANS2.Name = "ANS2";
            this.ANS2.Size = new System.Drawing.Size(292, 27);
            this.ANS2.TabIndex = 14;
            this.ANS2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ANS2.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(483, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 58);
            this.button1.TabIndex = 15;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(556, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 58);
            this.button2.TabIndex = 16;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.Location = new System.Drawing.Point(629, 109);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 58);
            this.button3.TabIndex = 17;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Info;
            this.button4.Location = new System.Drawing.Point(483, 173);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 58);
            this.button4.TabIndex = 18;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Info;
            this.button5.Location = new System.Drawing.Point(556, 173);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 58);
            this.button5.TabIndex = 19;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Info;
            this.button6.Location = new System.Drawing.Point(629, 173);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(67, 58);
            this.button6.TabIndex = 20;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Info;
            this.button7.Location = new System.Drawing.Point(483, 237);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(67, 58);
            this.button7.TabIndex = 21;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Info;
            this.button8.Location = new System.Drawing.Point(556, 237);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(67, 58);
            this.button8.TabIndex = 22;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.Info;
            this.button9.Location = new System.Drawing.Point(629, 237);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(67, 58);
            this.button9.TabIndex = 23;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.Info;
            this.button10.Location = new System.Drawing.Point(556, 301);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(67, 58);
            this.button10.TabIndex = 24;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.Info;
            this.button11.Location = new System.Drawing.Point(483, 301);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(67, 58);
            this.button11.TabIndex = 25;
            this.button11.Text = "C";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.Info;
            this.button12.Location = new System.Drawing.Point(702, 109);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(67, 58);
            this.button12.TabIndex = 26;
            this.button12.Text = "+";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.Info;
            this.button13.Location = new System.Drawing.Point(702, 173);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(67, 58);
            this.button13.TabIndex = 27;
            this.button13.Text = "-";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.Info;
            this.button14.Location = new System.Drawing.Point(702, 237);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(67, 58);
            this.button14.TabIndex = 28;
            this.button14.Text = "*";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.Info;
            this.button15.Location = new System.Drawing.Point(702, 301);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(67, 58);
            this.button15.TabIndex = 29;
            this.button15.Text = "/";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.Info;
            this.button16.Location = new System.Drawing.Point(483, 363);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(286, 58);
            this.button16.TabIndex = 30;
            this.button16.Text = "=";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // ANS3
            // 
            this.ANS3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ANS3.Location = new System.Drawing.Point(635, 45);
            this.ANS3.Name = "ANS3";
            this.ANS3.Size = new System.Drawing.Size(140, 27);
            this.ANS3.TabIndex = 31;
            this.ANS3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ANS3.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.Info;
            this.button17.Location = new System.Drawing.Point(629, 301);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(67, 58);
            this.button17.TabIndex = 32;
            this.button17.Text = ".";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.ANS3);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ANS2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.X);
            this.Controls.Add(this.Dx2);
            this.Controls.Add(this.D);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ANS);
            this.Controls.Add(this.NUM2);
            this.Controls.Add(this.NUM1);
            this.Controls.Add(this.SUM);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox NUM1;
        private Button SUM;
        private TextBox NUM2;
        private TextBox ANS;
        private Label label1;
        private Label label2;
        private Button D;
        private Button Dx2;
        private Button X;
        private Label label3;
        private TextBox ANS2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private TextBox ANS3;
        private Button button17;
    }
}