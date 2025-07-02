
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA_GuiaConta.Forms
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDefiniciones_Click(object sender, EventArgs e)
        {
            FrmDefiniciones frmdos;

            frmdos = new FrmDefiniciones();
            frmdos.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            frmdos.ShowDialog();
            this.Show();
        }

        private void btnAsientos_Click(object sender, EventArgs e)
        {
            FrmAsientos frmdos;

            frmdos = new FrmAsientos();
            frmdos.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            frmdos.ShowDialog();
            this.Show();
        }

        private void btnCuentasT_Click(object sender, EventArgs e)
        {
            FrmCuentasT frmdos;

            frmdos = new FrmCuentasT();
            frmdos.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            frmdos.ShowDialog();
            this.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = MessageBox.Show("¿Salir de la App?",
            "Advertencia", MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);
            if (Resultado == DialogResult.Yes)
            {
                //Para terminar la ejecución de la aplicación

                //usar lo siguiente
                this.Close();
            }
        }
    }
}

