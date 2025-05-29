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
    public partial class FTermos : Form
    {
        int count = Register.CyberMug.count;
        int count2 = Register.Vesse.count;
        int count3 = Register.Road.count;

        public FTermos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Faccesorios f1 = new Faccesorios();
            f1.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Faccesorios f2 = new Faccesorios();
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
        private void label4_Click(object sender, EventArgs e)
        {
            TeslaShop shop = new TeslaShop();
            shop.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String termo1 = "CyberMug Taza";
            Register.CyberMug.Cybermug = termo1;
            count++;
            Register.CyberMug.count = count;
            MessageBox.Show("Articulo añadido al carrito!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String termo2 = "On the Road Vessel P2M";
            Register.Road.road = termo2;
            count3++;
            Register.Road.count = count3;
            MessageBox.Show("Articulo añadido al carrito!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String termo3 = "CyberVessel Termo";
            Register.Vesse.vesse = termo3;
            count2++;
            Register.Vesse.count = count2;
            MessageBox.Show("Articulo añadido al carrito!");
        }

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
