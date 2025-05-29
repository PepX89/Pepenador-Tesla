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
    public partial class FMinitesla : Form
    {
        int count = Register.Tesla20.count;
        int count2 = Register.MiniCyber.count;
        int count3 = Register.MiniQuad.count;
        public FMinitesla()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void label2_Click(object sender, EventArgs e)
        {
            Faccesorios f1 = new Faccesorios();
            f1.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Home f2 = new Home();
=======
        private void label4_Click(object sender, EventArgs e)
        {
            TeslaShop shop = new TeslaShop();
            shop.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string A20 = "Tesla 20th Anniversary";
            Register.Tesla20.T20 = A20;
            count++;
            Register.Tesla20.count = count;
            MessageBox.Show("Articulo añadido al carrito!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string A20 = "Cybertruck for kids";
            Register.MiniCyber.minicyber = A20;
            count2++;
            Register.MiniCyber.count = count2;
            MessageBox.Show("Articulo añadido al carrito!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string A20 = "Cyberquad for kids";
            Register.MiniQuad.miniquad = A20;
            count3++;
            Register.MiniQuad.count = count3;
            MessageBox.Show("Articulo añadido al carrito!");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Faccesorios f2 = new Faccesorios();
            f2.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Faccesorios f2 = new Faccesorios();
>>>>>>> 13.24
            f2.Show();
            this.Hide();
        }

<<<<<<< HEAD
        private void label1_Click(object sender, EventArgs e)
        {
            Fcarga f1 = new Fcarga();
            f1.Show();
            this.Hide();
        }
=======
        private void label3_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Hide();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tesla.com/");
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tesla.com/");
        }
>>>>>>> 13.24
    }
}
