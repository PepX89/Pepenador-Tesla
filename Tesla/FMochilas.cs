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
        int count = Register.MiniPack.count;
        int count2 = Register.ElevatePack.count;
        int count3 = Register.MegaPack.count;
        public FMochilas()
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

        private void label1_Click(object sender, EventArgs e)
        {
            Fcarga f2 = new Fcarga();
=======
        private void label4_Click(object sender, EventArgs e)
        {
            TeslaShop shop = new TeslaShop();
            shop.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string m1 = "Mini Pack, Backpack";
            Register.MiniPack.minipack = m1;
            count++;
            Register.MiniPack.count = count;
            MessageBox.Show("Articulo añadido al carrito!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string m2 = "Elevate Pack, Backpack";
            Register.ElevatePack.Elevatepack = m2;
            count2++;
            Register.ElevatePack.count = count2;
            MessageBox.Show("Articulo añadido al carrito!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string m3 = "Mega Pack, Backpack";
            Register.MegaPack.Megapack = m3;
            count3++;
            Register.MegaPack.count = count3;
            MessageBox.Show("Articulo añadido al carrito!");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Faccesorios f2 = new Faccesorios();
>>>>>>> 13.24
            f2.Show();
            this.Hide();
        }

<<<<<<< HEAD
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Home f3 = new Home();
            f3.Show();
            this.Hide();
        }
=======
        private void label2_Click(object sender, EventArgs e)
        {
            Faccesorios f2 = new Faccesorios();
            f2.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Hide();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tesla.com/");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tesla.com/");
        }
>>>>>>> 13.24
    }
}
