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
    public partial class FMochilas : Form
    {
        public FMochilas()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Faccesorios f1 = new Faccesorios();
            f1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Fcarga f2 = new Fcarga();
            f2.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Home f3 = new Home();
            f3.Show();
            this.Hide();
        }
    }
}
