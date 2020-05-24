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
            f1.allsal.Text = allsal1.Text;
            f1.Show();
            this.Hide();
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
            kunson.Enabled = true;
            numson.Enabled = true;
            numson2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int asl = int.Parse(allsal1.Text);
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

        private void button2_Click(object sender, EventArgs e)
        {
            group2 g2 = new group2();
            g2.allsal.Text = suti.Text;
            g2.Show();
            this.Hide();
        }

        private void group1_Load(object sender, EventArgs e)
        {
            kunson.Enabled = false;
            numpikan.Enabled = false;
            numson.Enabled = false;
            numson2.Enabled = false;
        }

        private void mhav_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
