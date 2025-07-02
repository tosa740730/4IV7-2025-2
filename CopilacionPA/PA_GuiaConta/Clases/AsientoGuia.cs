using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_GuiaConta.Clases
{
    public class AsientoGuia
    {
        public string DescripcionOperacion { get; set; }
        public List<(string Cuenta, decimal Monto, string Tipo)> Movimientos { get; set; }
        public string ImagenEjemploPath { get; set; }

        public AsientoGuia(string descripcion)
        {
            DescripcionOperacion = descripcion;
            Movimientos = new List<(string Cuenta, decimal Monto, string Tipo)>();
        }

        public void AgregarMovimiento(string cuenta, decimal monto, string tipo)
        {
            Movimientos.Add((cuenta, monto, tipo));
        }
    }

}
