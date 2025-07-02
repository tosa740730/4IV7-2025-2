namespace PA_TELE
{
    public partial class Agradecimientos : Form
    {
        public Agradecimientos()
        {
            InitializeComponent();

        }






        private void Agradecimientos_Load(object sender, EventArgs e)
        {

        }

        private void Lbl2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Regreso_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (SelecciondeTemas form3 = new SelecciondeTemas())
            {
                form3.ShowDialog();
            }
        }
    }
}
