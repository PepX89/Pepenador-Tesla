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
    public partial class Tesla_Robotics : Form
    {
        int count = Register.TeslaBot.count;
        public Tesla_Robotics()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            String botesla = "Reservacion de Optimus Tesla Bot";
            Register.TeslaBot.Bot = botesla;
            count++;
            Register.TeslaBot.count = count;
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

