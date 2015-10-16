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

            if (txtPdtCost1.Text.Trim() == "")
            {
                price1 = 0;
            }
            else
            {
                price1 = float.Parse(this.txtPdtCost1.Text);
            }

            if (txtPdtCost2.Text.Trim() == "")
            {
                price2 = 0;
            }
            else
            {
                price2 = float.Parse(this.txtPdtCost2.Text);
            }

            
            if (txtDiscountAmt.Text.Trim() == "")
            {
                discount = 0;
            }
            else
            {
                discount = float.Parse(this.txtDiscountAmt.Text) / 100;
            }

            if (String.Equals(txtPdtCode1.Text,txtPdtCode2.Text))
            {
                price2 = (float.Parse(this.txtPdtCost2.Text)) - ((float.Parse(this.txtPdtCost2.Text)) * discount);
            }

            total = price1 + price2;
            

            txtTotal.Text = total.ToString();
        }
    }
}
