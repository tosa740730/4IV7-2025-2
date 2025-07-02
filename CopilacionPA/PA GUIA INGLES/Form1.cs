namespace PA_GUIA_INGLES
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void BtnVerTemas_Click(object sender, EventArgs e)
        {
            FrmTemas Form2 = new FrmTemas();
            Form2.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = MessageBox.Show("¿Salir de la App?",
            "Advertencia", MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);
            if (Resultado == DialogResult.Yes)
            {
                //Para salir de la aplicación (terminar la ejecución)

                //usar lo siguiente para salir
                this.Close();
            }
        }

        private void BtnEjercicios_Click(object sender, EventArgs e)
        {
            FrmEjercicios Form3 = new FrmEjercicios();
            Form3.Show();
        }
    }
}
