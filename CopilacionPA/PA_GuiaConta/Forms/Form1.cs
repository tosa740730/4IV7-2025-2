/*
 * Proyecto Aula: Programa Guia de ontabilidad
 * 
 * Este proyecto fue hecho para dar a entender las definiciones de contabilidad: cuentas, movimientos, asientos, etc.
 * Ademas se muestran distintos tipos de ejmpllos de asientos contables y T´s de mayor para que el usuario pueda entender
 * el uso de estas.
 * El programa usa una interzagráfica sencilla para que el usuario pueda navegar por las distintas secciones del programa.
 * 
 * Autores: 
 * LANDETA GOMEZ ALEJANDRO
 * BUENFIL VALDEZ ALEXIS ALFREDO
 * CORTES SOSA ELIAS
 * VELAZCO VALLADOLID CHRISTOPHER ANGEL 
 * ROSALES ROSAS DANIEL
 * Grupo:4IV7
 * 
 * TODOS LOS DERECHOS RESERVADOS A LOS AUTORES DEL PROGRAMA.
*/
using PA_GuiaConta.Forms;
namespace PA_GuiaConta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu frmdos;

            frmdos = new FrmMenu();
            frmdos.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            frmdos.ShowDialog();
        }
    }
}
