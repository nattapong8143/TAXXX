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
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            group4 f1 = new group4();
            f1.suti.Text = allsal.Text;
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
            else if(tt < 20000)
            {
                tt2 = ct + lg;
            }

            out1 = hp + ed + bk + ot + tt2 + hb + cb + hs + cs;
            alltax.Text = out1.ToString();

            out2 = all - out1;
            suti.Text = out2.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sum sm = new sum();
            sm.all.Text = suti.Text;
            sm.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            city ct = new city();
            ct.Show();
        }
    }
}
