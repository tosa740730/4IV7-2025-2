using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Acertijos
    {
        public int numeros;
        public string insisoA;
        public string insisoB;
        public string insisoC;
        public string insisoD;
        public int Numeros
        {
            get { return numeros; }
            set { numeros = value; }
        }
        public Acertijos()
        {
            Numeros = 0;
        }
        public string InsisoA
        {
            get { return insisoA; }
            set { insisoA = value; }
        }
        public string InsisoB
        {
            get { return insisoB; }
            set { insisoB = value; }
        }
        public string InsisoC
        {
            get { return insisoC; }
            set { insisoC = value; }
        }
        public string InsisoD
        {
            get { return insisoD; }
            set { insisoD = value; }
        }

        public void Insisos()
        {
            switch (Numeros)
            {
                case 1:
                    insisoA = "Clases";
                    insisoB = "Encapsulamiento";
                    insisoC = "Algoritmos";
                    insisoD = "Variables";
                    break;
                case 2:
                    insisoA = "Llave 1: ==";
                    insisoB = "Llave 2: =";
                    insisoC = "---";
                    insisoD = "---";
                    break;
                case 3:
                    insisoA = "If, main, else";
                    insisoB = "Secuencial, Selectivas, Iterativas";
                    insisoC = "Consecutivas, Variables, Iterativas";
                    insisoD = "---";
                    break;
                case 4:
                    insisoA = "El programa compila correctamente.";
                    insisoB = "Porque el programa fue escrito en un lenguaje de programación diferente.";
                    insisoC = "Debido a un error de diseño del algoritmo.";
                    insisoD = "---";
                    break;
                case 5:
                    insisoA = ".cpp";
                    insisoB = ".java";
                    insisoC = ".py";
                    insisoD = ".cs";
                    break;
                case 6:
                    insisoA = "Ciclos anidados";
                    insisoB = "Condicionales anidados";
                    insisoC = "Estructura de datos";
                    insisoD = "---";
                    break;
                case 7:
                    insisoA = "Variables globales, funciones, bucles.";
                    insisoB = "Archivos, carpetas, rutas.";
                    insisoC = "Atributos, métodos, constructor.";
                    insisoD = "---";
                    break;
                case 8:
                    insisoA = "Estático, dinámico, final.";
                    insisoB = "Privado, público, protegido.";
                    insisoC = "Global, local, interno.";
                    insisoD = "---";
                    break;
                case 9:
                    insisoA = "30";
                    insisoB = "5";
                    insisoC = "26";
                    insisoD = "13";
                    break;
                case 10:
                    insisoA = "Sobra un break";
                    insisoB = "Sobra un .";
                    insisoC = "Falta un {";
                    insisoD = "Falta un ;";
                    break;
            }
        }
        public string Preguntas()
        {
            string pre="";
            switch (Numeros)
            {
                case 1:
                    pre = "*El usuario entra en la habitación y posterior a cerrar la puerta una voz le dice;*\n“Yo seré tu primer desafío en la torre Codequest\ndonde la lógica manda y se pone a prueba el ingenio en el test.\nPor ser la primera, será fácil de resolver, pero no te confíes, pues tienes mucho por aprender.”\n\n¿Cuál de los siguientes es un pilar de la POO?"; 
                    break;
                case 2:
                    pre = "*El usuario entra y en la sala solo observa 2 llaves y la voz le pregunta:*\n “¿Qué operador se usa para asignar un valor a una variable?”, \n\n*en la parte superior de la puerta hay 2 llaves con los signos:*"; 
                    break;
                case 3:
                    pre="*El usuario ingresa a la habitación mientras una voz le dice lo siguiente:*\n“Veamos cuánto sabes de Estructuras de Control… \n\n¿Cómo se llaman los 3 tipos de estructuras?”" ;
                    break;
                case 4:
                    pre= "*El usuario entró un poco inseguro al acertijo ya que las preguntas estaban \nsubiendo de nivel pero la voz interrumpiendo sus pensamientos dijo:*\n«No hay que temer,prosigamos con el siguiente acertijo…»\n\nEn cuál de estas 3 opciones se puede generar una excepción?”" ;
                    break;
                case 5:
                    pre= "*Al entrar a la siguiente habitación, una voz recibe al usuario*\n«Casi estás por terminar, de la torre Codequest pronto vas a escapar.»\nMás tus respuestas debes meditar, pues aunque parezca fácil,\nte puede engañar.La verdad no estará frente a tu mirar…\n\n¿Cuál es la extensión que en C# se suele usar para un archivo que el código ha de albergar?" ;
                    break;
                case 6:
                    pre= "*La voz le dice*\n«Bien, bien, bien, espero sigas con esta racha de respuestas correctas…»\n\nLa siguiente estructura es un ejemplo de?\nfor (int i=1;i<=20;i++)\n   {\n      Cuerpo del ciclo externo\n      for(int j=1;j<=50;j++)\n              {\n                     Cuerpo del ciclo interno\n              }\n   }"; 
                    break;
                case 7:
                    pre= "*La voz dice lo siguiente*\n«Cada vez más cerca del final…una lástima, ya me empezaba a encariñar contigo»\nnótese la ironía pero bueno este es el siguiente acertijo\n\n¿Una clase está formada por?";
                    break;
                case 8:
                    pre= "*La voz dice*\n«Este acertijo me agrada por lo que creo que es necesario decirlo en primera persona…»\n«Soy un conjunto de reglas que definen quién puede ver y usar los miembros de una clase»\n«Mis tres formas principales son como puertas:»\n«Una está completamente abierta, otra está entreabierta y la última está cerrada con llave»"; 
                    break;
                case 9:
                    pre= "*El usuario ingresa a la habitación y es sorprendido por una voz*\n«Si logras entender mi ciclo, la puerta se abrirá y al siguiente acertijo has de pasar…»\nDentro del código se esconde una pista final\n«Ve con cuidado, no te dejes engañar, pues la respuesta final se acercará»\n\n¿Cuál es el número que se va a mostrar?\n\n                          int x = 0;\n                        for (int i = 1; i <= 10; i++) \n                            {\n                                 if (i % 2 == 0) \n                                  {\n                                         x += i;\n                                   }\n                             }\n                         Console.WriteLine(x);"; 
                    break;
                case 10:
                    pre= "*Una voz se escucha en toda la habitación*\n«La respuesta a los acertijos hasta ahora has acertado»\n«sin en cambio al final has llegado y salir es complicado»\n\n«El siguiente código contiene el error que has de hallar, si la salida de la torre deseas alcanzar\nSin trampas ni engaños, con lógica y voluntad, pues en cada reto mostraste tu habilidad\nAhora agudiza el juicio y observa cada señal, pues un error oculto bloquea la puerta final.»"; 
                    break;
            }
                    return pre;
        }
    }
}
