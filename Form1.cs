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

        private void button1_Click(object sender, EventArgs e)
        {
            group1 g1 = new group1();
            g1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            group2 g2 = new group2();
            g2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            group3 g3 = new group3();
            g3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            group4 g4 = new group4();
            g4.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            group5 g5 = new group5();
            g5.Show();
            this.Hide();
        }
    }
}
