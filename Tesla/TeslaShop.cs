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
    public partial class TeslaShop : Form
    {
        public TeslaShop()
        {
            InitializeComponent();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void TeslaShop_Load(object sender, EventArgs e)
        {
            label17.Text = "(x" + Register.Model3.count.ToString() + ") " + Register.Model3.Models;
            label18.Text = "(x" + Register.CyberT.count.ToString() + ") " + Register.CyberT.Cyber;
            label19.Text = "(x" + Register.ModelS.count.ToString() + ") " + Register.ModelS.Models;
            label20.Text = "(x" + Register.ModelY.count.ToString() + ") " + Register.ModelY.Modely;
            label21.Text = "(x" + Register.ModelX.count.ToString() + ") " + Register.ModelX.Modelx;
            label22.Text = "(x" + Register.TeslaBot.count.ToString() + ") " + Register.TeslaBot.Bot;
            label23.Text = "(x" + Register.StarlinkHome.count.ToString() + ") " + Register.StarlinkHome.SHome;
            label24.Text = "(x" + Register.StarlinkVagar.count.ToString() + ") " + Register.StarlinkVagar.SVagar;
            label25.Text = "(x" + Register.Panel1.count.ToString() + ") " + Register.Panel1.panel1;
            label26.Text = "(x" + Register.Panel2.count.ToString() + ") " + Register.Panel2.panel2;
            label27.Text = "(x" + Register.Panel13.count.ToString() + ") " + Register.Panel13.panel3;
            label28.Text = "(x" + Register.Panel4.count.ToString() + ") " + Register.Panel4.panel4;
            label29.Text = "(x" + Register.CyberToy.count.ToString() + ") " + Register.CyberToy.Cybertoy;
            label30.Text = "(x" + Register.CyberLev.count.ToString() + ") " + Register.CyberLev.Cyberlev;
            label43.Text = "(x" + Register.TeslaToy.count.ToString() + ") " + Register.TeslaToy.teslatoy;
            label44.Text = "(x" + Register.Tesla20.count.ToString() + ") " + Register.Tesla20.T20;
            label45.Text = "(x" + Register.MiniCyber.count.ToString() + ") " + Register.MiniCyber.minicyber;
            label46.Text = "(x" + Register.MiniQuad.count.ToString() + ") " + Register.MiniQuad.miniquad;
            label47.Text = "(x" + Register.CyberMug.count.ToString() + ") " + Register.CyberMug.Cybermug;
            label48.Text = "(x" + Register.Road.count.ToString() + ") " + Register.Road.road;
            label49.Text = "(x" + Register.Vesse.count.ToString() + ") " + Register.Vesse.vesse;
            label50.Text = "(x" + Register.MiniPack.count.ToString() + ") " + Register.MiniPack.minipack;
            label53.Text = "(x" + Register.ElevatePack.count.ToString() + ") " + Register.ElevatePack.Elevatepack;
            label54.Text = "(x" + Register.MegaPack.count.ToString() + ") " + Register.MegaPack.Megapack;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void label53_Click(object sender, EventArgs e)
        {

        }

        private void label54_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
            label17.Text = "(x0)";
            label18.Text = "(x0)";
            label19.Text = "(x0)";
            label20.Text = "(x0)";
            label21.Text = "(x0)";
            label22.Text = "(x0)";
            label23.Text = "(x0)";
            label24.Text = "(x0)";
            label25.Text = "(x0)";
            label26.Text = "(x0)";
            label27.Text = "(x0)";
            label28.Text = "(x0)";
            label29.Text = "(x0)";
            label30.Text = "(x0)";
            label43.Text = "(x0)";
            label44.Text = "(x0)";
            label45.Text = "(x0)";
            label46.Text = "(x0)";
            label47.Text = "(x0)";
            label48.Text = "(x0)";
            label49.Text = "(x0)";
            label50.Text = "(x0)";
            label53.Text = "(x0)";
            label54.Text = "(x0)";
            ValidarCompra vc = new ValidarCompra();
            vc.Show();
            this.Hide();
        }
    }
}
