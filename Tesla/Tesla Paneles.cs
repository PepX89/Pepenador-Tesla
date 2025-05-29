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
    public partial class Tesla_Paneles : Form
    {
        int count = Register.Panel1.count;
        int count2 = Register.Panel2.count;
        int count3 = Register.Panel13.count;
        int count4 = Register.Panel4.count;
        public Tesla_Paneles()
        {
            InitializeComponent();
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

        private void button4_Click(object sender, EventArgs e)
        {
            string pane1 = "5 solar panel + tesla powerball";
            Register.Panel1.panel1 = pane1;
            count++;
            Register.Panel1.count = count;
            MessageBox.Show("Articulo añadido al carrito!");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string pane2 = "Individual solar panel";
            Register.Panel2.panel2 = pane2;
            count2++;
            Register.Panel2.count = count2;
            MessageBox.Show("Articulo añadido al carrito!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string pane3 = "Tesla powerball";
            Register.Panel13.panel3 = pane3;
            count3++;
            Register.Panel13.count = count3;
            MessageBox.Show("Articulo añadido al carrito!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string pane4 = "Tesla powerball";
            Register.Panel4.panel4 = pane4;
            count4++;
            Register.Panel4.count = count4;
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
