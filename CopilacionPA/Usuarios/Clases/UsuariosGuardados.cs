using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuarios.Clases
{
    internal class Usuarios_guardados
    {
        public string NuevoUsuario { get; set; }
        public string NuevaContraseña { get; set; }
        public static List<PerfilUsuario> listado { get; set; } = new List<PerfilUsuario>();
        public void CrearUsuario()
        {
            listado.Add(new PerfilUsuario { NombreUsuario = NuevoUsuario, Contraseña = NuevaContraseña });
        }
        public Usuarios_guardados()
        {

            listado.Add(new PerfilUsuario { NombreUsuario = "User1", Contraseña = "uno" });
            listado.Add(new PerfilUsuario { NombreUsuario = "User2", Contraseña = "dos" });
            listado.Add(new PerfilUsuario { NombreUsuario = "User3", Contraseña = "tres" });
            listado.Add(new PerfilUsuario { NombreUsuario = "User4", Contraseña = "cuatro" });
            listado.Add(new PerfilUsuario { NombreUsuario = "User5", Contraseña = "cinco" });
            listado.Add(new PerfilUsuario { NombreUsuario = "User6", Contraseña = "seis" });
            listado.Add(new PerfilUsuario { NombreUsuario = "User7", Contraseña = "siete" });
            listado.Add(new PerfilUsuario { NombreUsuario = "User8", Contraseña = "ocho" });
            listado.Add(new PerfilUsuario { NombreUsuario = "User9", Contraseña = "nueve" });
            listado.Add(new PerfilUsuario { NombreUsuario = "User10", Contraseña = "diez" });

        }
    }

}
