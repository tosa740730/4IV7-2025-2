namespace PA_TELE
{
    public partial class Introducción : Form
    {
        public Introducción()
        {
            InitializeComponent();
        }

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            SelecciondeTemas selecciondeTemas = new SelecciondeTemas();
            this.Hide(); // Oculta el formulario actual
            selecciondeTemas.ShowDialog(); // ✅ Correcto: llamas al método sobre la instancia
            this.Show(); // Muestra nuevamente este formulario al cerrar el otro
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            rtbIntroduccion.Text =
@"Esta Guía fue aprobada por el Maestro de la Materia de Teleinformática:

  Estructura y contenidos

I. Distingue los elementos y usos que conforman una red de datos mediante modelos y estándares de calidad
• Definición, explicación y características sobre los elementos que conforman una red de datos
• Uso de las redes de datos y su importancia
• Clasificación de las redes de acuerdo con su extensión geográfica
• Modelo de referencia OSI

II. Presenta las tecnologías de red y los medios de transmisión existentes en el mercado a partir de normas y estándares de calidad
• Topologías y tecnologías de red
• Organismo Internacional IEEE
• Medios de transmisión
• Ensamblado cable de red UTP

III. Configura los protocolos de red y sus aplicaciones de acuerdo con las necesidades del usuario y/o la empresa
• Protocolos de Microsoft, IPX/SPX y TCP/IP
• Protocolos suite TCP/IP: FTP, TELNET, DHCP, DNS, TCP, IP, POP3, SMTP
• Modelo Cliente-servidor";
        }

        private void rtbIntroduccion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
