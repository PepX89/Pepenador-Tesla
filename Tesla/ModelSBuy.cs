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
    public partial class ModelSBuy : Form
    {
        int count = Register.ModelS.count;
        public ModelSBuy()
        {
            InitializeComponent();
        }

        private void TeslaSBuy_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Tesla_Drive drive = new Tesla_Drive();
            drive.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Faccesorios accesorios = new Faccesorios();
            accesorios.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string smodel = "Tesla Model S, Año 2025";
            Register.ModelS.Models = smodel;
            count++;
            Register.ModelS.count = count;
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
