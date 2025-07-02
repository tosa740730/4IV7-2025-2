namespace ProyectoFisica
{
    public partial class GuiaFisica : Form
    {
        private MenuStrip barraMenu;
        private Panel panelContenido;
        private Label etiquetaContenido;
        private PictureBox imagenGrafico;

        private void MostrarVideosEducativos()
        {
            etiquetaContenido.Text = "VIDEOS EDUCATIVOS:\n\nSelecciona un tema para ver el video correspondiente.";
            imagenGrafico.Image = null;

            // Eliminar botones anteriores relacionados con videos
            var botonesAEliminar = new List<Control>();
            foreach (Control control in panelContenido.Controls)
            {
                if (control is Button btn && btn.Text.StartsWith("Video sobre"))
                {
                    botonesAEliminar.Add(btn);
                }
            }
            foreach (var btn in botonesAEliminar)
            {
                panelContenido.Controls.Remove(btn);
            }

            // Posicionar los botones justo debajo del texto
            int y = etiquetaContenido.Bottom + 20;

            var videos = new (string texto, string url)[]
            {
        ("Video sobre calor", "https://www.youtube.com/watch?v=3C6uci3WGtY"),
        ("Video sobre termodinámica", "https://www.youtube.com/watch?v=Bvfn6eUhUAc"),
        ("Video sobre sonido", "https://youtu.be/F7r9JK-5ko0"),
        ("Video sobre ondas", "https://youtu.be/0EPA36B6PTQ")
            };

            foreach (var (texto, url) in videos)
            {
                Button boton = new Button();
                boton.Text = texto;
                boton.Location = new Point(10, y);
                boton.Size = new Size(300, 40);
                boton.Click += (s, e) =>
                {
                    var psi = new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = url,
                        UseShellExecute = true
                    };
                    System.Diagnostics.Process.Start(psi);
                };
                panelContenido.Controls.Add(boton);
                y += 50;
            }
        }



        public GuiaFisica()
        {
            InicializarComponentes();
            AgregarExamenAlMenu();
        }

        private void InicializarComponentes()
        {
            barraMenu = new MenuStrip();
            panelContenido = new Panel();
            etiquetaContenido = new Label();
            imagenGrafico = new PictureBox();


            this.Text = "Guía de Estudio de Física II";
            this.Size = new Size(900, 750);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

            barraMenu.Dock = DockStyle.Top;
            barraMenu.BackColor = Color.LightSteelBlue;
            barraMenu.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            barraMenu.Items.Add(CrearMenu("Calor y Termodinámica", new (string, EventHandler)[]
            {
                ("Calor", (s, e) => MostrarContenido(ContenidoCalor(), "heat_transfer.png")),
                ("Termodinámica", (s, e) => MostrarContenido(ContenidoTermodinamica(), "thermodynamics_laws.png"))
            }));

            barraMenu.Items.Add(CrearElementoMenu("Ondas", (s, e) => MostrarContenido(ContenidoOndas(), "waves.png")));
            barraMenu.Items.Add(CrearElementoMenu("Sonido", (s, e) => MostrarContenido(ContenidoSonido(), "sound_intensity.png")));

            panelContenido.Dock = DockStyle.Fill;
            panelContenido.AutoScroll = true;
            panelContenido.BackColor = Color.WhiteSmoke;

            etiquetaContenido.Font = new Font("Segoe UI", 10);
            etiquetaContenido.Padding = new Padding(10);
            etiquetaContenido.AutoSize = true;

            imagenGrafico.Location = new Point(50, 1299);
            imagenGrafico.Size = new Size(850, 300);
            imagenGrafico.SizeMode = PictureBoxSizeMode.Zoom;
            imagenGrafico.BorderStyle = BorderStyle.FixedSingle;

            panelContenido.Controls.Add(etiquetaContenido);
            panelContenido.Controls.Add(imagenGrafico);
            this.Controls.Add(panelContenido);
            this.Controls.Add(barraMenu);
            this.MainMenuStrip = barraMenu;

            imagenGrafico.Location = new Point(10, 700);
            imagenGrafico.Size = new Size(850, 400);
            imagenGrafico.SizeMode = PictureBoxSizeMode.Zoom;
            imagenGrafico.BorderStyle = BorderStyle.FixedSingle;
            panelContenido.Controls.Add(etiquetaContenido);
            panelContenido.Controls.Add(imagenGrafico);

            barraMenu.Items.Add(CrearElementoMenu("Videos educativos", (s, e) => MostrarVideosEducativos()));







        }

        private ToolStripMenuItem CrearMenu(string titulo, (string, EventHandler)[] subelementos)
        {
            var menu = new ToolStripMenuItem(titulo);
            foreach (var (texto, accion) in subelementos)
                menu.DropDownItems.Add(CrearElementoMenu(texto, accion));
            return menu;
        }

        private ToolStripMenuItem CrearElementoMenu(string texto, EventHandler accion)
        {
            var item = new ToolStripMenuItem(texto);
            item.Click += accion;
            return item;
        }

        private void MostrarContenido(string contenido, string rutaImagen = null)
        {
            etiquetaContenido.Text = contenido;
            if (!string.IsNullOrEmpty(rutaImagen) && System.IO.File.Exists(rutaImagen))
                imagenGrafico.Image = Image.FromFile(rutaImagen);
            else
                imagenGrafico.Image = null;

            etiquetaContenido.Text = contenido;
            if (!string.IsNullOrEmpty(rutaImagen) && System.IO.File.Exists(rutaImagen))
                imagenGrafico.Image = Image.FromFile(rutaImagen);
            else
                imagenGrafico.Image = null;

            // Eliminar botón anterior si ya existe
            foreach (Control control in panelContenido.Controls)
            {
                if (control is Button && ((Button)control).Text == "Ver video de calor")
                {
                    panelContenido.Controls.Remove(control);
                    break;
                }
            }

            // Mostrar botón solo si es el tema de calor
            if (rutaImagen == "heat_transfer.png")
            {
                Button botonVideo = new Button();
                botonVideo.Text = "Ver video de calor";
                botonVideo.Location = new Point(10, 1020);
                botonVideo.Size = new Size(300, 40);
                botonVideo.Click += (s, e) =>
                {
                    var psi = new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = "https://www.youtube.com/watch?v=3C6uci3WGtY",
                        UseShellExecute = true
                    };
                    System.Diagnostics.Process.Start(psi);
                };
                panelContenido.Controls.Add(botonVideo);
            }

        }

        private string ContenidoCalor() =>
            "CALOR:\n\n" +
            "Teoría:\n" +
            "El calor es una forma de energía que se transfiere entre cuerpos debido a una diferencia de temperatura. " +
            "No es una sustancia, sino un proceso de transferencia energética. Se mide en julios (J) o calorías (cal).\n\n" +
            "Formas de transferencia:\n" +
            "- Conducción: transferencia directa entre moléculas en contacto.\n" +
            "- Convección: transporte de calor por movimiento de fluidos.\n" +
            "- Radiación: emisión de energía en forma de ondas electromagnéticas, sin necesidad de medio.\n\n" +
            "Calor específico:\n" +
            "Cantidad de calor necesaria para elevar 1°C la temperatura de 1 gramo de una sustancia.\n" +
            "Ejemplo: el agua tiene un calor específico de 4.18 J/g°C.\n\n" +
            "Capacidad calorífica:\n" +
            "Cantidad de calor necesaria para elevar la temperatura de un cuerpo completo en 1°C.\n\n" +
            "Fórmula general:\n" +
            "Q = m · c · ΔT\n" +
            "Donde:\n" +
            "- Q: calor (J)\n" +
            "- m: masa (g)\n" +
            "- c: calor específico (J/g°C)\n" +
            "- ΔT: cambio de temperatura (°C)\n\n" +
            "Ejemplo práctico:\n" +
            "Calcular el calor necesario para calentar 2 kg de hierro (c = 0.45 J/g°C) de 25°C a 100°C.\n" +
            "Paso 1: Convertir masa a gramos → 2 kg = 2000 g\n" +
            "Paso 2: ΔT = 100 - 25 = 75°C\n" +
            "Paso 3: Q = 2000 · 0.45 · 75 = 67,500 J\n\n" +
            "Ejercicio resuelto:\n" +
            "Calcular el calor necesario para calentar 500g de agua de 20°C a 80°C.\n" +
            "Paso 1: Datos → m = 500g, c = 4.18 J/g°C, ΔT = 60°C\n" +
            "Paso 2: Q = 500 · 4.18 · 60 = 125,400 J\n";

        private string ContenidoTermodinamica() =>
            "TERMODINÁMICA:\n\n" +
            "Teoría:\n" +
            "La termodinámica es la rama de la física que estudia las transformaciones de la energía, especialmente el calor y el trabajo, y su relación con la energía interna de los sistemas.\n\n" +
            "Ley Cero:\n" +
            "Si dos sistemas están en equilibrio térmico con un tercero, entonces están en equilibrio térmico entre sí.\n\n" +
            "Primera Ley:\n" +
            "Ley de conservación de la energía: la energía interna de un sistema cambia por el calor que recibe y el trabajo que realiza.\n" +
            "Fórmula: ΔU = Q - W\n" +
            "- ΔU: cambio en energía interna\n" +
            "- Q: calor recibido\n" +
            "- W: trabajo realizado por el sistema\n\n" +
            "Segunda Ley:\n" +
            "La entropía del universo tiende a aumentar. No todo el calor puede transformarse en trabajo útil.\n\n" +
            "Tercera Ley:\n" +
            "La entropía de un cristal perfecto es cero cuando la temperatura se aproxima al cero absoluto (0 K).\n\n" +
            "Procesos termodinámicos:\n" +
            "- Isotérmico: temperatura constante (ΔU = 0)\n" +
            "- Isobárico: presión constante\n" +
            "- Isochorico: volumen constante (W = 0)\n" +
            "- Adiabático: sin intercambio de calor (Q = 0)\n\n" +
            "Ejemplo práctico:\n" +
            "Un gas ideal se expande isotérmicamente de 1 L a 3 L a 300 K. ¿Cuál es el trabajo realizado?\n" +
            "W = nRT ln(Vf/Vi)\n" +
            "Si n = 1 mol, R = 8.314 J/mol·K:\n" +
            "W = 1 · 8.314 · 300 · ln(3/1) ≈ 2731 J\n\n" +
            "Ejercicio resuelto:\n" +
            "Un gas recibe 300 J de calor y realiza 100 J de trabajo. ¿Cuál es el cambio en su energía interna?\n" +
            "Paso 1: Datos → Q = 300 J, W = 100 J\n" +
            "Paso 2: ΔU = Q - W = 300 - 100 = 200 J\n";

        private string ContenidoOndas() =>
            "ONDAS:\n\n" +
            "Teoría:\n" +
            "Una onda es una perturbación que se propaga a través de un medio o del vacío, transportando energía sin transportar materia.\n\n" +
            "Tipos de ondas:\n" +
            "- Mecánicas: requieren un medio para propagarse (ej. sonido, ondas en agua).\n" +
            "- Electromagnéticas: no requieren medio (ej. luz, microondas, rayos X).\n" +
            "- Gravitacionales: deformaciones del espacio-tiempo predichas por la relatividad general.\n\n" +
            "Clasificación según dirección:\n" +
            "- Transversales: la perturbación es perpendicular a la dirección de propagación (ej. luz).\n" +
            "- Longitudinales: la perturbación es paralela a la dirección de propagación (ej. sonido).\n\n" +
            "Parámetros de una onda:\n" +
            "- Amplitud (A): altura máxima desde el punto de equilibrio.\n" +
            "- Frecuencia (f): número de ciclos por segundo (Hz).\n" +
            "- Longitud de onda (λ): distancia entre dos puntos equivalentes consecutivos.\n" +
            "- Velocidad de propagación (v): v = λ · f\n" +
            "- Periodo (T): tiempo que tarda una onda en completar un ciclo (T = 1/f)\n\n" +
            "Ondas estacionarias:\n" +
            "Se forman por la superposición de dos ondas de igual frecuencia y amplitud que se propagan en direcciones opuestas.\n" +
            "Presentan nodos (sin movimiento) y antinodos (máxima amplitud).\n\n" +
            "Ejemplo práctico:\n" +
            "Una onda tiene una longitud de onda de 2 m y se propaga a 340 m/s. ¿Cuál es su frecuencia?\n" +
            "f = v / λ = 340 / 2 = 170 Hz\n\n" +
            "Ejercicio resuelto:\n" +
            "Una onda tiene λ = 0.5 m y f = 60 Hz. ¿Cuál es su velocidad?\n" +
            "Paso 1: Fórmula → v = λ · f\n" +
            "Paso 2: Sustituir → v = 0.5 · 60 = 30 m/s\n";

        private string ContenidoSonido() =>
            "SONIDO:\n\n" +
            "Teoría:\n" +
            "El sonido es una onda mecánica longitudinal que se propaga a través de un medio material. " +
            "Se genera por la vibración de un cuerpo y se transmite mediante la compresión y rarefacción de las partículas del medio.\n\n" +
            "Características del sonido:\n" +
            "- Tono: depende de la frecuencia. Sonidos agudos tienen alta frecuencia.\n" +
            "- Timbre: permite distinguir dos sonidos con la misma frecuencia e intensidad.\n" +
            "- Intensidad: relacionada con la amplitud. Se mide en decibelios (dB).\n" +
            "- Duración: tiempo que persiste el sonido.\n\n" +
            "Velocidad del sonido:\n" +
            "- Aire (20°C): ~343 m/s\n" +
            "- Agua: ~1500 m/s\n" +
            "- Acero: ~5000 m/s\n" +
            "La velocidad depende de la densidad y elasticidad del medio.\n\n" +
            "Efecto Doppler:\n" +
            "Cambio aparente en la frecuencia del sonido debido al movimiento relativo entre la fuente y el receptor.\n" +
            "Si la fuente se acerca, la frecuencia percibida aumenta; si se aleja, disminuye.\n\n" +
            "Ejemplo práctico:\n" +
            "Calcular la intensidad del sonido a 10 m de una fuente de 0.1 W:\n" +
            "I = P / (4πr²) = 0.1 / (4π · 100) ≈ 7.96 × 10⁻⁵ W/m²\n\n" +
            "Ejercicio resuelto:\n" +
            "Una fuente sonora emite 500 Hz y se acerca al oyente a 30 m/s. ¿Qué frecuencia se percibe?\n" +
            "Paso 1: Fórmula → f' = f · (v + vo)/(v - vs)\n" +
            "Paso 2: Sustituir → f' = 500 · (343)/(343 - 30) ≈ 546 Hz\n";

        public void AgregarExamenAlMenu()
        {
            var examenMenu = new ToolStripMenuItem("Examen");
            examenMenu.Click += (s, e) => IniciarExamen();
            barraMenu.Items.Add(examenMenu);
        }

        private void IniciarExamen()
        {
            var examenForm = new FormularioExamen();
            examenForm.ShowDialog();
        }
    }

    public class FormularioExamen : Form
    {
        private Label preguntaLabel;
        private RadioButton[] opciones;
        private Button siguienteButton;
        private int preguntaActual;
        private string[] preguntas;
        private string[][] opcionesPreguntas;
        private int[] respuestasCorrectas;
        private string[] explicaciones;

        public FormularioExamen()
        {
            InicializarComponentes();
            CargarPreguntas();
            MostrarPregunta();
        }

        private void InicializarComponentes()
        {
            this.Text = "Examen de Física II";
            this.Size = new Size(600, 400);
            this.StartPosition = FormStartPosition.CenterScreen;

            preguntaLabel = new Label();
            preguntaLabel.Font = new Font("Segoe UI", 12);
            preguntaLabel.Location = new Point(20, 20);
            preguntaLabel.Size = new Size(550, 60);

            opciones = new RadioButton[4];
            for (int i = 0; i < opciones.Length; i++)
            {
                opciones[i] = new RadioButton();
                opciones[i].Font = new Font("Segoe UI", 10);
                opciones[i].Location = new Point(20, 100 + i * 30);
                opciones[i].Size = new Size(550, 30);
                this.Controls.Add(opciones[i]);
            }

            siguienteButton = new Button();
            siguienteButton.Text = "Siguiente";
            siguienteButton.Font = new Font("Segoe UI", 10);
            siguienteButton.Location = new Point(450, 300);
            siguienteButton.Click += (s, e) => VerificarRespuesta();
            this.Controls.Add(siguienteButton);

            this.Controls.Add(preguntaLabel);
        }

        private void CargarPreguntas()
        {
            preguntas = new string[]

            {
                "¿Cuál es la fórmula del calor específico?",
                "¿Qué establece la primera ley de la termodinámica?",
                "¿Qué tipo de onda es la luz?",
                "¿Cuál es la velocidad del sonido en el aire a 20°C?",
                "¿Cuál es la fórmula de la energía cinética?",
                "¿Qué es la entropía?",
                "¿Qué tipo de onda es el sonido?",
                "¿Cuál es la velocidad de la luz en el vacío?",
                "¿Cuánto calor se necesita para calentar 250 g de agua de 20°C a 80°C? (c = 4.18 J/g°C)",
                "Un gas recibe 500 J de calor y realiza 200 J de trabajo. ¿Cuál es el cambio en su energía interna?",
                "Una onda tiene una longitud de onda de 0.4 m y una frecuencia de 50 Hz. ¿Cuál es su velocidad?",
                "Una fuente sonora emite 0.2 W de potencia. ¿Cuál es la intensidad a 5 m de distancia?",
                "¿Qué cantidad de calor se requiere para elevar la temperatura de 1.5 kg de cobre (c = 0.385 J/g°C) de 20°C a 100°C?",
                "Un sistema realiza 150 J de trabajo y su energía interna aumenta en 100 J. ¿Cuánto calor recibió?",
                "Una onda tiene una frecuencia de 120 Hz y se propaga a 360 m/s. ¿Cuál es su longitud de onda?",
                "Una onda tiene una frecuencia de 120 Hz y se propaga a 360 m/s. ¿Cuál es su longitud de onda?",
                "Una fuente sonora se aleja del oyente a 20 m/s. Si emite un sonido de 600 Hz, ¿qué frecuencia percibe el oyente? (v = 343 m/s)",
                "Se suministran 10,000 J a un bloque de 2 kg de aluminio (c = 0.897 J/g°C). ¿Cuál es el aumento de temperatura?",
                "Un bloque de cobre caliente (c = 0.385 J/g°C, m = 500 g, T = 150°C) se sumerge en 1 kg de agua a 25°C. ¿Temperatura final? (sin pérdidas)",
                "Un gas ideal realiza un ciclo cerrado donde absorbe 600 J y libera 400 J. ¿Cuál fue el trabajo neto?",
                "Un gas se expande adiabáticamente y su temperatura baja de 400 K a 300 K. Si Cv = 20 J/mol·K, ¿cuánto cambia su energía interna? (n = 2 mol)",
                "Una onda viaja por una cuerda con v = 250 m/s y λ = 0.5 m. ¿Cuántos ciclos completa en 10 segundos?",
                "Una onda estacionaria en una cuerda tiene 5 nodos y mide 2 m. ¿Cuál es la frecuencia si v = 100 m/s?",
                "Una fuente sonora emite 0.5 W. ¿Cuál es la intensidad a 2 m? ¿Y a 4 m?",
                "Un coche se aleja a 30 m/s y emite 700 Hz. ¿Qué frecuencia percibe un observador en reposo? (v = 343 m/s)"


            };

            opcionesPreguntas = new string[][]
            {
                new string[] { "Q = m · c · ΔT", "E = m · c²", "F = m · a", "P = F / A" },
                new string[] { "La energía no se crea ni se destruye, solo se transforma", "La entropía del universo tiende a aumentar", "La energía interna de un cristal perfecto es cero a 0 K", "La energía interna de un sistema cambia por el calor recibido y el trabajo realizado" },
                new string[] { "Mecánica", "Electromagnética", "Gravitacional", "Longitudinal" },
                new string[] { "~343 m/s", "~1500 m/s", "~5000 m/s", "~299,792 km/s" },
                new string[] { "E = 1/2 · m · v²", "E = m · g · h", "E = m · c²", "E = F · d" },
                new string[] { "Una medida del desorden de un sistema", "La capacidad de realizar trabajo", "La cantidad de calor en un sistema", "La energía total de un sistema" },
                new string[] { "Transversal", "Electromagnética", "Longitudinal", "Gravitacional" },
                new string[] { "~300,000 km/s", "~150,000 km/s", "~343 m/s", "~299,792 km/s" },
                new string[] { "Q = 62,700 J", "Q = 104,500 J", "Q = 50,160 J", "Q = 75,240 J" },
                new string[] { "ΔU = 300 J", "ΔU = 700 J", "ΔU = 100 J", "ΔU = 200 J" },
                new string[] { "v = 20 m/s", "v = 200 m/s", "v = 25 m/s", "v = 0.8 m/s" },
                new string[] { "I ≈ 6.37×10⁻³ W/m²", "I ≈ 3.18×10⁻² W/m²", "I ≈ 1.27×10⁻² W/m²", "I ≈ 5.09×10⁻³ W/m²" },
                new string[] { "Q = 46,200 J", "Q = 38,500 J", "Q = 48,510 J", "Q = 30,000 J" },
                new string[] { "Q = 250 J", "Q = 50 J", "Q = -50 J", "Q = 100 J" },
                new string[] { "λ = 3 m", "λ = 0.33 m", "λ = 30 m", "λ = 43200 m" },
                new string[] { "f' ≈ 566 Hz", "f' ≈ 600 Hz", "f' ≈ 635 Hz", "f' ≈ 580 Hz" },
                new string[] { "ΔT ≈ 5.6°C", "ΔT ≈ 12.3°C", "ΔT ≈ 18.6°C", "ΔT ≈ 25.1°C" },
                new string[] { "Tf ≈ 30°C", "Tf ≈ 35°C", "Tf ≈ 40°C", "Tf ≈ 45°C" },
                new string[] { "W = 200 J", "W = -200 J", "W = 100 J", "W = -100 J" },
                new string[] { "ΔU = -4000 J", "ΔU = -2000 J", "ΔU = -1000 J", "ΔU = -800 J" },
                new string[] { "5000 ciclos", "2500 ciclos", "1250 ciclos", "1000 ciclos" },
                new string[] { "f = 125 Hz", "f = 100 Hz", "f = 150 Hz", "f = 200 Hz" },
                new string[] { "I₂ = 0.01, I₄ = 0.0025 W/m²", "I₂ = 0.02, I₄ = 0.01 W/m²", "I₂ = 0.005, I₄ = 0.00125 W/m²", "I₂ = 0.04, I₄ = 0.01 W/m²" },
                new string[] { "f' ≈ 638 Hz", "f' ≈ 660 Hz", "f' ≈ 700 Hz", "f' ≈ 720 Hz" }

            };

            respuestasCorrectas = new int[] { 0, 3, 1, 0, 0, 0, 2, 3, 0, 0, 0, 2, 2, 0, 0, 0, 2, 1, 0, 0, 0, 0, 0, 0 };





            explicaciones = new string[]
            {
                "La fórmula del calor específico es Q = m · c · ΔT, donde Q es el calor, m es la masa, c es el calor específico y ΔT es el cambio de temperatura.",
                "La primera ley de la termodinámica establece que la energía interna de un sistema cambia por el calor recibido y el trabajo realizado.",
                "La luz es una onda electromagnética.",
                "La velocidad del sonido en el aire a 20°C es aproximadamente 343 m/s.",
                "La fórmula de la energía cinética es E = 1/2 · m · v², donde E es la energía cinética, m es la masa y v es la velocidad.",
                "La entropía es una medida del desorden de un sistema.",
                "El sonido es una onda longitudinal.",
                "La velocidad de la luz en el vacío es aproximadamente 299,792 km/s.",
                "Q = m·c·ΔT = 250·4.18·60 = 62,700 J. Se requiere esa cantidad de calor para elevar la temperatura.",
                "ΔU = Q - W = 500 - 200 = 300 J. Es el cambio en la energía interna del gas.",
                "v = λ·f = 0.4·50 = 20 m/s. La velocidad de propagación de la onda es 20 m/s.",
                "I = P / (4πr²) = 0.2 / (4π·25) ≈ 1.27×10⁻² W/m². Esa es la intensidad del sonido a esa distancia.",
                "Q = m·c·ΔT = 1500·0.385·80 = 48,510 J. Esa es la cantidad de calor necesaria.",
                "ΔU = Q - W → Q = ΔU + W = 100 + 150 = 250 J. El sistema recibió 250 J de calor.",
                "λ = v / f = 360 / 120 = 3 m. Esa es la longitud de onda.",
                "f' = f · v / (v + vs) = 600 · 343 / (343 + 20) ≈ 566 Hz. La frecuencia percibida disminuye.",
                "Q = m·c·ΔT → ΔT = Q / (m·c) = 10000 / (2000·0.897) ≈ 18.6°C.",
                "Qcedido = Qabsorbido → 500·0.385·(150 - Tf) = 1000·4.18·(Tf - 25) → Tf ≈ 35°C.",
                "En un ciclo cerrado: ΔU = 0 → W = Qneto = 600 - 400 = 200 J.",
                "ΔU = n·Cv·ΔT = 2·20·(300 - 400) = -4000 J. La energía interna disminuye.",
                "f = v / λ = 250 / 0.5 = 500 Hz → ciclos = f·t = 500·10 = 5000 ciclos.",
                "5 nodos = 2 longitudes de onda → λ = 1 m → f = v / λ = 100 / 1 = 100 Hz.",
                "I = P / (4πr²) → I₂ = 0.5 / (4π·4) ≈ 0.01, I₄ = 0.5 / (4π·16) ≈ 0.0025 W/m².",
                "f' = f · v / (v + vs) = 700 · 343 / (343 + 30) ≈ 638 Hz. La frecuencia disminuye al alejarse.",


            };
        }

        private void MostrarPregunta()
        {
            if (preguntaActual < preguntas.Length && preguntaActual < opcionesPreguntas.Length)
            {
                preguntaLabel.Text = preguntas[preguntaActual];
                for (int i = 0; i < opciones.Length; i++)
                {
                    if (i < opcionesPreguntas[preguntaActual].Length)
                        opciones[i].Text = opcionesPreguntas[preguntaActual][i];
                    else
                        opciones[i].Text = ""; // o desactivar el botón
                    opciones[i].Checked = false;
                }
            }
            else
            {
                MessageBox.Show("¡Examen finalizado!");
                this.Close();
            }

        }

        private void VerificarRespuesta()
        {
            int seleccionada = -1;
            for (int i = 0; i < opciones.Length; i++)
            {
                if (opciones[i].Checked)
                {
                    seleccionada = i;
                    break;
                }
            }

            if (seleccionada == respuestasCorrectas[preguntaActual])
            {
                MessageBox.Show("¡Correcto!");
            }
            else
            {
                MessageBox.Show("Incorrecto. " + explicaciones[preguntaActual]);
            }

            preguntaActual++;
            MostrarPregunta();
        }
    }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var formulario = new GuiaFisica();

            Application.Run(formulario);
        }
    }
}

