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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            group1 g1 = new group1();
            g1.allsal1.Text = allsal.Text;
            g1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sal = int.Parse(salary.Text);
            int bos = int.Parse(bonus.Text);
            int oth = int.Parse(other.Text);
            int outcome;

            outcome = (sal * 12) + bos + oth;
            allsal.Text = outcome.ToString();
        }
    }
}
