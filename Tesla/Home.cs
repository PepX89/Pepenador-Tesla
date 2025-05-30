using System.Drawing;
using System.Drawing.Drawing2D;


namespace Tesla
{
    public partial class Home : Form
    {
        public Home()


        {
            InitializeComponent();
        }
        private void RedondearPictureBox(PictureBox pb, int radio)
        {
            GraphicsPath path = new GraphicsPath();//¿Qué hace GraphicsPath? Cuando usas GraphicsPath, creas un "camino" de dibujo que puede incluir: ✔ Líneas rectas(AddLine) ✔ Curvas Bézier(AddBezier) ✔ Arcos y círculos(AddArc) ✔ Polígonos(AddPolygon) ✔ Textos y formas complejas(AddString)Al definir este "camino", puedes aplicarlo a un Region, recortar una imagen o incluso rellenarlo con colores y texturas.
            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(pb.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(pb.Width - radio, pb.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, pb.Height - radio, radio, radio, 90, 90);
            path.CloseFigure();//✔ Evita que el trazado quede abierto. ✔ Asegura que la figura se pueda rellenar correctamente. ✔ Hace que el contorno se cierre sin necesidad de agregar manualmente la última línea.

            pb.Region = new Region(path); //Aplica la forma del pictueBox
        }
        private void RedondearBoton(Button btn, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(btn.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(btn.Width - radio, btn.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, btn.Height - radio, radio, radio, 90, 90);
            path.CloseFigure();

            btn.Region = new Region(path); //Aplica la forma al botón
        }
        private void RedondearLabel(Label btn, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(btn.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(btn.Width - radio, btn.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, btn.Height - radio, radio, radio, 90, 90);
            path.CloseFigure();

            btn.Region = new Region(path); //Aplica la forma al botón
        }
        private void Home_Load(object sender, EventArgs e)
        {

            RedondearPictureBox(pictureBox10, 50);
            RedondearPictureBox(pictureBox11, 50);
            RedondearPictureBox(pictureBox12, 50);
            RedondearPictureBox(pictureBox13, 50);
            RedondearLabel(label1, 10);
            RedondearLabel(label2, 10);
            RedondearLabel(label3, 10);
            RedondearLabel(label4, 10);



        }




        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Tesla_Drive drive = new Tesla_Drive();
            drive.Show();
            this.Hide();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TeslaEnergy energy = new TeslaEnergy();
            energy.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Tesla_Robotics robot = new Tesla_Robotics();
            robot.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            TeslaShop shop = new TeslaShop();
            shop.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Faccesorios F = new Faccesorios(); // Nos envia a otro formulario
            F.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Tesla_Starlink star = new Tesla_Starlink();
            star.Show();
            this.Hide();
        }

        private void pictureBox12_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ModelCybertruckBuy cyber = new ModelCybertruckBuy();
            cyber.Show();
            this.Hide();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }

}
