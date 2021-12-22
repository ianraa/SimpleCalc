using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        bool m = false;
        double mem;
        char op;

        public Form1()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            op = '-';
            m = true;
            mem = double.Parse(textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            if (int.Parse(textBox1.Text) < 0) this.BackColor = Color.Red;
            else this.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (m == true || textBox1.Text == "0") textBox1.Text = "7";
            else textBox1.Text += "7";
            m = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (m == true || textBox1.Text == "0") textBox1.Text = "8";
            else textBox1.Text += "8";
            m = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (m == true || textBox1.Text == "0") textBox1.Text = "9";
            else textBox1.Text += "9";
            m = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (m == true || textBox1.Text == "0") textBox1.Text = "4";
            else textBox1.Text += "4";
            m = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (m == true || textBox1.Text == "0") textBox1.Text = "5";
            else textBox1.Text += "5";
            m = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (m == true || textBox1.Text == "0") textBox1.Text = "6";
            else textBox1.Text += "6";
            m = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (m == true || textBox1.Text == "0") textBox1.Text = "1";
            else textBox1.Text += "1";
            m = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (m == true || textBox1.Text == "0") textBox1.Text = "2";
            else textBox1.Text += "2";
            m = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (m == true || textBox1.Text == "0") textBox1.Text = "3";
            else textBox1.Text += "3";
            m = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (m == true || textBox1.Text == "0") textBox1.Text = "0";
            else textBox1.Text += "0";
            m = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
            m = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            m = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            op = '+';
            m = true;
            mem = double.Parse(textBox1.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            op = 'X';
            m = true;
            mem = double.Parse(textBox1.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            op = ':';
            m = true;
            mem = double.Parse(textBox1.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {

            try
            {
                double akt = double.Parse(textBox1.Text);
                if (op == '+')
                {
                    double zb = mem + akt;
                    textBox1.Text = zb.ToString();
                    if (int.Parse(zb.ToString()) < 0)
                    {
                        this.BackColor = Color.Red;
                    }
                    else if (int.Parse(zb.ToString()) >= 0)
                    {
                        this.BackColor = Color.White;
                    }

                }
                else if (op == '-')
                {
                    double r = mem - akt;
                    textBox1.Text = r.ToString();
                    if (int.Parse(r.ToString()) < 0)
                    {
                        this.BackColor = Color.Red;
                    }
                    else if (int.Parse(r.ToString()) >= 0)
                    {
                        this.BackColor = Color.White;
                    }


                }
                else if (op == ':')
                {
                    double k = mem / akt;
                    textBox1.Text = k.ToString();
                    if (int.Parse(k.ToString()) < 0)
                    {
                        this.BackColor = Color.Red;
                    }
                    else if (int.Parse(k.ToString()) >= 0)
                    {
                        this.BackColor = Color.White;
                    }
                }
                else if (op == 'X')
                {
                    double pr = mem * akt;
                    textBox1.Text = pr.ToString();
                    if (int.Parse(pr.ToString()) < 0)
                    {
                        this.BackColor = Color.Red;
                    }
                    else if (int.Parse(pr.ToString()) >= 0)
                    {
                        this.BackColor = Color.White;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
           
            
        }
    }
}
