using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assessment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float price1;
            float price2;
            float discount;
            float total;

            if (textBox2.Text.Trim() == "")
            {
                price1 = 0;
            }
            else
            {
                price1 = float.Parse(this.textBox2.Text);
            }

            if (textBox4.Text.Trim() == "")
            {
                price2 = 0;
            }
            else
            {
                price2 = float.Parse(this.textBox4.Text);
            }


            if (textBox5.Text.Trim() == "")
            {
                discount = 0;
            }
            else
            {
                discount = float.Parse(this.textBox5.Text);
            }


            total = price1 + price2 - discount;

            textBox6.Text = total.ToString();
        }
    }
}
