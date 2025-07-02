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
    public partial class FrmAsientos : Form
    {
        public FrmAsientos()
        {
            InitializeComponent();
            ConfigurarTabla();
            LlenarCombo();
        }

        private void FrmAsientos_Load(object sender, EventArgs e)
        {

        }

        private void ConfigurarTabla()
        {
            dgvAsientos.ColumnCount = 5;
            dgvAsientos.Columns[0].Name = "Fecha";
            dgvAsientos.Columns[1].Name = "Cuenta";
            dgvAsientos.Columns[2].Name = "Parcial";
            dgvAsientos.Columns[3].Name = "Debe";
            dgvAsientos.Columns[4].Name = "Haber";

            dgvAsientos.Columns[0].Width = 100;
            dgvAsientos.Columns[1].Width = 200;
            dgvAsientos.Columns[2].Width = 100;
            dgvAsientos.Columns[3].Width = 100;
            dgvAsientos.Columns[4].Width = 100;

            dgvAsientos.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvAsientos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            dgvAsientos.RowTemplate.Height = 28;

            dgvAsientos.ReadOnly = true;
            dgvAsientos.AllowUserToAddRows = false;
            dgvAsientos.AllowUserToResizeRows = false;
        }
        private void LlenarCombo()
        {
            cmbEjemplos.Items.Add("Compra de mercancía al contado");
            cmbEjemplos.Items.Add("Pago a proveedores");
            cmbEjemplos.Items.Add("Venta al crédito");
            cmbEjemplos.Items.Add("Adquisición de mobiliario");
            cmbEjemplos.Items.Add("Pago de documento por pagar");
            cmbEjemplos.Items.Add("Aportación del dueño a capital");
            cmbEjemplos.Items.Add("Compra de terreno al contado");
            cmbEjemplos.Items.Add("Compra de edificio a crédito");
            cmbEjemplos.Items.Add("Venta al contado");
            cmbEjemplos.Items.Add("Gasto por publicidad");
            cmbEjemplos.SelectedIndexChanged += cmbEjemplos_SelectedIndexChanged;
        }

        private void cmbEjemplos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cmbEjemplos.SelectedIndex;
            dgvAsientos.Rows.Clear();
            rtbConcepto.Clear();
            string concepto = "";
            decimal totalDebe = 0;
            decimal totalHaber = 0;

            switch (i)
            {
                case 0:
                    dgvAsientos.Rows.Add("01/01/2023", "Compras", "", "5000.00", "");
                    dgvAsientos.Rows.Add("01/01/2023", "Caja", "", "", "5000.00");
                    concepto = "Compra de mercancía al contado.";
                    totalDebe = totalHaber = 5000;
                    break;
                case 1:
                    dgvAsientos.Rows.Add("03/01/2023", "Proveedores", "", "3000.00", "");
                    dgvAsientos.Rows.Add("03/01/2023", "Banco", "", "", "3000.00");
                    concepto = "Pago a proveedores.";
                    totalDebe = totalHaber = 3000;
                    break;
                case 2:
                    dgvAsientos.Rows.Add("05/01/2023", "Clientes", "", "2500.00", "");
                    dgvAsientos.Rows.Add("05/01/2023", "Ventas", "", "", "2500.00");
                    concepto = "Venta al crédito.";
                    totalDebe = totalHaber = 2500;
                    break;
                case 3:
                    dgvAsientos.Rows.Add("07/01/2023", "Mobiliario y equipo", "", "8000.00", "");
                    dgvAsientos.Rows.Add("07/01/2023", "Banco", "", "", "8000.00");
                    concepto = "Adquisición de mobiliario.";
                    totalDebe = totalHaber = 8000;
                    break;
                case 4:
                    dgvAsientos.Rows.Add("09/01/2023", "Documentos por pagar", "", "4000.00", "");
                    dgvAsientos.Rows.Add("09/01/2023", "Caja", "", "", "4000.00");
                    concepto = "Pago de documento por pagar.";
                    totalDebe = totalHaber = 4000;
                    break;
                case 5:
                    dgvAsientos.Rows.Add("10/01/2023", "Banco", "", "15000.00", "");
                    dgvAsientos.Rows.Add("10/01/2023", "Capital", "", "", "15000.00");
                    concepto = "Aportación de capital del dueño.";
                    totalDebe = totalHaber = 15000;
                    break;
                case 6:
                    dgvAsientos.Rows.Add("12/01/2023", "Terreno", "", "20000.00", "");
                    dgvAsientos.Rows.Add("12/01/2023", "Banco", "", "", "20000.00");
                    concepto = "Compra de terreno al contado.";
                    totalDebe = totalHaber = 20000;
                    break;
                case 7:
                    dgvAsientos.Rows.Add("14/01/2023", "Edificio", "", "80000.00", "");
                    dgvAsientos.Rows.Add("14/01/2023", "Proveedores", "", "", "80000.00");
                    concepto = "Compra de edificio a crédito.";
                    totalDebe = totalHaber = 80000;
                    break;
                case 8:
                    dgvAsientos.Rows.Add("16/01/2023", "Caja", "", "10000.00", "");
                    dgvAsientos.Rows.Add("16/01/2023", "Ventas", "", "", "10000.00");
                    concepto = "Venta al contado.";
                    totalDebe = totalHaber = 10000;
                    break;
                case 9:
                    dgvAsientos.Rows.Add("18/01/2023", "Gastos de venta", "", "1200.00", "");
                    dgvAsientos.Rows.Add("18/01/2023", "Banco", "", "", "1200.00");
                    concepto = "Gasto por publicidad.";
                    totalDebe = totalHaber = 1200;
                    break;
            }

            rtbConcepto.SelectionFont = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            rtbConcepto.AppendText("Concepto:\n");
            rtbConcepto.SelectionFont = new Font("Segoe UI", 10);
            rtbConcepto.AppendText(concepto);

            txtSumas.Text = totalDebe.ToString("N2");
        }
    }
}
