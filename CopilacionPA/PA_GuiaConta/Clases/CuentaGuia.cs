using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_GuiaConta.Clases
{
    public class CuentaGuia
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; } // Activo, Pasivo, Capital, Ingreso, Gasto
        public string Descripcion { get; set; }
        public string Movimiento { get; set; } // Deudor o Acreedor

        public CuentaGuia(string nombre, string tipo, string descripcion, string movimiento)
        {
            Nombre = nombre;
            Tipo = tipo;
            Descripcion = descripcion;
            Movimiento = movimiento;
        }
    }
}
