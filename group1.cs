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
    public partial class group1 : Form
    {
        public group1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click_1(object sender, EventArgs e)
        {

        }

        private void group1_Load(object sender, EventArgs e)
        {

        }

        private void sun_Click(object sender, EventArgs e)
        {
            int sal = int.Parse(salary.Text);
            int bos = int.Parse(bonus.Text);
            int oth = int.Parse(other.Text);
            int all;

            all = (sal * 12) + bos + oth;
            allsal.Text = all.ToString();

        }

        private void single_CheckedChanged(object sender, EventArgs e)
        {
            if (single.Checked)
            {
                marrybox.Enabled = false;
                dad2.Enabled = false;
                mom2.Enabled = false;
                //boxson.Enabled = false;
                //kunbox.Enabled = false;
                //boxnumson.Enabled = false;
            }
        }

        private void marry_CheckedChanged(object sender, EventArgs e)
        {
            marrybox.Enabled = true;
            dad2.Enabled = true;
            mom2.Enabled = true;
            //boxson.Enabled = true;
            //kunbox.Enabled = true;
            //boxnumson.Enabled = true;
        }

        private void nots_CheckedChanged(object sender, EventArgs e)
        {
            kunbox.Enabled = false;
            boxnumson.Enabled = false;
        }

        private void son_CheckedChanged(object sender, EventArgs e)
        {
            kunbox.Enabled = true;
            boxnumson.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int asl = int.Parse(allsal.Text);
            int ks = int.Parse(kunson.Text);
            int bb1 = int.Parse(numson.Text);
            int bb2 = int.Parse(numson2.Text);
            int pk = int.Parse(numpikan.Text);
            int d1 = 0;
            int d2 = 0;
            int m1 = 0;
            int m2 = 0;
            int mar = 0;
            int bb3 = 0;
            int outcome1;
            int outcome2;

            if (mnot.Checked)
            {
                mar = 60000;
            }
            if (dad.Checked)
            {
                d1 = 30000;
            }
            if (dad2.Checked)
            {
                d2 = 30000;
            }
            if (mom.Checked)
            {
                m1 = 30000;
            }
            if (mom2.Checked)
            {
                m2 = 30000;
            }

            outcome1 = 60000 + mar + d1 + d2 + m1 + m2 + ks + (bb1 * 30000) + (bb2 * 60000) + (pk * 60000);
            alltax.Text = outcome1.ToString();

            outcome2 = asl - outcome1;
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

        private void notpk_CheckedChanged(object sender, EventArgs e)
        {
            if (notpk.Checked)
            {
                numpikan.Enabled = false;
            }
        }

        private void pikan_CheckedChanged(object sender, EventArgs e)
        {
            if(pikan.Checked)
            {
                numpikan.Enabled = true;
            }
        }

        private void mhav_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mnot_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
