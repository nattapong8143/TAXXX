using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Tax
{
    public partial class group3 : Form
    {
        public group3()
        {
            InitializeComponent();
        }
        private void sum_Click(object sender, EventArgs e)
        {
            int sal = int.Parse(salary.Text);
            int bos = int.Parse(bonus.Text);
            int oth = int.Parse(other.Text);
            int outcome;

            outcome = (sal * 12) + bos + oth;
            allsal.Text = outcome.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            box58.Enabled = true;
            box62.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            box62.Enabled = true;
            box58.Enabled = false;
        }

        private void group3_Load(object sender, EventArgs e)
        {
            box62.Enabled = false;
            box58.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int b = int.Parse(ban58.Text);
            int outcome1;

            outcome1 = (b * 20) / 100;
            yiban.Text = outcome1.ToString();

            int outcome2 = int.Parse(yiban.Text);
            int outcome3;

            outcome3 = (outcome2 * 4) / 100;
            siban.Text = outcome3.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int asl = int.Parse(allsal.Text);
            int tb = int.Parse(taxban.Text);
            int outcome1;
            int outcome2;

            if (radioButton1.Checked)
            {
                int s58 = int.Parse(siban.Text);
                outcome1 = tb + s58;
                alltax.Text = outcome1.ToString();
            }
            if (radioButton2.Checked)
            {
                int n62 = int.Parse(numban62.Text);
                outcome1 = tb + n62;
                alltax.Text = outcome1.ToString();
            }

            int ot1 = int.Parse(alltax.Text);
            outcome2 = asl - ot1;
            suti.Text = outcome2.ToString();

            int a = int.Parse(suti.Text);
            if (a > 5000000)
            {
                a = (a * 35 / 100);
            }
            else if (a > 2000000)
            {
                a = (a * 30 / 100);
            }
            else if (a > 1000000)
            {
                a = (a * 25 / 100);
            }
            else if (a > 750000)
            {
                a = (a * 20 / 100);
            }
            else if (a > 500000)
            {
                a = (a * 15 / 100);
            }
            else if (a > 300000)
            {
                a = (a * 10 / 100);
            }
            else if (a > 150000)
            {
                a = (a * 5 / 100);
            }
            else
            {
                a = (0);
            }

            allpay.Text = a.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int h62 = int.Parse(ban62.Text);
            int h622 = 0;
            if (h62 <= 5000000)
            {
                h622 = 200000;
                numban62.Text = h622.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
