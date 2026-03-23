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
            label3.Text = "";

            label4.ForeColor = Color.Green;
            label4.Font = new Font(label4.Font.FontFamily, 16, FontStyle.Bold);
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

        private void chTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            if (chTomatoes.Checked)
            {
                label8.Text += chTomatoes.Text + ",";
                TotalPrice += 5;
                label4.Text = TotalPrice.ToString() + "$";

            }
            else
            {
                label8.Text = label8.Text.Replace(chTomatoes.Text + ",", ""); ;
                TotalPrice -= 5;
                label4.Text = TotalPrice.ToString() + "$";
            }
        }

        private void chOnion_CheckedChanged(object sender, EventArgs e)
        {

            if (chOnion.Checked)
            {
                label8.Text += chOnion.Text ;
                TotalPrice += 5;
                label4.Text = TotalPrice.ToString() + "$";

            }
            else
            {
                label8.Text = label3.Text.Replace(chOnion.Text , ""); ;
                TotalPrice -= 5;
                label4.Text = TotalPrice.ToString() + "$";
            }
        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThin.Checked)
            {
                label5.Text = rbThin.Text ;
                TotalPrice += 10;
                label4.Text = TotalPrice.ToString() + "$";

            }
            else
            {
                label5.Text = label5.Text.Replace(rbThin.Text, ""); ;
                TotalPrice -= 10;
                label4.Text = TotalPrice.ToString() + "$";
            }
        }

        private void rbThik_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThik.Checked)
            {
                label5.Text = rbThik.Text;
                TotalPrice += 20;
                label4.Text = TotalPrice.ToString() + "$";

            }
            else
            {
                label5.Text = label5.Text.Replace(rbThik.Text, ""); ;
                TotalPrice -= 20;
                label4.Text = TotalPrice.ToString() + "$";
            }
        }

        private void grSummary_Enter(object sender, EventArgs e)
        {

        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEatIn.Checked)
            {
                label7.Text = rbEatIn.Text;
              

            }
            else
            {
                label7.Text = rbEatIn.Text.Replace(rbThik.Text, ""); ;
               
            }
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTakeOut.Checked)
            {
                label7.Text = rbTakeOut.Text;


            }
            else
            {
                label7.Text = rbTakeOut.Text.Replace(rbThik.Text, ""); ;

            }
        }

        private void btOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                MessageBox.Show("good");
                grSize.Enabled = false;
                grToppings.Enabled = false;
                grCrust.Enabled = false;
                grWhere.Enabled = false;
                btOrder.Enabled = false;
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            grSize.Enabled = true;
            grToppings.Enabled = true;
            grCrust.Enabled = true;
            grWhere.Enabled = true;
            btOrder.Enabled = true;
           
            this.Hide();
            Form2 f = new Form2();
            f.Show();
       

        }
    }
}
