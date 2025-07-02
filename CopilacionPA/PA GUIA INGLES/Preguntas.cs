namespace PA_GUIA_INGLES
{
    public class Preguntas
    {
        public string Texto { get; set; }
        public List<string> Opciones { get; set; }
        public int IndiceCorrecto { get; set; } // Empieza por el 0,1,2 y así hasta x numero

        public Preguntas(string texto, List<string> opciones, int correcta)
        {
            Texto = texto;
            Opciones = opciones;
            IndiceCorrecto = correcta;
        }
    }
}
