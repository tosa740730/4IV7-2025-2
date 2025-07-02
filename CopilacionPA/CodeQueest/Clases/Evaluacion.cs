using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Evaluacion
    {
        Acertijos acertijos;
        Vidas vidas;
        Retroalimentacion retroalimentacion;
        MensajeDeMuerte MensajeDeMuerte;
        MensajeFinal MensajeFinal;
        public char respuesta;
        private int num_pregunta;
        public char Respuesta
        {
            get { return respuesta; }
            set { respuesta = value; }
        }
        public int Num_Pregunta
        {
            get { return num_pregunta; }
            set { num_pregunta = value; }
        }
        public int vidass
        {
            get { return vidas._Vidas; }
            set {}
        }
        public Evaluacion()
        {
            vidas = new Vidas();
            retroalimentacion = new Retroalimentacion();
            vidas._Vidas = 3;
            acertijos = new Acertijos();
            num_pregunta = 1;
            MensajeDeMuerte = new MensajeDeMuerte();
            MensajeFinal = new MensajeFinal();
        }

        private char RespuestaCorrecta()
        {
            switch (Num_Pregunta)
            {
                case 1: return 'B';
                case 2: return 'B';
                case 3: return 'B';
                case 4: return 'C';
                case 5: return 'D';
                case 6: return 'A';
                case 7: return 'C';
                case 8: return 'B';
                case 9: return 'A';
                case 10: return 'D';
                default: return ' ';
            }
        }
        public bool EvaluarPregunta()
        {
            char correcta = RespuestaCorrecta();

            bool pasa = false;
            if (char.ToUpper(Respuesta) == char.ToUpper(correcta))
            {
                Num_Pregunta++;
                pasa= true;
            }
            else
            {
                pasa= false;
                vidas._Vidas--;
            }
            return pasa;
        }
        public string LlamarRetroalimentacion()
        {
            string retro="";
            switch (num_pregunta)
            {
                case 1: retro= retroalimentacion.Pre1(); break;
                case 2: retro = retroalimentacion.Pre2(); break;
                case 3: retro = retroalimentacion.Pre3(); break;
                case 4: retro = retroalimentacion.Pre4(); break;
                case 5: retro = retroalimentacion.Pre5(); break;
                case 6: retro = retroalimentacion.Pre6(); break;
                case 7: retro = retroalimentacion.Pre7(); break;
                case 8: retro = retroalimentacion.Pre8(); break;
                case 9: retro = retroalimentacion.Pre9(); break;
                case 10: retro = retroalimentacion.Pre10(); break;
            }
            return retro;
        }
    }
}
