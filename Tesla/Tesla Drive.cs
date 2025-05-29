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
    public partial class Tesla_Drive : Form
    {
        public Tesla_Drive()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ModelYBuy modely = new ModelYBuy();
            modely.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Model3Buy model3 = new Model3Buy();
            model3.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ModelCybertruckBuy cyber = new ModelCybertruckBuy();
            cyber.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ModelSBuy models = new ModelSBuy();
            models.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ModelXBuy modelx = new ModelXBuy();
            modelx.Show();
            this.Hide();
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
