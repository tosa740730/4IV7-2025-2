namespace PA_TELE
{
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Introducci�n form2 = new Introducci�n())
            {
                form2.ShowDialog();
            }

            // Decide si quieres mostrar Form1 nuevamente o cerrar la app
            this.Show(); // o Application.Exit();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
