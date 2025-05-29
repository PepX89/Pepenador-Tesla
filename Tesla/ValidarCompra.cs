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
    public partial class ValidarCompra : Form
    {
        public ValidarCompra()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TeslaShop shop = new TeslaShop();
            shop.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass = textBox2.Text;

            Register Verdatos = Users.Obtener(Register.NombreA.UserActual);
            string contra = Verdatos.Pass;

            if(pass == contra)
            {
                MessageBox.Show("Compra validada, redirigiendo a la pantalla de compra...");
                TeslaShop shop = new TeslaShop();
                shop.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Compra denegada, clave incorrecta!");
            }
        }
    }
}
