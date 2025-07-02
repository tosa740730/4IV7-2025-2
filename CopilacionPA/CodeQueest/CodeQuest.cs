using Clases;

namespace CodeQueest
{
    public partial class CodeQuest : Form
    {
        public CodeQuest()
        {
            //Usuarios.Inicio_de_sesion usuarios = new Usuarios.Inicio_de_sesion();
            //usuarios.ShowDialog();
            InitializeComponent();
        }
        Evaluacion evaluacion = new Evaluacion();
        MensajeDeMuerte muerte = new MensajeDeMuerte();
        MensajeFinal fin = new MensajeFinal();

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarFormulario();
            evaluacion.respuesta = 'B';
        }


        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            evaluacion.respuesta = ' ';
            if (RtnRespuestaA.Checked) evaluacion.respuesta = 'A';
            else if (RtnRespuestaB.Checked) evaluacion.respuesta = 'B';
            else if (RtnRespuestaC.Checked) evaluacion.Respuesta = 'C';
            else if (RtnRespuestaD.Checked) evaluacion.Respuesta = 'D';
            if (evaluacion.EvaluarPregunta() == true)
            {
                PnlRespCorre.Enabled = true;
                PnlRespCorre.Visible = true;
                PnlPreguntas.Visible = false;
                PnlPreguntas.Enabled = false;
            }
            else
            {
                PnlPreguntas.Visible = false;
                PnlPreguntas.Enabled = false;
                PnlRetroali.Visible = true;
                PnlRetroali.Enabled = true;
            }
        }
        private void ActualizarFormulario()
        {
            if (evaluacion.vidass <= 0)
            {
                DialogResult restult = MessageBox.Show($"{muerte.Muerte()}", "Game Over",
                MessageBoxButtons.RetryCancel);
                if (restult == DialogResult.Cancel)
                {
                    this.Close();
                }
                else
                {
                    evaluacion.vidass = 3;
                    evaluacion.Num_Pregunta = 1;
                }

            }

            if (evaluacion.Num_Pregunta > 10)
            {
                DialogResult restult = MessageBox.Show($"{fin.Final()}", "Fin del juego",
               MessageBoxButtons.OK);
                if (restult == DialogResult.OK)
                {
                    this.Close();
                }

            }
            if (evaluacion.Num_Pregunta == 10)
            {
                TxBoxPre10.Visible = true;
            }

            LblVidas.Text = $"Vidas X{evaluacion.vidass}";

            Acertijos pregunta = new Acertijos();
            pregunta.Numeros = evaluacion.Num_Pregunta;
            pregunta.Insisos();
            LblPregunta.Text = pregunta.Preguntas();
            LblInsisoA.Text = pregunta.InsisoA;
            LblInsisoB.Text = pregunta.InsisoB;
            LblInsisoC.Text = pregunta.InsisoC;
            LblInsisoD.Text = pregunta.InsisoD;
            RtnRespuestaA.Checked = false;
            RtnRespuestaB.Checked = false;
            RtnRespuestaC.Checked = false;
            RtnRespuestaD.Checked = false;
        }

        private void PnlPreguntas_VisibleChanged(object sender, EventArgs e)
        {
            ActualizarFormulario();
        }



        private void PnlRetroali_VisibleChanged(object sender, EventArgs e)
        {
            LblRetro.Text = evaluacion.LlamarRetroalimentacion();
            LblVidaserr.Text = $"Vidas X{evaluacion.vidass}";
            LblAdvertenciaerror.Visible = evaluacion.Num_Pregunta != 1;
        }

        private void BtncontinuarError_Click(object sender, EventArgs e)
        {
            if (evaluacion.Num_Pregunta > 1)
            {
                evaluacion.Num_Pregunta--;
            }
            PnlRetroali.Visible = false;
            PnlRetroali.Enabled = false;
            PnlPreguntas.Visible = true;
            PnlPreguntas.Enabled = true;
        }

        private void BtnContinuarCorr_Click_1(object sender, EventArgs e)
        {
            PnlRespCorre.Visible = false;
            PnlRespCorre.Enabled = false;
            PnlPreguntas.Visible = true;
            PnlPreguntas.Enabled = true;
        }

        private void LblInsisoA_Click(object sender, EventArgs e)
        {
            RtnRespuestaA.Checked = true;
        }
        private void LblInsisoB_Click(object sender, EventArgs e)
        {
            RtnRespuestaB.Checked = true;
        }
        private void LblInsisoC_Click(object sender, EventArgs e)
        {
            RtnRespuestaC.Checked = true;
        }
        private void LblInsisoD_Click(object sender, EventArgs e)
        {
            RtnRespuestaD.Checked = true;
        }
    }
}
