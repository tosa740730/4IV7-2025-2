using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_GuiaConta.Clases
{
    public class CuentaT
    {
        public string NombreCuenta { get; set; }
        public List<string> Debe { get; set; }
        public List<string> Haber { get; set; }

        public CuentaT(string nombreCuenta)
        {
            NombreCuenta = nombreCuenta;
            Debe = new List<string>();
            Haber = new List<string>();
        }

        public void AgregarDebe(string descripcion)
        {
            Debe.Add(descripcion);
        }

        public void AgregarHaber(string descripcion)
        {
            Haber.Add(descripcion);
        }
    }
}
