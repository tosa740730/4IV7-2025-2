using CalcDifer.Logica;

namespace CalcDifer
{
    public partial class FrmCalcDifer : Form
    {

        private readonly Font _fontTitulo = new Font("Segoe UI", 16, FontStyle.Bold);
        private readonly Font _fontSubtitulo = new Font("Segoe UI", 12, FontStyle.Bold);
        private readonly Font _fontCuerpo = new Font("Segoe UI", 11, FontStyle.Regular);
        private readonly Font _fontFormula = new Font("Consolas", 11, FontStyle.Regular);

        private readonly Color _colorPrimario = Color.FromArgb(0, 122, 204);
        private readonly Color _colorTexto = Color.FromArgb(220, 220, 220);
        private readonly Color _colorFormula = Color.FromArgb(186, 224, 186);

        private Button _botonSeleccionado = null;
        private int _unidadActual = 0;

        public FrmCalcDifer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SeleccionarUnidad(sender as Button, 2);
        }

        private void btnUnidad1_Click(object sender, EventArgs e)
        {
            SeleccionarUnidad(sender as Button, 1);
        }

        private void btnUnidad3_Click(object sender, EventArgs e)
        {
            SeleccionarUnidad(sender as Button, 3);
        }

        private void btnUnidad4_Click(object sender, EventArgs e)
        {
            SeleccionarUnidad(sender as Button, 4);
        }

        private void btnUnidad5_Click(object sender, EventArgs e)
        {
            SeleccionarUnidad(sender as Button, 5);
        }

        private void btnUnidad6_Click(object sender, EventArgs e)
        {
            SeleccionarUnidad(sender as Button, 6);
        }

        private void btnUnidad7_Click(object sender, EventArgs e)
        {
            SeleccionarUnidad(sender as Button, 7);
        }

        private void btnTeoria_Click(object sender, EventArgs e)
        {
            if (_unidadActual == 0) return;

            richTextBoxContenido.Clear();
            string teoria = "";
            string titulo = "";

            switch (_unidadActual)
            {
                case 1:
                    titulo = "UNIDAD 1: Funciones y Límites";
                    teoria = Calculo.GetTeoriaUnidad1();
                    break;
                case 2:
                    titulo = "UNIDAD 2: La Derivada (4 Pasos)";
                    teoria = Calculo.GetTeoriaUnidad2();
                    break;
                case 3:
                    titulo = "UNIDAD 3: Derivadas Algebraicas";
                    teoria = Calculo.GetTeoriaUnidad3();
                    break;
                case 4:
                    titulo = "UNIDAD 4: Aplicaciones";
                    teoria = Calculo.GetTeoriaUnidad4();
                    break;
                case 5:
                    titulo = "UNIDAD 5: Derivadas Exponenciales";
                    teoria = Calculo.GetTeoriaUnidad5();
                    break;
                case 6:
                    titulo = "UNIDAD 6: Derivadas Trigonométricas";
                    teoria = Calculo.GetTeoriaUnidad6();
                    break;
                case 7:
                    titulo = "UNIDAD 7: Diferenciales";
                    teoria = Calculo.GetTeoriaUnidad7();
                    break;
            }

            MostrarTeoria(titulo, teoria);
        }

        private void btnEjemplo_Click(object sender, EventArgs e)
        {
            if (_unidadActual == 0) return;

            richTextBoxContenido.Clear();
            string titulo = "";
            string ejemplo = "";
            string procedimiento = "";
            string solucion = "";

            switch (_unidadActual)
            {
                case 1:
                    titulo = "UNIDAD 1: Ejemplo Resuelto";
                    ejemplo = Calculo.GetEjemploUnidad1_1();
                    procedimiento = Calculo.GetProcedimientoUnidad1_1();
                    solucion = Calculo.GetSolucionUnidad1_1();
                    break;
                case 2:
                    titulo = "UNIDAD 2: Ejemplo Resuelto";
                    ejemplo = Calculo.GetEjemploUnidad2_1();
                    procedimiento = Calculo.GetProcedimientoUnidad2_1();
                    solucion = Calculo.GetSolucionUnidad2_1();
                    break;
                case 3:
                    titulo = "UNIDAD 3: Ejemplo Resuelto";
                    ejemplo = Calculo.GetEjemploUnidad3_1();
                    procedimiento = Calculo.GetProcedimientoUnidad3_1();
                    solucion = Calculo.GetSolucionUnidad3_1();
                    break;
                case 4:
                    titulo = "UNIDAD 4: Ejemplo Resuelto";
                    ejemplo = Calculo.GetEjemploUnidad4_1();
                    procedimiento = Calculo.GetProcedimientoUnidad4_1();
                    solucion = Calculo.GetSolucionUnidad4_1();
                    break;
                case 5:
                    titulo = "UNIDAD 5: Ejemplo Resuelto";
                    ejemplo = Calculo.GetEjemploUnidad5_1();
                    procedimiento = Calculo.GetProcedimientoUnidad5_1();
                    solucion = Calculo.GetSolucionUnidad5_1();
                    break;
                case 6:
                    titulo = "UNIDAD 6: Ejemplo Resuelto";
                    ejemplo = Calculo.GetEjemploUnidad6_1();
                    procedimiento = Calculo.GetProcedimientoUnidad6_1();
                    solucion = Calculo.GetSolucionUnidad6_1();
                    break;
                case 7:
                    titulo = "UNIDAD 7: Ejemplo Resuelto";
                    ejemplo = Calculo.GetEjemploUnidad7_1();
                    procedimiento = Calculo.GetProcedimientoUnidad7_1();
                    solucion = Calculo.GetSolucionUnidad7_1();
                    break;
            }

            MostrarEjemploCompleto(titulo, ejemplo, procedimiento, solucion);
        }

