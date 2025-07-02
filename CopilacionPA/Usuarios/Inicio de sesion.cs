using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Usuarios.Clases;

namespace Usuarios
{
    public partial class Inicio_de_sesion : Form
    {
        ValidaAcceso validacion = new ValidaAcceso();
        public Inicio_de_sesion()
        {
            InitializeComponent();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            Crear_Usuario crear_Usuario = new Crear_Usuario();
            this.Hide();
            crear_Usuario.ShowDialog();
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            PerfilUsuario p = new PerfilUsuario();
            p.NombreUsuario = TbxUsuario.Text;
            p.Contraseña = TbxContraseña.Text;

            if (ValidaAcceso.Acceso(p))
            {
                MessageBox.Show("Bienvenido");
                ActiveForm.Enabled = false;
                ActiveForm.Visible = false;
            }
            else
            {
                MessageBox.Show("Datos invalidos", "Error");
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
