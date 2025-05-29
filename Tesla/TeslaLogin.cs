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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static bool validarUsuario(string u)
        {
            return Users.Usuarios.Any(uss => uss.User == u);
        }
        public static bool validarContraseña(string c)
        {
            return Users.Usuarios.Any(uss => uss.Pass == c);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;

            bool v = Login.validarUsuario(usuario);
            bool w = Login.validarContraseña(contraseña);

            if (Users.Usuarios.Count > 0)
            {
                if (v && w)
                {
                    Register.NombreA.UserActual = usuario;

                    MessageBox.Show("Bienvenido " + usuario);
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                else if (w)
                {
                    MessageBox.Show("Credenciales invalidas! ingrese un usuario registrado");
                }
                else if (v)
                {
                    MessageBox.Show("Credenciales invalidas! ingrese la contraseña correcta");
                }
                else
                {
                    MessageBox.Show("Credenciales invalidas!");
                }
            }
            else
            {
                MessageBox.Show("No hay usuarios registrados, !por favor registre uno¡");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sing_Up sing = new Sing_Up();
            sing.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            ;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
           
        }
    }
}
