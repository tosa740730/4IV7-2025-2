using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcDifer.Logica
{
    internal static class Calculo
    {
        // --- UNIDAD 1: FUNCIONES Y LÍMITES ---
        public static string GetTeoriaUnidad1()
        {
            var sb = new StringBuilder();
            sb.AppendLine("FUNCIÓN:");
            sb.AppendLine("Una función es una regla que asigna a cada elemento de un conjunto de entrada (dominio), un único elemento de un conjunto de salida (rango).");
            sb.AppendLine();
            sb.AppendLine("LÍMITE:");
            sb.AppendLine("El concepto de límite describe el comportamiento de una función a medida que la variable de entrada se aproxima a un valor específico.");
            sb.AppendLine();
            sb.AppendLine("DESIGUALDADES:");
            sb.AppendLine("Resolver una desigualdad implica encontrar el conjunto de valores (intervalo) que satisfacen una comparación (>, <, ≥, ≤).");
            return sb.ToString();
        }

        public static string GetEjemploUnidad1_1()
        {
            return "Resolver la desigualdad:   x² + x < 2";
        }

        public static string GetProcedimientoUnidad1_1()
        {
            var sb = new StringBuilder();
            sb.AppendLine("1. Formular la desigualdad comparando con cero:");
            sb.AppendLine("   x² + x - 2 < 0");
            sb.AppendLine();
            sb.AppendLine("2. Factorizar la expresión para hallar los puntos críticos (raíces):");
            sb.AppendLine("   (x + 2)(x - 1) < 0");
            sb.AppendLine();
            sb.AppendLine("3. Encontrar los puntos críticos (donde cada factor es cero):");
            sb.AppendLine("   x + 2 = 0  =>  x = -2");
            sb.AppendLine("   x - 1 = 0  =>  x = 1");
            sb.AppendLine();
            sb.AppendLine("4. Usar los puntos críticos para dividir la recta numérica en intervalos:");
            sb.AppendLine("   (-∞, -2),   (-2, 1),   (1, ∞)");
            sb.AppendLine();
            sb.AppendLine("5. Evaluar un punto de prueba en cada intervalo en la desigualdad factorizada (x + 2)(x - 1) < 0:");
            sb.AppendLine("   - Intervalo (-∞, -2), prueba con x = -3:   (-3 + 2)(-3 - 1) = (-1)(-4) = 4.  (4 no es < 0, FALSO)");
            sb.AppendLine("   - Intervalo (-2, 1), prueba con x = 0:    (0 + 2)(0 - 1) = (2)(-1) = -2. (-2 es < 0, VERDADERO)");
            sb.AppendLine("   - Intervalo (1, ∞), prueba con x = 2:     (2 + 2)(2 - 1) = (4)(1) = 4.    (4 no es < 0, FALSO)");
            sb.AppendLine();
            sb.AppendLine("6. La solución es la unión de todos los intervalos que resultaron verdaderos.");
            return sb.ToString();
        }

        public static string GetSolucionUnidad1_1() => "x ∈ (-2, 1)";

        // --- UNIDAD 2: LA DERIVADA (REGLA DE LOS 4 PASOS) ---
        public static string GetTeoriaUnidad2()
        {
            var sb = new StringBuilder();
            sb.AppendLine("La derivada de una función en un punto representa la razón de cambio instantánea de la función en ese punto. Geométricamente, corresponde a la pendiente de la recta tangente a la curva en dicho punto.");
            sb.AppendLine();
            sb.AppendLine("REGLA DE LOS 4 PASOS (DERIVADA POR DEFINICIÓN):");
            sb.AppendLine("Este es el método fundamental basado en el concepto de límite para encontrar la derivada.");
            sb.AppendLine();
            sb.AppendLine("1. Plantear la función incrementada: y + Δy = f(x + Δx).");
            sb.AppendLine("2. Aislar el incremento Δy: Δy = f(x + Δx) - f(x).");
            sb.AppendLine("3. Calcular el cociente de incrementos: Δy/Δx = [f(x + Δx) - f(x)] / Δx.");
            sb.AppendLine("4. Aplicar el límite cuando Δx → 0: f'(x) = lim(Δx→0) [Δy/Δx]. El resultado es la función derivada.");
            return sb.ToString();
        }

        public static string GetEjemploUnidad2_1()
        {
            return "Derivar por la regla de los 4 pasos la función: f(x) = x³ - 1";
        }

        public static string GetProcedimientoUnidad2_1()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Función original: y = x³ - 1");
            sb.AppendLine();
            sb.AppendLine("1. Incrementar la función: y + Δy = (x + Δx)³ - 1");
            sb.AppendLine("   Desarrollando el binomio al cubo: (a+b)³ = a³ + 3a²b + 3ab² + b³");
            sb.AppendLine("   y + Δy = [x³ + 3x²(Δx) + 3x(Δx)² + (Δx)³] - 1");
            sb.AppendLine();
            sb.AppendLine("2. Aislar Δy (restando la función original y = x³ - 1):");
            sb.AppendLine("   Δy = [x³ + 3x²(Δx) + 3x(Δx)² + (Δx)³ - 1] - (x³ - 1)");
            sb.AppendLine("   Δy = x³ + 3x²Δx + 3x(Δx)² + (Δx)³ - 1 - x³ + 1");
            sb.AppendLine("   Δy = 3x²Δx + 3x(Δx)² + (Δx)³");
            sb.AppendLine();
            sb.AppendLine("3. Calcular el cociente Δy/Δx (dividir todo por Δx):");
            sb.AppendLine("   Δy/Δx = (3x²Δx + 3x(Δx)² + (Δx)³) / Δx");
            sb.AppendLine("   Δy/Δx = 3x² + 3xΔx + (Δx)²");
            sb.AppendLine();
            sb.AppendLine("4. Aplicar el límite cuando Δx → 0:");
            sb.AppendLine("   f'(x) = lim (Δx→0) [3x² + 3xΔx + (Δx)²]");
            sb.AppendLine("   f'(x) = 3x² + 3x(0) + (0)²");
            return sb.ToString();
        }

        public static string GetSolucionUnidad2_1() => "f'(x) = 3x²";


        // --- UNIDAD 3: DERIVADAS DE FUNCIONES ALGEBRAICAS ---
        public static string GetTeoriaUnidad3()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Esta unidad se enfoca en aplicar fórmulas para derivar funciones polinomiales y algebraicas. Se introducen conceptos como la derivación implícita y su aplicación para encontrar la recta tangente y normal a una curva.");
            sb.AppendLine();
            sb.AppendLine("DERIVACIÓN IMPLÍCITA:");
            sb.AppendLine("Se utiliza cuando en una ecuación la variable 'y' no está despejada. El procedimiento consiste en derivar ambos lados de la ecuación término a término con respecto a 'x', aplicando la regla de la cadena al derivar términos con 'y' (multiplicando por dy/dx), y finalmente despejar dy/dx.");
            sb.AppendLine();
            sb.AppendLine("RECTA TANGENTE Y NORMAL:");
            sb.AppendLine("- La pendiente de la recta tangente (mₜ) es el valor de la derivada f'(x) en el punto de tangencia.");
            sb.AppendLine("- La pendiente de la recta normal (mₙ) es la recíproca negativa de la tangente: mₙ = -1 / mₜ.");
            return sb.ToString();
        }

        public static string GetEjemploUnidad3_1()
        {
            return "Encontrar la ecuación de la recta tangente y normal a la curva y = x² - 4x + 9 en el punto A(1, 6).";
        }

        public static string GetProcedimientoUnidad3_1()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Función: f(x) = x² - 4x + 9");
            sb.AppendLine("Punto: P(x₀, y₀) = (1, 6)");
            sb.AppendLine();
            sb.AppendLine("1. Calcular la derivada de la función (f'(x)):");
            sb.AppendLine("   f'(x) = 2x - 4");
            sb.AppendLine();
            sb.AppendLine("2. Evaluar la derivada en x₀ = 1 para encontrar la pendiente de la recta tangente (mₜ):");
            sb.AppendLine("   mₜ = f'(1) = 2(1) - 4 = -2");
            sb.AppendLine();
            sb.AppendLine("3. Usar la forma punto-pendiente para la ecuación de la RECTA TANGENTE: y - y₀ = mₜ(x - x₀)");
            sb.AppendLine("   y - 6 = -2(x - 1)");
            sb.AppendLine("   y - 6 = -2x + 2");
            sb.AppendLine("   2x + y - 8 = 0");
            sb.AppendLine();
            sb.AppendLine("4. Calcular la pendiente de la recta normal (mₙ):");
            sb.AppendLine("   mₙ = -1 / mₜ = -1 / (-2) = 1/2");
            sb.AppendLine();
            sb.AppendLine("5. Usar la forma punto-pendiente para la ecuación de la RECTA NORMAL: y - y₀ = mₙ(x - x₀)");
            sb.AppendLine("   y - 6 = (1/2)(x - 1)");
            sb.AppendLine("   2(y - 6) = 1(x - 1)");
            sb.AppendLine("   2y - 12 = x - 1");
            sb.AppendLine("   x - 2y + 11 = 0");
            return sb.ToString();
        }

        public static string GetSolucionUnidad3_1() => "Recta Tangente: 2x + y - 8 = 0\nRecta Normal: x - 2y + 11 = 0";


        // --- UNIDAD 4: APLICACIONES DE LA DERIVADA ---
        public static string GetTeoriaUnidad4()
        {
            var sb = new StringBuilder();
            sb.AppendLine("La primera y segunda derivada son herramientas poderosas para analizar el comportamiento de una función y resolver problemas de optimización (encontrar máximos y mínimos).");
            sb.AppendLine();
            sb.AppendLine("CRITERIO DE LA SEGUNDA DERIVADA PARA ENCONTRAR MÁXIMOS Y MÍNIMOS:");
            sb.AppendLine("1. Calcular la primera derivada, f'(x).");
            sb.AppendLine("2. Encontrar los puntos críticos resolviendo la ecuación f'(x) = 0.");
            sb.AppendLine("3. Calcular la segunda derivada, f''(x).");
            sb.AppendLine("4. Evaluar f''(x) en cada punto crítico 'c':");
            sb.AppendLine("   - Si f''(c) > 0, existe un MÍNIMO relativo en x=c.");
            sb.AppendLine("   - Si f''(c) < 0, existe un MÁXIMO relativo en x=c.");
            sb.AppendLine("   - Si f''(c) = 0, el criterio no decide.");
            sb.AppendLine("5. Obtener la coordenada 'y' evaluando la función original f(x) en los puntos críticos.");
            return sb.ToString();
        }

        public static string GetEjemploUnidad4_1()
        {
            return "Analizar la función y encontrar sus máximos y mínimos: y = 2x³ - 3x² - 36x + 24";
        }

        public static string GetProcedimientoUnidad4_1()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Función: f(x) = 2x³ - 3x² - 36x + 24");
            sb.AppendLine();
            sb.AppendLine("1. Calcular la primera derivada (f'(x)):");
            sb.AppendLine("   f'(x) = 6x² - 6x - 36");
            sb.AppendLine();
            sb.AppendLine("2. Encontrar puntos críticos (igualar f'(x) a 0):");
            sb.AppendLine("   6x² - 6x - 36 = 0");
            sb.AppendLine("   Dividiendo entre 6: x² - x - 6 = 0");
            sb.AppendLine("   Factorizando: (x - 3)(x + 2) = 0");
            sb.AppendLine("   Puntos críticos: x₁ = 3, x₂ = -2");
            sb.AppendLine();
            sb.AppendLine("3. Calcular la segunda derivada (f''(x)):");
            sb.AppendLine("   f''(x) = 12x - 6");
            sb.AppendLine();
            sb.AppendLine("4. Evaluar la segunda derivada en los puntos críticos:");
            sb.AppendLine("   Para x = 3: f''(3) = 12(3) - 6 = 36 - 6 = 30.");
            sb.AppendLine("      Como 30 > 0, en x=3 hay un MÍNIMO relativo.");
            sb.AppendLine("   Para x = -2: f''(-2) = 12(-2) - 6 = -24 - 6 = -30.");
            sb.AppendLine("      Como -30 < 0, en x=-2 hay un MÁXIMO relativo.");
            sb.AppendLine();
            sb.AppendLine("5. Encontrar las coordenadas (x, y) de los puntos:");
            sb.AppendLine("   Punto Mínimo (x=3): y = 2(3)³ - 3(3)² - 36(3) + 24 = 54 - 27 - 108 + 24 = -57");
            sb.AppendLine("   Punto Máximo (x=-2): y = 2(-2)³ - 3(-2)² - 36(-2) + 24 = -16 - 12 + 72 + 24 = 68");
            return sb.ToString();
        }

        public static string GetSolucionUnidad4_1() => "Punto Máximo: (-2, 68)\nPunto Mínimo: (3, -57)";

        // --- UNIDAD 5: DERIVADAS DE FUNCIONES EXPONENCIALES Y LOGARÍTMICAS ---
        public static string GetTeoriaUnidad5()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Esta sección cubre la derivación de funciones donde la variable independiente aparece en el exponente o como argumento de un logaritmo. La regla de la cadena es esencial en estos casos.");
            sb.AppendLine();
            sb.AppendLine("FÓRMULAS FUNDAMENTALES (donde u es una función de x, u=g(x)):");
            sb.AppendLine("• d/dx(eᵘ) = eᵘ * u'");
            sb.AppendLine("• d/dx(aᵘ) = (aᵘ * ln(a)) * u'");
            sb.AppendLine("• d/dx(ln u) = u' / u");
            return sb.ToString();
        }

        public static string GetEjemploUnidad5_1()
        {
            return "Derivar la función: y = x² * e³ˣ";
        }

        public static string GetProcedimientoUnidad5_1()
        {
            var sb = new StringBuilder();
            sb.AppendLine("1. Identificar que es una Regla del Producto (u*v):");
            sb.AppendLine("   u = x²");
            sb.AppendLine("   v = e³ˣ");
            sb.AppendLine();
            sb.AppendLine("2. Derivar u y v por separado:");
            sb.AppendLine("   u' = d/dx(x²) = 2x");
            sb.AppendLine("   Para v', usamos la regla de la cadena para eᵘ con u_inner = 3x:");
            sb.AppendLine("   v' = d/dx(e³ˣ) = e³ˣ * (derivada de 3x) = e³ˣ * 3 = 3e³ˣ");
            sb.AppendLine();
            sb.AppendLine("3. Aplicar la fórmula de la Regla del Producto: y' = u'v + uv'");
            sb.AppendLine("   y' = (2x)(e³ˣ) + (x²)(3e³ˣ)");
            sb.AppendLine();
            sb.AppendLine("4. Simplificar sacando factor común (xe³ˣ):");
            sb.AppendLine("   y' = xe³ˣ(2 + 3x)");
            return sb.ToString();
        }

        public static string GetSolucionUnidad5_1() => "y' = x * e³ˣ * (3x + 2)";

        // --- UNIDAD 6: DERIVADAS DE FUNCIONES TRIGONOMÉTRICAS ---
        public static string GetTeoriaUnidad6()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Se estudian las fórmulas para encontrar la derivada de las seis funciones trigonométricas básicas (seno, coseno, tangente, etc.), usualmente en combinación con la regla de la cadena para argumentos complejos.");
            sb.AppendLine();
            sb.AppendLine("FÓRMULAS FUNDAMENTALES (con u = g(x)):");
            sb.AppendLine("• d/dx(sen u) = (cos u) * u'");
            sb.AppendLine("• d/dx(cos u) = -(sen u) * u'");
            sb.AppendLine("• d/dx(tan u) = (sec² u) * u'");
            sb.AppendLine("• d/dx(cot u) = -(csc² u) * u'");
            sb.AppendLine("• d/dx(sec u) = (sec u * tan u) * u'");
            sb.AppendLine("• d/dx(csc u) = -(csc u * cot u) * u'");
            return sb.ToString();
        }

        public static string GetEjemploUnidad6_1()
        {
            return "Derivar la función: y = sen(2x)cos(3x)";
        }

        public static string GetProcedimientoUnidad6_1()
        {
            var sb = new StringBuilder();
            sb.AppendLine("1. Identificar que es una Regla del Producto (u*v):");
            sb.AppendLine("   u = sen(2x)");
            sb.AppendLine("   v = cos(3x)");
            sb.AppendLine();
            sb.AppendLine("2. Derivar u y v por separado (usando regla de la cadena):");
            sb.AppendLine("   u' = d/dx(sen(2x)) = cos(2x) * (derivada de 2x) = 2cos(2x)");
            sb.AppendLine("   v' = d/dx(cos(3x)) = -sen(3x) * (derivada de 3x) = -3sen(3x)");
            sb.AppendLine();
            sb.AppendLine("3. Aplicar fórmula del producto y' = u'v + uv':");
            sb.AppendLine("   y' = (2cos(2x))(cos(3x)) + (sen(2x))(-3sen(3x))");
            sb.AppendLine();
            sb.AppendLine("4. Simplificar:");
            sb.AppendLine("   y' = 2cos(2x)cos(3x) - 3sen(2x)sen(3x)");
            return sb.ToString();
        }

        public static string GetSolucionUnidad6_1() => "y' = 2cos(2x)cos(3x) - 3sen(2x)sen(3x)";

        // --- UNIDAD 7: DIFERENCIALES Y CÁLCULOS APROXIMADOS ---
        public static string GetTeoriaUnidad7()
        {
            var sb = new StringBuilder();
            sb.AppendLine("La diferencial de una función es una aproximación lineal del cambio en la función cerca de un punto. Mientras que Δy representa el cambio real en la curva, la diferencial 'dy' representa el cambio a lo largo de la recta tangente.");
            sb.AppendLine();
            sb.AppendLine("CÁLCULO DE LA DIFERENCIAL:");
            sb.AppendLine("La diferencial de una función y = f(x) se define como el producto de su derivada y la diferencial de la variable independiente dx.");
            sb.AppendLine();
            sb.AppendLine("1. Dada y = f(x).");
            sb.AppendLine("2. Calcular la derivada f'(x).");
            sb.AppendLine("3. La diferencial es: dy = f'(x) dx");
            return sb.ToString();
        }

        public static string GetEjemploUnidad7_1()
        {
            return "Calcular la diferencial de: y = (3x+2)(x²-5x+6)";
        }

        public static string GetProcedimientoUnidad7_1()
        {
            var sb = new StringBuilder();
            sb.AppendLine("1. Calcular la derivada f'(x). Primero, expandimos el producto para simplificar:");
            sb.AppendLine("   y = 3x(x²-5x+6) + 2(x²-5x+6)");
            sb.AppendLine("   y = 3x³ - 15x² + 18x + 2x² - 10x + 12");
            sb.AppendLine("   y = 3x³ - 13x² + 8x + 12");
            sb.AppendLine();
            sb.AppendLine("2. Ahora derivamos la función simplificada:");
            sb.AppendLine("   f'(x) = 9x² - 26x + 8");
            sb.AppendLine();
            sb.AppendLine("3. La diferencial es dy = f'(x)dx:");
            sb.AppendLine("   dy = (9x² - 26x + 8) dx");
            return sb.ToString();
        }

        public static string GetSolucionUnidad7_1() => "dy = (9x² - 26x + 8) dx";
    }
}
