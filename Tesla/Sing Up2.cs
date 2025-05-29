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
    public partial class SingUp2 : Form
    {
        public SingUp2()
        {
            InitializeComponent();
        }

        public static bool Validar(string us, string con)
        {
            return Users.Usuarios.Any(uss => uss.User == us && uss.Pass == con);
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string u = textBox1.Text;
            string p = textBox2.Text;

            bool v = SingUp2.Validar(u, p);

            if (checkBox1.Checked == true && v)
            {
                MessageBox.Show("Se ha registrado correctamente!");
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            else if (checkBox1.Checked == false)
            {
                MessageBox.Show("Debe aceptar el hCaptcha!");
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas ¡intente de nuevo!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Users.Usuarios.Count > 0)
            {
                int u = Users.Usuarios.Count - 1;
                Users.Usuarios.RemoveAt(u);
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            else
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }

        }

        private void SingUp2_Load(object sender, EventArgs e)
        {

        }
    }
}
