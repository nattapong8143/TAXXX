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
    public partial class group4 : Form
    {
        public group4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            group3 f1 = new group3();
            f1.suti.Text = allsal.Text;
            f1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ed = int.Parse(ed1.Text);
            int hp = int.Parse(hp1.Text);
            int sp = int.Parse(sp1.Text);
            int st = int.Parse(st1.Text);
            int pb = int.Parse(st1.Text);
            int l = int.Parse(l1.Text);
            int k = int.Parse(k1.Text);
            int all = int.Parse(allsal.Text);
            int outcome1;
            int outcome2;
            int outcome3;
            int i = 0;

            outcome2 = (all * 10) / 100;

            outcome1 = (ed * 2) + (hp * 2) + (sp * 2) + (st * 2) + pb + l + k;
            if (outcome1 > outcome2)
            {
                i = outcome2;
            }
            else if (outcome1 < outcome2)
            {
                i = outcome1;
            }
            alltax.Text = i.ToString();

            outcome3 = all - i;
            suti.Text = outcome3.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            group5 g5 = new group5();
            g5.allsal.Text = suti.Text;
            g5.Show();
            this.Hide();
        }
    }
}
