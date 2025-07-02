using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_GuiaConta.Clases
{
    public class GuiaControlador
    {
        public List<CuentaGuia> Cuentas { get; private set; }
        public List<CuentaT> EjemplosCuentaT { get; private set; }
        public List<AsientoGuia> Asientos { get; private set; }

        public GuiaControlador()
        {
            Cuentas = new List<CuentaGuia>();
            EjemplosCuentaT = new List<CuentaT>();
            Asientos = new List<AsientoGuia>();
            CargarDatos();
        }

        private void CargarDatos()
        {
            // Cuentas
            Cuentas.Add(new CuentaGuia("Bancos", "Activo", "Representa el dinero depositado en bancos.", "Deudor"));
            Cuentas.Add(new CuentaGuia("Proveedores", "Pasivo", "Deudas con terceros por compras a crédito.", "Acreedor"));
            Cuentas.Add(new CuentaGuia("Acreedores", "Pasivo", "Personas a quienes se debe dinero por razones distintas a mercancías.", "Acreedor"));
            Cuentas.Add(new CuentaGuia("Almacén", "Activo", "Mercancía disponible para la venta.", "Deudor"));

            // Cuenta en T ejemplo
            var cuentaT = new CuentaT("Bancos");
            cuentaT.AgregarDebe("Depósito inicial $10,000");
            cuentaT.AgregarHaber("Pago a proveedor $4,000");
            EjemplosCuentaT.Add(cuentaT);

            // Asiento contable ejemplo
            var asiento = new AsientoGuia("Aportación de capital en efectivo");
            asiento.AgregarMovimiento("Bancos", 10000, "Debe");
            asiento.AgregarMovimiento("Capital", 10000, "Haber");
            asiento.ImagenEjemploPath = "recursos/asiento1.png"; // Ruta relativa o absoluta de la imagen
            Asientos.Add(asiento);
        }
    }
}
