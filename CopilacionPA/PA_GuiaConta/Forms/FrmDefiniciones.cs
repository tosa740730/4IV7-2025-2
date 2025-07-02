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
    public partial class FrmDefiniciones : Form
    {
        public FrmDefiniciones()
        {
            InitializeComponent();
            cmbCategoria.Items.Add("Todas las definiciones");
            foreach (var clave in DatosContables.Definiciones.Keys)
            {
                cmbCategoria.Items.Add(clave);
            }
        }

        private void FrmDefiniciones_Load(object sender, EventArgs e)
        {

        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedIndex == 0)
            {
                string todo = "";
                foreach (var par in DatosContables.Definiciones)
                    todo += $"• {par.Key}: {par.Value}\n\n";

                rtbDefinicion.Text = todo;
            }
            else
            {
                string clave = cmbCategoria.SelectedItem.ToString();
                if (DatosContables.Definiciones.ContainsKey(clave))
                    rtbDefinicion.Text = $"• {clave}:\n{DatosContables.Definiciones[clave]}";
            }
        }
    }
}
