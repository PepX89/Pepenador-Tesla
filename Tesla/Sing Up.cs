using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace Tesla
{
    public partial class Sing_Up : Form
    {
        public Sing_Up()
        {
            InitializeComponent();
        }
        public static bool Validar(string us)
        {
            return Users.Usuarios.Any(uss => uss.User == us);
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string apellido = textBox2.Text;
            string region = textBox3.Text;
            string us = textBox4.Text;
            string contraseña = textBox5.Text;
            string direccion = textBox6.Text;

            bool v = Sing_Up.Validar(us);

            if (v)
            {
                MessageBox.Show("Este nombre de usuario ya esta ocupado, ¡prueba otro!");
            }
            else if (nombre == "")
            {
                MessageBox.Show("Debe ingresar todos los datos, ingrese un nombre");
            }
            else if (apellido == "")
            {
                MessageBox.Show("Debe ingresar todos los datos, ingrese un apellido");
            }
            else if (region == "")
            {
                MessageBox.Show("Debe ingresar todos los datos, ingrese una region");
            }
            else if (direccion == "")
            {
                MessageBox.Show("Debe ingresar todos los datos, ingrese una direccion");
            }
            else if (us == "")
            {
                MessageBox.Show("Debe ingresar todos los datos, ingrese un usuario");
            }
            else if (contraseña == "")
            {
                MessageBox.Show("Debe ingresar todos los datos, ingrese una contraseña");
            }
            else
            {
                Register usuario = new Register(nombre, apellido, region, us, contraseña, direccion);
                Users.Usuarios.Add(usuario);

                SingUp2 sing = new SingUp2();
                sing.Show();
                this.Hide();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
