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
    public partial class group2 : Form
    {
        public group2()
        {
            InitializeComponent();
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (ddie.Checked)
            {
                dmbox.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            group1 f1 = new group1();
            f1.suti.Text = allsal.Text;
            f1.Show();
            this.Hide();
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (single.Checked)
            {
                marrybox.Enabled = false;
            }
        }

        private void marry_CheckedChanged(object sender, EventArgs e)
        {
            if (marry.Checked)
            {
                marrybox.Enabled = true;
            }
        }

        private void dmlife_CheckedChanged(object sender, EventArgs e)
        {
            if (dmlife.Checked)
            {
                dmbox.Enabled = true;
            }
        }

        private void mdie_CheckedChanged(object sender, EventArgs e)
        {
            if (mdie.Checked)
            {
                dmbox.Enabled = true;
            }
        }

        private void dmdie_CheckedChanged(object sender, EventArgs e)
        {
            if (dmdie.Checked)
            {
                dmbox.Enabled = false;
            }
        }

        private void husoc_CheckedChanged(object sender, EventArgs e)
        {
            if (husoc.Checked)
            {
                numsoc.Enabled = true;
            }
        }

        private void nohusoc_CheckedChanged(object sender, EventArgs e)
        {
            if (nohusoc.Checked)
            {
                numsoc.Enabled = false;
            }
        }

        private void married_CheckedChanged(object sender, EventArgs e)
        {
            if (married.Checked)
            {
                nummar.Enabled = true;
            }
        }

        private void nomarried_CheckedChanged(object sender, EventArgs e)
        {
            if (nomarried.Checked)
            {
                nummar.Enabled = false;
            }
        }

        private void life_CheckedChanged(object sender, EventArgs e)
        {
            if (life.Checked)
            {
                numlife.Enabled = true;
            }
        }

        private void nolife_CheckedChanged(object sender, EventArgs e)
        {
            if (nolife.Checked)
            {
                numlife.Enabled = false;
            }
        }

        private void hedm_CheckedChanged(object sender, EventArgs e)
        {
            if (hedm.Checked)
            {
                numdm.Enabled = true;
            }
        }

        private void nohedm_CheckedChanged(object sender, EventArgs e)
        {
            if (nohedm.Checked)
            {
                numdm.Enabled = false;
            }
        }

        private void health_CheckedChanged(object sender, EventArgs e)
        {
            if (health.Checked)
            {
                numhealth.Enabled = true;
            }
        }

        private void nohealth_CheckedChanged(object sender, EventArgs e)
        {
            if (nohealth.Checked)
            {
                numhealth.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int all = int.Parse(allsal.Text);
            int soc = int.Parse(numsoc.Text);
            int het = int.Parse(numhealth.Text);
            int mar = int.Parse(nummar.Text);
            int lif = int.Parse(numlife.Text);
            int dm = int.Parse(numdm.Text);
            int outcome1;
            int outcome2;

            outcome1 = soc + het + mar + lif + dm;
            alltax.Text = outcome1.ToString();

            outcome2 = all - outcome1;
            suti.Text = outcome2.ToString();
        }

        private void group2_Load(object sender, EventArgs e)
        {
            numsoc.Enabled = false;
            nummar.Enabled = false;
            numlife.Enabled = false;
            numdm.Enabled = false;
            numhealth.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            group3 g3 = new group3();
            g3.allsal.Text = suti.Text;
            g3.Show();
            this.Hide();
        }
    }
}
