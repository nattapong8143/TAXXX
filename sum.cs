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
    public partial class sum : Form
    {
        public sum()
        {
            InitializeComponent();
        }

        private void sum_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(all.Text);
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

            summer.Text = a.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
