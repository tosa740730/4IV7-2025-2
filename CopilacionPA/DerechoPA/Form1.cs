namespace DerechoPA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double guia = Convert.ToDouble(txtGuia.Text);
                double examen = Convert.ToDouble(txtExamen.Text);
                double libros = Convert.ToDouble(txtLibros.Text);
                double contrato = Convert.ToDouble(txtContrato.Text);
                double planetario = Convert.ToDouble(txtPlanetario.Text);

                if (guia < 0 || guia > 10 || examen < 0 || examen > 5 ||
                    libros < 0 || libros > 10 || contrato < 0 || contrato > 10 ||
                    planetario < 0 || planetario > 10)
                {
                    MessageBox.Show("Todas las calificaciones deben estar entre 0 y 100 (inclusive)",
                                  "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double promedio = (guia * 1.0) +      // 10%
                                 (examen * 10) +     // 50% 
                                 (libros * 1.0) +     // 10%
                                 (contrato * 2.0) +   // 20%
                                 (planetario * 1.0);  // 10%

                promedio /= 10.0;

                lblResultado.Text = $"Promedio final: {promedio:F1}";
                lblResultado.BackColor = promedio >= 6.0 ? Color.LightGreen: Color.Red;
                lblResultado.ForeColor = Color.Black;
            }
            catch (FormatException)
            {
                MessageBox.Show("Error: Todos los campos deben contener números válidos",
                              "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtGuia.Clear();
            txtExamen.Clear();
            txtLibros.Clear();
            txtContrato.Clear();
            txtPlanetario.Clear();
            lblResultado.Text = "Promedio final: -- / 10";
            lblResultado.BackColor = Color.FromArgb(240, 240, 240);

            txtGuia.Focus();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que deseas salir?",
                                                "Confirmar salida", MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}


