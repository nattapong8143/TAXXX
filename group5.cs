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
    public partial class group5 : Form
    {
        public group5()
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int hp = int.Parse(help.Text);
            int ed = int.Parse(edu.Text);
            int bk = int.Parse(book.Text);
            int ot = int.Parse(otop.Text);
            int ct = int.Parse(city.Text);
            int lg = int.Parse(longty.Text);
            int hb = int.Parse(homebuk.Text);
            int cb = int.Parse(carbuk.Text);
            int hs = int.Parse(homesop.Text);
            int cs = int.Parse(carsop.Text);
            int all = int.Parse(allsal.Text);
            int tt = 0;
            int tt2 = 0;
            int out1;
            int out2;

            tt = ct + lg;
            if(tt > 20000)
            {
                tt2 = 20000;
            }
            else if(tt < 2000)
            {
                tt2 = ct + lg;
            }

            out1 = hp + ed + bk + ot + tt2 + hb + cb + hs + cs;
            alltax.Text = out1.ToString();

            out2 = all - out1;
            suti.Text = out2.ToString();

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
