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
    public partial class Crear_Usuario : Form
    {
        Usuarios_guardados users = new Usuarios_guardados();
        public Crear_Usuario()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            if (TbxContraseña.Text != string.Empty && TbxUsuario.Text != string.Empty)
            {
                users.NuevaContraseña = TbxContraseña.Text;
                users.NuevoUsuario = TbxUsuario.Text;
                users.CrearUsuario();
                TbxContraseña.Text = "";
                TbxUsuario.Text = "";

                MessageBox.Show("Usuario Creado");
                Inicio_de_sesion inicio = new Inicio_de_sesion();
                this.Close();
                inicio.Show();
            }
            else
            {
                MessageBox.Show("Por favor no deje campos vacios");
            }
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            Inicio_de_sesion inicio = new Inicio_de_sesion();
            this.Hide();
            inicio.ShowDialog();
        }
    }
}
