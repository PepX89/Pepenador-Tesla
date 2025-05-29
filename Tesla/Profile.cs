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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register verdatos = Users.Obtener(Register.NombreA.UserActual);
            string contra = verdatos.Pass;

            if (contra == textBox5.Text)
            {
                label2.Text = "     Datos de: " + Register.NombreA.UserActual + "     ";
                label9.Text = verdatos.Nombre;
                label10.Text = verdatos.Apellido;
                label11.Text = verdatos.User;
                label12.Text = verdatos.Region;
                label13.Text = verdatos.ad;
                textBox5.Clear();

            }
            else
            {
                MessageBox.Show("Contraseña incorrecta!");
            }


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
