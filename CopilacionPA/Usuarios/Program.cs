using Usuarios.Clases;

namespace Usuarios
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Usuarios_guardados.listado = new List<PerfilUsuario>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Inicio_de_sesion());

        }
    }
}