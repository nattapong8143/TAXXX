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
  
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            box58.Enabled = true;
            box62.Enabled = false;
            int a, b;
            
            a = 0;
            ban62.Text = a.ToString();
            b = 0;
            numban62.Text = b.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            box62.Enabled = true;
            box58.Enabled = false;
            int a, b, c;

            a = 0;
            ban58.Text = a.ToString();
            b = 0;
            yiban.Text = b.ToString();
            c = 0;
            siban.Text = c.ToString();
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
            group2 g2 = new group2();
            g2.suti.Text = allsal.Text;
            g2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            group4 g4 = new group4();
            g4.allsal.Text = suti.Text;
            g4.Show();
            this.Hide();
        }
    }
}
