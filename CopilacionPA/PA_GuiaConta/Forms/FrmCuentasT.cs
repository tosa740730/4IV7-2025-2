using PA_GuiaConta.Clases;
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
    public partial class FrmCuentasT : Form
    {
        public FrmCuentasT()
        {
            InitializeComponent();
            LlenarCombo();
        }

        private void FrmCuentasT_Load(object sender, EventArgs e)
        {

        }

        private void LlenarCombo()
        {
            cmbCuentas.Items.Clear();
            foreach (var cuenta in DatosContables.CuentasT.Keys)
            {
                cmbCuentas.Items.Add(cuenta);
            }
            cmbCuentas.SelectedIndexChanged += cmbCuentas_SelectedIndexChanged;
        }

        private void cmbCuentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            flpT.Controls.Clear();
            string cuentaSel = cmbCuentas.SelectedItem.ToString();
            if (DatosContables.CuentasT.ContainsKey(cuentaSel))
            {
                GroupBox gb = new GroupBox();
                gb.Text = $"Cuenta: {cuentaSel}";
                gb.Width = 260;
                gb.Height = 90;
                gb.Font = new Font("Segoe UI", 9, FontStyle.Bold);

                Label lblEncabezado = new Label();
                lblEncabezado.Text = "DEBE            |    HABER";
                lblEncabezado.Font = new Font("Consolas", 10, FontStyle.Underline);
                lblEncabezado.Location = new Point(10, 20);
                lblEncabezado.AutoSize = true;

                Label lblValores = new Label();
                lblValores.Text = DatosContables.CuentasT[cuentaSel];
                lblValores.Font = new Font("Consolas", 10);
                lblValores.Location = new Point(10, 45);
                lblValores.AutoSize = true;

                gb.Controls.Add(lblEncabezado);
                gb.Controls.Add(lblValores);
                flpT.Controls.Add(gb);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
