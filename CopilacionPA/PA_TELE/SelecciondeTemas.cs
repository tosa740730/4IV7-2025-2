namespace PA_TELE
{
    public partial class SelecciondeTemas : Form
    {
        Temas misTemas;

        public SelecciondeTemas()
        {
            InitializeComponent();
            misTemas = new Temas();
        }

        private void SelecciondeTemas_Load(object sender, EventArgs e)
        {
            CrearBotonesDeTemas();
        }

        private void CrearBotonesDeTemas()
        {
            foreach (var tema in misTemas.ObtenerTemas())
            {
                Button boton = new Button();
                boton.Text = tema.Nombre;
                boton.Width = 150;
                boton.Height = 40;
                boton.Margin = new Padding(5);
                boton.Click += (s, e) => MostrarTema(tema.Nombre);

                flowLayoutPanel1.Controls.Add(boton);
            }
        }

        private void MostrarTema(string nombreTema)
        {
            Tema tema = misTemas.ObtenerTemaPorNombre(nombreTema);

            if (tema != null)
            {
                string texto = $"📘 Tema: {tema.Nombre}\n\n";

                foreach (var sub in tema.Subtemas)
                {
                    texto += $"🔹 Subtema: {sub.Nombre}\n";
                    texto += $"    {sub.Informacion}\n\n";
                }

                labelContenidoTema.Text = texto;
                // Nueva línea agregada para mover el scroll al inicio
                panelContenido.AutoScrollPosition = new Point(0, 0);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void panelContenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Agradecimientos form4 = new Agradecimientos())
            {
                form4.ShowDialog();
            }
        }
    }
}





