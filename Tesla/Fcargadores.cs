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
    public partial class Fcargadores : Form
    {
        public Fcargadores()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Fcarga f1 = new Fcarga();
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

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
