using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Retroalimentacion
    {
        public string Pre1()
        {
            return"Has elegido una opción que no es uno de los pilares \nde la Programación Orientada a Objetos." +
                "\nRecuerda: los pilares fundamentales son Encapsulamiento,\n Herencia, Polimorfismo y Abstracción.";
        }
        public string Pre2()
        {
            return"El operador == se usa para comparar valores, \nno para asignarlos. Para asignar un valor a una variable,\n se utiliza el signo =";
        }
        public string Pre3()
        {
            return"Las estructuras de control determinan el flujo\n de un programa. Las principales son:\n Secuencial (instrucción tras instrucción), Selectiva (if, switch) \ne Iterativa (for, while).\n Medita bien tu próxima elección.";
        }
        public string Pre4()
        {
            return"Una excepción ocurre durante la ejecución del programa,\n no durante la compilación ni por el lenguaje. " +
                "Piensa en errores lógicos como una división por cero o acceder a una posición inválida de un arreglo.";
        }
        public string Pre5()
        {
            return"Cuidado, la extensión correcta para archivos de C# es .cs. " +
                "\nLas otras corresponden a C++ (.cpp), Java (.java) y Python (.py). ¿Lo recuerdas ahora?";
        }
        public string Pre6()
        {
            return"Observa bien: hay un ciclo for dentro de otro for. Eso se llama un ciclo anidado. " +  
                " \nLos condicionales no están presentes aquí. Vuelve a intentarlo con más atención.";
              
        }
        public string Pre7()
        {
            return"Una clase no se compone de carpetas o bucles, sino de atributos, métodos y un posible constructor para inicializar. " +
                "Estas son las partes clave en la POO";
        }
        public string Pre8()
        {
            return"Los modificadores de acceso controlan la visibilidad de los miembros de una clase. " +
                "\nPúblico (public) es totalmente accesible, protegido (protected) accesible desde clases hijas, y privado (private) solo desde dentro. " +
                "\nNo los confundas con ámbitos de variables.";
        }
        public string Pre9()
        {
            return"Parece que olvidaste que solo se suman los números pares. " +
                "\nEl ciclo va de 1 a 10 y i % 2 == 0 filtra los pares. La suma total es 2 + 4 + 6 + 8 + 10 = ... " +
                "Analiza de nuevo.";
        }
        public string Pre10()
        {
            return"En programación, olvidar un ... puede evitar que el programa compile. " +
                "\nMira cuidadosamente cada línea: una instrucción Console.WriteLine está incompleta antes del bloque for. " +
                "Revísalo con detenimiento.";
        }
        
    }
}
