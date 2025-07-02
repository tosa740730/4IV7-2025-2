namespace PA_GUIA_INGLES
{
    public partial class FrmEjercicios : Form
    {

        Dictionary<string, List<Preguntas>> preguntasPorTema = new Dictionary<string, List<Preguntas>>();

        public FrmEjercicios()
        {
            InitializeComponent();

        }

        private void FrmEjercicios_Load(object sender, EventArgs e)
        {
            CmbTemas.Items.Add("REPORTED SPEECH");
            CmbTemas.Items.Add("GET USED TO, BE USED TO + ING");
            CmbTemas.Items.Add("SECOND AND THRID CONDITIONAL");
            CmbTemas.Items.Add("WISH + SIMPLE PAST, WISH + WOULD, WISH + PAST PERFECT");
            CmbTemas.Items.Add("PASSIVE VOICE");
            CmbTemas.Items.Add("RELATIVE CLAUSES");

            preguntasPorTema["REPORTED SPEECH"] = new List<Preguntas>()
    {
        new Preguntas("He said, \"I am going to the space station.\"", new List<string> { "He said he was going to the space station.", "He said he are going to the space station.", "He said he will go to the space station." }, 0),
        new Preguntas("She said, \"We have seen the crime scene.\"", new List<string> { "She said they had seen the crime scene.", "She say they have seen the crime scene.", "She said they saw the crime scene." }, 0),
        new Preguntas("They said, \"We will launch the rocket tomorrow.\"", new List<string> { "They say they will launch the rocket tomorrow.", "They said they would launch the rocket the next day.", "They said they launched the rocket tomorrow." }, 1),
        new Preguntas("He said, \"I can't solve this problem.\"", new List<string> { "He said he couldn't solve that problem.", "He said she can’t solve this problem.", "He said he couldn’t solve this problem." }, 0),
        new Preguntas("She said, \"I was training yesterday.\"", new List<string> { "He said she was training yesterday.", "She said she had been training the day before.", "She said she is training yesterday." }, 1),
        new Preguntas("They said, \"We must finish the mission today.\"", new List<string> { "They said they must finishing the mission that day.", "They said they had to finish the mission that day.", "They said they have to finish the mission today." }, 1),
    };

            preguntasPorTema["GET USED TO, BE USED TO + ING"] = new List<Preguntas>()
    {
        new Preguntas("I’m used to _ in zero gravity now.", new List<string> { "float", "floating", "floated" }, 1),
        new Preguntas("The detective will eventually get used to _ early.", new List<string> { "woke up", "wake up", "waking up" }, 2),
        new Preguntas("They are used to _ the alarms during simulations.", new List<string> { "hear", "hearing", "heard" }, 1),
        new Preguntas("Astronauts must _ wearing heavy suits.", new List<string> { "be used to", "get used to", "used to" }, 1),
        new Preguntas("It was hard for her to _ the silence in space.", new List<string> { "be used to", "get used to", "got used to" }, 1),
        new Preguntas("She is used to _ under pressure.", new List<string> { "work", "working", "worked" }, 1),
    };
            preguntasPorTema["SECOND AND THRID CONDITIONAL"] = new List<Preguntas>()
    {
        new Preguntas("If the astronaut _ more training, he would be more confident.", new List<string> { "has", "had", "have" }, 1),
        new Preguntas("If the crime rate _ lower, the city would be safer.", new List<string> { "are", "were", "is" }, 1),
        new Preguntas("If I _ a space suit, I would go to the moon.", new List<string> { "have", "had", "will have" }, 1),
        new Preguntas("If the hackers _ the security system, the data would have been stolen.", new List<string> { "had breached", "breached", "have breached" }, 0),
        new Preguntas("If she _ earlier, she would have prevented the crime.", new List<string> { "left", "had left", "leaves" }, 0),
        new Preguntas("If we _ more time, we would have explored the new planet.", new List<string>{ "had had","have","had"}, 0)
    };
            preguntasPorTema["WISH + SIMPLE PAST, WISH + WOULD, WISH + PAST PERFECT"] = new List<Preguntas>()
    {
        new Preguntas("I wish I _ draw better.", new List<string> { "can", "could", "will" }, 1),
        new Preguntas("I wish he _ the truth for once, I can't stand it", new List<string> { "will tell", "would tell", "tells" }, 1),
        new Preguntas("I wish I _ the break-in earlier.", new List<string> { "reported", "have reported", "had reported" }, 2),
        new Preguntas("He wishes he _ sing beautifully.", new List<string> { "could", "can", "had" }, 0),
        new Preguntas("I wish my friend _ posting fake crime news", new List<string> { "stops", "would stop", "stop" }, 1),
        new Preguntas("They wish they _ more about cybersecurity in this moment.", new List<string> { "had learned", "learned", "have learned" }, 1)
    };
            preguntasPorTema["PASSIVE VOICE"] = new List<Preguntas>()
    {
        new Preguntas("The space station _ by international scientists.", new List<string> { "builds", "is built", "built" }, 1),
        new Preguntas("The robbery _ by two masked men last night.", new List<string> { "is committed", "was committed", "will be committed" }, 1),
        new Preguntas("A new satellite _ into orbit next month.", new List<string> { "will be launched", "is launched", "was launched" }, 0),
        new Preguntas("The documents _ by the agent before the meeting.", new List<string> { "have been reviewed", "are reviewed", "reviewed" }, 0),
        new Preguntas("This planet _ with powerful telescopes.", new List<string> { "can be observed", "can observe", "is observing" }, 0),
        new Preguntas("The criminal _ by the judge tomorrow.", new List<string> { "is sentenced", "was sentenced", "will be sentenced" }, 2),
        new Preguntas("Many skills _ in astronaut training.", new List<string> { "are taught", "taught", "were taught" }, 0),
        new Preguntas("The evidence _ before the trial.", new List<string> { "was analyzed", "is analyzed", "will be analyze" }, 0),
    };
            preguntasPorTema["RELATIVE CLAUSES"] = new List<Preguntas>()
    {
        new Preguntas("The detective _ solved the case became famous.", new List<string> { "who", "where", "which" }, 0),
        new Preguntas("That’s the robot _ can repair satellites in space.", new List<string> { "whose", "that", "whom" }, 1),
        new Preguntas("The woman _ we interviewed is a security expert.", new List<string> { "whom", "where", "which" }, 0),
        new Preguntas("This is the facility _ astronauts train before missions.", new List<string> { "where", "which", "that" }, 0),
        new Preguntas("Dr. Allen, _ is an expert in space psychology, gave a lecture.", new List<string> { "where", "who", "whom" }, 1),
        new Preguntas("The report, _ was published yesterday, shocked the public.", new List<string> { "whose", "that", "which" }, 2),
        new Preguntas("Mr. Torres, _ laptop was stolen, is very upset.", new List<string> { "whose", "who", "whom" }, 0),
        new Preguntas("The city, _ he was arrested, has a high crime rate.", new List<string> { "that", "which", "where" }, 2),
    };
        }

        int preguntaActual = 0;
        List<Preguntas> preguntasDelTema;

        private void CmbTemas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temaSeleccionado = CmbTemas.SelectedItem.ToString();
            preguntasDelTema = preguntasPorTema[temaSeleccionado];
            preguntaActual = 0;
            MostrarPregunta();
        }
        private void MostrarPregunta()
        {
            if (preguntasDelTema != null && preguntasDelTema.Count > 0)
            {
                var pregunta = preguntasDelTema[preguntaActual];
                LblPregunta.Text = pregunta.Texto;
                radioButton1.Text = pregunta.Opciones[0];
                radioButton2.Text = pregunta.Opciones[1];
                radioButton3.Text = pregunta.Opciones[2];

                // Desmarcar radios
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                LblResultado.Text = "";
            }
        }

        private void BtnValidar_Click(object sender, EventArgs e)
        {
            var pregunta = preguntasDelTema[preguntaActual];
            int seleccion = -1;

            if (radioButton1.Checked) seleccion = 0;
            else if (radioButton2.Checked) seleccion = 1;
            else if (radioButton3.Checked) seleccion = 2;

            if (seleccion == pregunta.IndiceCorrecto)
            {
                LblResultado.Text = "¡Correcto!";
                LblResultado.ForeColor = Color.Green;
            }
            else
            {
                LblResultado.Text = "Incorrecto";
                LblResultado.ForeColor = Color.Red;
            }
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            preguntaActual++;
            if (preguntaActual < preguntasDelTema.Count)
            {
                MostrarPregunta();
            }
            else
            {
                MessageBox.Show("¡Has terminado todas las preguntas de este tema!");
            }
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            FrmInicio frmAnterior;
            frmAnterior = new FrmInicio();

            this.Close();
        }
    }

}