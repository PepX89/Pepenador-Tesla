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
    public partial class FBestSellers : Form
    {
        int count = Register.CyberToy.count;
        int count2 = Register.CyberLev.count;
        int count3 = Register.TeslaToy.count;

        public FBestSellers()
        {
            InitializeComponent();
        }

        private void FBestSellers_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Faccesorios f1 = new Faccesorios();
            f1.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            TeslaShop shop = new TeslaShop();
            shop.Show();
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
        private void button4_Click(object sender, EventArgs e)
        {
            string toy = "Tesla Cybertruck Wind-Up Racer";
            Register.CyberToy.Cybertoy = toy;
            count++;
            Register.CyberToy.count = count;
            MessageBox.Show("Articulo añadido al carrito!");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string toy = "Tesla Bot Action Figure";
            Register.TeslaToy.teslatoy = toy;
            count3++;
            Register.TeslaToy.count = count3;
            MessageBox.Show("Articulo añadido al carrito!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string toy = "Levitating Cybertruck";
            Register.CyberLev.Cyberlev = toy;
            count2++;
            Register.CyberLev.count = count2;
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
