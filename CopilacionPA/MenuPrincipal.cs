namespace CopilacionPA
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {

            InitializeComponent();
        }
        private void BtnIngles_FormClosed(object sender, EventArgs e)
        {
            this.Show();
        }
        private void BtnIngles_Click(object sender, EventArgs e)
        {
            var ingles = new PA_GUIA_INGLES.FrmInicio();
            this.Hide();
            ingles.FormClosed += BtnIngles_FormClosed;
            ingles.Show();
            BtnIngles.BackColor = Color.ForestGreen;
        }
        private void BtnFisica_FormClosed(object sender, EventArgs e)
        {
            this.Show();
        }
        private void BtnFisica_Click(object sender, EventArgs e)
        {
            var fisica = new ProyectoFisica.GuiaFisica();
            this.Hide();
            fisica.FormClosed += BtnFisica_FormClosed;
            fisica.Show();
            BtnFisica.BackColor = Color.ForestGreen;
        }
        private void BtnFinancieros_FormClosed(object sender, EventArgs e)
        {
            this.Show();
        }
        private void BtnFinancieros_Click(object sender, EventArgs e)
        {
            var financieros = new CalculosFinancierosII.Form1();
            this.Hide();
            financieros.FormClosed += BtnFinancieros_FormClosed;
            financieros.Show();
            BtnFinancieros.BackColor = Color.ForestGreen;
        }
        private void BtnTeleinfo_FormClosed(object sender, EventArgs e)
        {
            this.Show();
        }
        private void BtnTeleinfo_Click(object sender, EventArgs e)
        {
            var tele = new PA_TELE.Bienvenida();
            this.Hide();
            tele.FormClosed += BtnTeleinfo_FormClosed;
            tele.Show();
            BtnTeleinfo.BackColor = Color.ForestGreen;
        }
        private void BtnPoo_FormClosed(object sender, EventArgs e)
        {
            this.Show();
        }
        private void BtnPoo_Click(object sender, EventArgs e)
        {
            var Poo = new CodeQueest.CodeQuest();
            this.Hide();
            Poo.FormClosed += BtnTeleinfo_FormClosed;
            Poo.Show();
            BtnPoo.BackColor = Color.ForestGreen;
        }
        private void BtnConta_FormClosed(Object sender, EventArgs e)
        {
            this.Show();
        }

        private void BtnConta_Click(object sender, EventArgs e)
        {
            var conta = new PA_GuiaConta.Form1();
            var menuconta = new PA_GuiaConta.Forms.FrmMenu();
            this.Hide();
            conta.FormClosed += BtnConta_FormClosed;
            conta.Show();
            menuconta.FormClosed += BtnConta_FormClosed;
            BtnConta.BackColor = Color.ForestGreen;
        }
        private void BtnDif_FormClosed(Object sender, EventArgs e)
        {
            this.Show();
        }

        private void BtnDif_Click(object sender, EventArgs e)
        {
            var calcDifer = new CalcDifer.FrmCalcDifer();
            this.Hide();
            calcDifer.FormClosed += BtnDif_FormClosed;
            calcDifer.Show();
            BtnCalDif.BackColor = Color.ForestGreen;
        }
        private void BtnDerecho_FormClosed(Object sender, EventArgs e)
        {
            this.Show();
        }

        private void BtnDerecho_Click(object sender, EventArgs e)
        {
            var Derecho = new DerechoPA.Form1();
            this.Hide();
            Derecho.FormClosed += BtnDerecho_FormClosed;
            Derecho.Show();
            BtnDerecho.BackColor = Color.ForestGreen;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = MessageBox.Show("¿Salir de la App?",
            "Advertencia", MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);
            if (Resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