        private void SeleccionarUnidad(Button boton, int numeroUnidad)
        {
            // Cambiar apariencia del botón seleccionado
            if (_botonSeleccionado != null)
            {
                _botonSeleccionado.BackColor = Color.FromArgb(60, 60, 60);
            }

            _botonSeleccionado = boton;
            _botonSeleccionado.BackColor = _colorPrimario;
            _unidadActual = numeroUnidad;

            // Mostrar el submenu
            panelSubMenu.Visible = true;

            // Limpiar contenido
            richTextBoxContenido.Clear();
            AppendText($"UNIDAD {numeroUnidad} SELECCIONADA\n\n", _fontTitulo, _colorPrimario);
            AppendText("Elige una opción:\n", _fontSubtitulo, _colorTexto);
            AppendText("Teoría - Conceptos fundamentales\n", _fontCuerpo, _colorTexto);
            AppendText("Ejemplo - Ejercicio resuelto paso a paso", _fontCuerpo, _colorTexto);
        }

        private void AppendText(string text, Font font, Color color, HorizontalAlignment alignment = HorizontalAlignment.Left)
        {
            richTextBoxContenido.SelectionStart = richTextBoxContenido.TextLength;
            richTextBoxContenido.SelectionLength = 0;
            richTextBoxContenido.SelectionFont = font;
            richTextBoxContenido.SelectionColor = color;
            richTextBoxContenido.SelectionAlignment = alignment;
            richTextBoxContenido.AppendText(text);
        }

        private void MostrarTeoria(string titulo, string contenido)
        {
            AppendText($"{titulo}\n", _fontTitulo, _colorPrimario);
            AppendText(new string('═', 50) + "\n\n", _fontCuerpo, _colorPrimario);
            AppendText(contenido, _fontCuerpo, _colorTexto);
        }

        private void MostrarEjemplo(string titulo, string contenido)
        {
            AppendText($"{titulo}\n", _fontTitulo, _colorPrimario);
            AppendText(new string('═', 50) + "\n\n", _fontCuerpo, _colorPrimario);
            AppendText(contenido, _fontCuerpo, _colorTexto);
        }
        private void MostrarEjemploCompleto(string titulo, string ejemplo, string procedimiento, string solucion)
        {
            AppendText($"{titulo}\n", _fontTitulo, _colorPrimario);
            AppendText(new string('═', 50) + "\n\n", _fontCuerpo, _colorPrimario);

            AppendText("ENUNCIADO\n", _fontSubtitulo, _colorPrimario);
            AppendText(new string('─', 20) + "\n", _fontCuerpo, _colorPrimario);
            AppendText(ejemplo + "\n\n", _fontFormula, _colorFormula);

            AppendText("PROCEDIMIENTO\n", _fontSubtitulo, _colorPrimario);
            AppendText(new string('─', 20) + "\n", _fontCuerpo, _colorPrimario);
            AppendText(procedimiento + "\n\n", _fontCuerpo, _colorTexto);

            AppendText("SOLUCIÓN FINAL\n", _fontSubtitulo, _colorPrimario);
            AppendText(new string('─', 20) + "\n", _fontCuerpo, _colorPrimario);
            AppendText(solucion, _fontFormula, _colorFormula);
        }
    }
}