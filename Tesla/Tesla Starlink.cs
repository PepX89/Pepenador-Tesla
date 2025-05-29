using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Tesla.Register;

namespace Tesla
{
    public partial class Tesla_Starlink : Form
    {
        int count = Register.StarlinkHome.count;
        int count2 = Register.StarlinkHome.count;
        public Tesla_Starlink()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Faccesorios accesorios = new Faccesorios();
            accesorios.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string homeS = "Starlink Home plan, 1 mes de servicio";
            Register.StarlinkHome.SHome = homeS;
            count++;
            Register.StarlinkHome.count = count;
            MessageBox.Show("Articulo añadido al carrito!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string vagarS = "Starlink Vagar plan, 1 mes de servicio";
            Register.StarlinkVagar.SVagar = vagarS;
            count2++;
            Register.StarlinkVagar.count = count2;
            MessageBox.Show("Articulo añadido al carrito!");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            TeslaShop shop = new TeslaShop();
            shop.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Hide();
        }
    }
}
