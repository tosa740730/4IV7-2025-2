using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_GuiaConta.Clases
{
    public static class DatosContables
    {
        public static Dictionary<string, string> Definiciones = new Dictionary<string, string>
        {
            {"Banco", "Cuenta de activo. Representa el dinero disponible en cuentas bancarias."},
            {"Caja", "Cuenta de activo. Representa el efectivo disponible en la empresa."},
            {"Proveedores", "Cuenta de pasivo. Representa las deudas con los proveedores."},
            {"Clientes", "Cuenta de activo. Representa lo que deben los clientes a la empresa."},
            {"Capital", "Cuenta de capital. Representa el patrimonio aportado por el dueño."},
            {"Compras", "Cuenta de egreso. Representa el valor de mercancías adquiridas."},
            {"Ventas", "Cuenta de ingreso. Representa el total de ingresos por ventas."},
            {"Mobiliario y equipo", "Cuenta de activo. Representa el mobiliario adquirido."},
            {"Documentos por pagar", "Cuenta de pasivo. Representa deudas documentadas."},
            {"Terreno", "Cuenta de activo fijo. Valor del terreno propiedad de la empresa."},
            {"Equipo de transporte", "Cuenta de activo. Representa vehículos propiedad de la empresa."},
            {"Edificio", "Cuenta de activo fijo. Construcción propiedad de la empresa."},
            {"Gastos de venta", "Cuenta de gasto. Gastos relacionados con el proceso de venta."},
            {"Deudor", "Movimiento que incrementa el activo o disminuye pasivo/capital."},
            {"Acreedor", "Movimiento que incrementa pasivo o capital o disminuye activo."}
        };

        public static List<string> AsientosEjemplo = new List<string>
        {
            "Compra de mercancía al contado:\n  Compras     5,000.00 (Debe)\n  Caja                  5,000.00 (Haber)",
            "Pago a proveedores:\n  Proveedores 3,000.00 (Debe)\n  Banco                  3,000.00 (Haber)",
            "Venta al crédito:\n  Clientes    2,500.00 (Debe)\n  Ventas                2,500.00 (Haber)",
            "Adquisición de mobiliario:\n  Mobiliario y equipo 8,000.00 (Debe)\n  Banco                         8,000.00 (Haber)",
            "Pago de documento por pagar:\n  Documentos por pagar 4,000.00 (Debe)\n  Caja                         4,000.00 (Haber)",
            "Aportación del dueño:\n  Banco      15,000.00 (Debe)\n  Capital               15,000.00 (Haber)",
            "Compra de terreno al contado:\n  Terreno     20,000.00 (Debe)\n  Banco                  20,000.00 (Haber)",
            "Compra de edificio a crédito:\n  Edificio    80,000.00 (Debe)\n  Proveedores           80,000.00 (Haber)",
            "Venta al contado:\n  Caja        10,000.00 (Debe)\n  Ventas                10,000.00 (Haber)",
            "Gasto por publicidad:\n  Gastos de venta 1,200.00 (Debe)\n  Banco                   1,200.00 (Haber)"
        };

        public static Dictionary<string, string> CuentasT = new Dictionary<string, string>
        {
            {"Caja", "5,000.00  | 9,000.00"},
            {"Banco", "30,000.00 | 32,200.00"},
            {"Proveedores", "3,000.00  | 80,000.00"},
            {"Clientes", "2,500.00  | 0.00"},
            {"Compras", "5,000.00  | 0.00"},
            {"Ventas", "0.00       | 12,500.00"},
            {"Mobiliario y equipo", "8,000.00  | 0.00"},
            {"Documentos por pagar", "4,000.00  | 0.00"},
            {"Capital", "0.00       | 15,000.00"},
            {"Terreno", "20,000.00  | 0.00"},
            {"Edificio", "80,000.00  | 0.00"},
            {"Gastos de venta", "1,200.00  | 0.00"}
        };
    }
}
