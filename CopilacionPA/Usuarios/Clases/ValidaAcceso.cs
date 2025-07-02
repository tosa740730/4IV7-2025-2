using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuarios.Clases
{
    internal class ValidaAcceso
    {
        public static bool Acceso(PerfilUsuario pu)
        {
            Usuarios_guardados u = new Usuarios_guardados();
            bool TieneAcceso = false;
            if (pu == null)
            {
                TieneAcceso = false;
            }
            else
            {
                TieneAcceso = false;
                foreach (PerfilUsuario p in Usuarios_guardados.listado)
                {
                    if (string.Compare(pu.NombreUsuario.Trim(), p.NombreUsuario, StringComparison.OrdinalIgnoreCase) == 0 && pu.Contraseña.Equals(p.Contraseña))
                    {
                        TieneAcceso = true;
                        break;
                    }
                }
            }
            return TieneAcceso;
        }

    }
}
