using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tesla
{
    public partial class Fcarga : Form
    {
        public Fcarga()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Fcargadores f1 = new Fcargadores();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fcargadores f1 = new Fcargadores();
            f1.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Faccesorios f2 = new Faccesorios();
            f2.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Home f3 = new Home();
            f3.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
