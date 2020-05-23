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

        private void group4_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
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
    }
}
