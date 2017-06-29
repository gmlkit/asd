using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        string vnos = string.Empty;
        string postopek1 = string.Empty;
        string postopek2 = string.Empty;

        char operation;
            double rezultat = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void ena_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            vnos += "1";
            this.textBox1.Text += vnos;
        }

        private void dva_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            vnos += "2";
            this.textBox1.Text += vnos;
        }

        private void tri_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            vnos += "3";
            this.textBox1.Text += vnos;
        }

        private void nula_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            vnos += "0";
            this.textBox1.Text += vnos;
        }

        private void stiri_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            vnos += "4";
            this.textBox1.Text += vnos;
        }

        private void pet_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            vnos += "5";
            this.textBox1.Text += vnos;
        }
        

        private void sest_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            vnos += "6";
            this.textBox1.Text += vnos;
        }

        private void sedem_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            vnos += "7";
            this.textBox1.Text += vnos;
        }

        private void osem_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            vnos += "8";
            this.textBox1.Text += vnos;
        }

        private void devet_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            vnos += "9";
            this.textBox1.Text += vnos;
        }



        private void minus_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            postopek1 = vnos;
            operation = '-';
            vnos = string.Empty;
            this.textBox1.Text += vnos;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            postopek1 = vnos ;
            operation = '+';
            vnos  = string.Empty;
            this.textBox1.Text += vnos ;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.vnos  = string.Empty;
            this.postopek1= string.Empty;
            this.postopek2= string.Empty;

        }

        private void deljeno_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            postopek1= vnos ;
            operation = '/';
            vnos = string.Empty;
            this.textBox1.Text += vnos ;
        }

        private void krat_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            postopek1= vnos;
            operation = '*';
            vnos  = string.Empty;
            this.textBox1.Text += vnos ;
        }
        private void dec_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            vnos += ".";
            this.textBox1.Text += vnos ;
        }
        private void enako_Click(object sender, EventArgs e)
        {

            postopek2 = vnos;
            double st1, st2;
            double.TryParse(postopek1, out st1);
            double.TryParse(postopek2, out st2);
            this.textBox1.Text = "";
            this.vnos = string.Empty;
            this.postopek1 = string.Empty;
            this.postopek2 = string.Empty;
            if (operation == '+')
            {
                rezultat = st1 + st2;
                textBox1.Text = rezultat.ToString();
            }
            else if (operation == '-')
            {
                rezultat = st1 - st2;
                textBox1.Text = rezultat.ToString();
            }
            else if (operation == '*')
            {
                rezultat = st1 * st2;
                textBox1.Text = rezultat.ToString();
            }
            else if (operation == '/')
            {
                if (st2 != 0)
                {
                    rezultat = st1 / st2;
                    textBox1.Text = rezultat.ToString();
                }
                else
                {
                    textBox1.Text = "DIV/Zero!";
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
