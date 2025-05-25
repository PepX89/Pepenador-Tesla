using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_5_pts
{
    public partial class Form3: Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            int op;
            op = 0;
            if (rbfact.Checked == true)
            {
                op = 1;
            }
            else if (rbfig.Checked == true)
            {
                op = 2;
            }
            else if (rbnota.Checked == true)
            {
                op = 3;
            }
            else if (rbestudiante.Checked == true)
            {
                op = 4;
            }
            else
            {
                MessageBox.Show("Elija una opcion correcta");
            }

            switch (op)
            {
                case 1:
                    MessageBox.Show("Escogio factorial de un numero");
                    FormFactorial fact = new FormFactorial();
                    fact.Show();
                    this.Hide();
                    break;

                case 2:
                    MessageBox.Show("Escogio areas de figuras");
                    FormAreas areas = new FormAreas();
                    areas.Show();
                    this.Hide();
                    break;
                case 3:
                    MessageBox.Show("Escogio areas de figuras");
                    FormPromedio promedio = new FormPromedio();
                    promedio.Show();
                    this.Hide();
                    break;
                case 4:
                    MessageBox.Show("Escogio areas de figuras");
                    FormDatos datos = new FormDatos();
                    datos.Show();
                    this.Hide();
                    break;

            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
