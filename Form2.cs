using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Pizza_Order
{
    public partial class Form2 : Form
    {
        public Double TotalPrice = 0;
        public Form2()
        {
          
        InitializeComponent();
        }

        private void grSize_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void grSize_Enter_1(object sender, EventArgs e)
        {
           
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSmall.Checked)
            {
                label1.Text = rbSmall.Text;
                TotalPrice = 10;
                label4.Text = TotalPrice.ToString() + "$";
            }
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMedium.Checked)
            {
                label1.Text = rbMedium.Text;
                TotalPrice = 15;
                label4.Text = TotalPrice.ToString() + "$";

            }
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLarge.Checked)
            {
                label1.Text = rbLarge.Text;
                TotalPrice = 25;
                label4.Text = TotalPrice.ToString() + "$";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = TotalPrice.ToString()+"$";
        }

        private void chExtra_CheckedChanged(object sender, EventArgs e)
        {
            if (chExtra.Checked) {
                label3.Text += chExtra.Text + ",";
                TotalPrice += 5;
                label4.Text = TotalPrice.ToString() + "$";

            }
            else
            {
                label3.Text= label3.Text.Replace(chExtra.Text+",",""); ;
                TotalPrice -= 5;
                label4.Text = TotalPrice.ToString() + "$";
            }
        }

        private void chOlives_CheckedChanged(object sender, EventArgs e)
        {
            if (chOlives.Checked)
            {
                label3.Text += chOlives.Text + ",";
                TotalPrice += 5;
                label4.Text = TotalPrice.ToString() + "$";

            }
            else
            {
                label3.Text= label3.Text.Replace(chOlives.Text+",", ""); ;
                TotalPrice -= 5;
                label4.Text = TotalPrice.ToString() + "$";
            }
        }
    }
}
