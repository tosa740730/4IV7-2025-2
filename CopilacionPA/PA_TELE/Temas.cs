namespace PA_TELE
{
    public class Subtema
    {
        public string Nombre { get; set; }
        public string Informacion { get; set; }

        public Subtema(string nombre, string informacion)
        {
            Nombre = nombre;
            Informacion = informacion;
        }
    }

    public class Tema
    {
        public string Nombre { get; set; }
        public List<Subtema> Subtemas { get; set; }

        public Tema(string nombre)
        {
            Nombre = nombre;
            Subtemas = new List<Subtema>();
        }

        public void AgregarSubtema(string nombre, string info)
        {
            Subtemas.Add(new Subtema(nombre, info));
        }

    }

    public class Temas
    {
        private List<Tema> listaTemas;

        public Temas()
        {
            listaTemas = new List<Tema>();

            Tema redes = new Tema("Redes");
            redes.AgregarSubtema(
               "1. ¿Qué es una red de datos?",
            @"Las redes de datos se diseñan y construyen en arquitecturas que pretenden servir a sus objetivos de uso.
             Las redes de datos, generalmente, están basadas en la comunicación de paquetes y se clasifican de acuerdo
             con su tamaño, la distancia que cubre y su arquitectura física."
            );
            redes.AgregarSubtema(
                "2. Elementos que forman una Red",
            @"Los elementos de una red de datos consisten en computadoras consta tanto de hardware como de software.
             En el hardware se incluyen: estaciones de trabajo, servidores, tarjeta de interfaz de red, cableado y 
             equipo de conectividad. En el software se encuentra el sistema operativo de red (Network Operating System).
             Así como medios de transmisión que pueden ser alámbricos e inalámbricos y protocolos de red para que se 
             puedan comunicar entre ellos"
            );
            redes.AgregarSubtema(
                "3. Los usos que tienen las redes de datos",
             @"Los usos de redes de datos son muchos, tales como: transmitir información entre dispositivos que pueden
               ser celulares, computadoras, servidores, tablets para intercambio de información tal como transferencias
               bancarias, páginas de Internet, correo electrónico, redes sociales, noticias, información, educación, IOT,
               entre otros muchos usos."
             );
            redes.AgregarSubtema(
                "4.Clasificación de redes de datos de acuerdo con su extensión geográfica:",
             @"▪ Local Area Network (LAN)
               ▪ Metropolitan Area Network (MAN).
               ▪ Wide Area Network (WAN). "
             );
            redes.AgregarSubtema(
                "5.",
             @"Una LAN (Local Area Network) es una red limitada en extensión. Esta puede estar en un cuarto, en un piso,
                en un edificio, en unaescuelao en un campus universitario."
             );
            redes.AgregarSubtema(
                "6.¿Que es una red MAN?",
             @"Una MAN (Metropolitan Area Network) es una red más grande que una LAN pero más pequeña que una WAN. Esta es
               una red que cubre aproximadamente el área de una ciudad o un área metropolitana."
             );
            redes.AgregarSubtema(
                "7.¿Que es una red WAN?)",
             @"Una WAN (Wide Area Network) se utiliza para interconectar LANs o MANs, Se usa para áreas geográficas
               grandes usando líneas telefónicas o tecnología satelital para conectar ciudades, países o continentes."
             );
            redes.AgregarSubtema(
                "8. ¿Qué es una topología física?",
             @"Topología Física: Se refiere a la distribución física de los equipos en la red y estas topologías pueden ser
               las siguientes:
               • Bus. - Arreglo de computadoras en forma lineal en la que el cableado va una a continuación de la
                otra y donde al inicio y al final de la red se tienen terminadores.
               • Ring (Anillo). - Cuando no se tiene un punto de inicio y un punto final de la red, formando  un círculo.
               • Estrella. - Todos las computadoras se conectan a un punto central HUB o concentrador."
             );
            redes.AgregarSubtema(
                "9. ¿Qué es una aplicación de red?",
             @"Las aplicaciones de red son programas de software que corren entre diferentes computadoras conectadas a
               una red. Algunas de las aplicaciones de red más utilizadas son el Internet, el correo electrónico y el chat."
             );



            Tema modeloOSI = new Tema("Modelo OSI");
            modeloOSI.AgregarSubtema(
                 "1. ¿Qué es el modelo de referencia OSI?",
            @"             Es el modelo primario para comunicaciones de redes.
             A inicios de los 80's se empezó el desarrollo de redes de cómputo por parte de diferentes fabricantes, dando
             como origen una completa incompatibilidad para comunicarse entre redes de diferentes fabricantes. El ISO
             (International Organization for Standardization) investigó diferentes esquemas de redes. Así, como resultado
             de esta investigación, se creó un modelo de referencia llamado OSI que ayudaría a los fabricantes de redes a
             ser compatible con redes de otros fabricantes.
             
             El Open System Interconnection (OSI) liberado en 1984 por el ISO. El OSI aseguró la compatibilidad e
             interoperabilidad entre diferentes tipos de tecnologías de redes fabricadas por diferentes empresas a lo largo
             del mundo y es el sistema que se utiliza en la actualidad."
            );

            modeloOSI.AgregarSubtema(
                "2. Menciona las siete capas del Modelo de referencia OSI",
            @"             El modelo OSI consta de 7 capas y el flujo de información se realiza de Arriba hacia abajo en el transmisor y
             de abajo hacia arriba en el receptor.

             7 APLICACIÓN
             6 PRESENTACIÓN
             5 SESIÓN
             4 TRANSPORTE
             3 RED
             2 ENLACE DE DATOS
             1 FÍSICA"
            );
            modeloOSI.AgregarSubtema(
                "3. Objetivos Modelo OSI",
            @"             Objetivos Modelo OSI. Los objetivos del Modelo de Referencia OSI, se resumen en los siguientes 5 puntos:

             - Reduce la complejidad
             - Estandariza interfaces
             - Facilita la ingeniería modular
             - Asegura la interoperabilidad entre tecnologías
             - Acelera la evolución de la tecnología"
            );

            modeloOSI.AgregarSubtema(
                "4. Función de la capa Física del Modelo OSI",
            @"             • Capa 1. Nivel Físico.
             Relacionada con la transmisión de un tren de bits no estructurado sobre un medio físico, está relacionado con
             las características mecánicas, eléctricas, funcionales y de procedimientos para acceder al medio físico."
            );

            modeloOSI.AgregarSubtema(
                "5. Función de la capa de Enlace de Datos del Modelo OSI",
            @"             • Capa 2. Enlace de datos (punto a punto)
             Proporciona una transferencia confiable de la información a través de un medio físico, envía los bloques con
             la información necesaria de sincronización, control de errores y control de flujo."
            );

            modeloOSI.AgregarSubtema(
                "6. Función de la capa de Red del Modelo OSI",
            @"             • Capa 3. Red (enrutamiento)
             Proporciona a las capas superiores independencia de la transmisión y la conmutación o enrutamiento de datos.
             Determina el ruteo de los paquetes desde sus fuentes a sus destinos, manejando la congestión a la vez."
            );

            modeloOSI.AgregarSubtema(
                "7. Función de la capa de Transporte del Modelo OSI",
            @"             • Capa 4. Transporte.
             Proporciona una transferencia de datos confiable, transparente al usuario entre puntos extremos,
             proporciona comunicación libre de errores y control de flujo."
            );
            modeloOSI.AgregarSubtema(
               "8. Función de la capa de Sesión del Modelo OSI",
            @"             • Capa 5. Sesión.
             Proporciona la estructura de control para la comunicación entre aplicaciones, administra y termina las
             conexiones (sesiones) entre aplicaciones."
            );

            modeloOSI.AgregarSubtema(
                "9. Función de la capa de Presentación del Modelo OSI",
            @"             • Capa 6. Presentación.
             Proporciona independencia a los procesos de aplicación de diferencias en la representación de los datos."
            );

            modeloOSI.AgregarSubtema(
                "10. Función de la capa de Aplicación del Modelo OSI",
            @"             • Capa 7. Aplicación
             Es la forma en que la aplicación es presentada al usuario como e-mail, transferencia de archivos, emulación de
             terminales."
            );


            Tema dispositivodered = new Tema("Dispositivos de Red");
            dispositivodered.AgregarSubtema(
                "1. ¿Qué es un dispositivo de red?",
            @"Los dispositivos de red son los que conectan los dispositivos de usuario final posibilitando la comunicación
              entre ellos, así como la comunicación entre los dispositivos que permiten transportar los datos hacia otros
              sitios remotos."
            );
            dispositivodered.AgregarSubtema(
                "2. ¿Qué es un repetidor?",
            @"Un repetidor (o generador) es un dispositivo de red que opera sólo en la Capa Física del modelo OSI (capa 1).
             Un repetidor permite sólo extender la cobertura física de una red, pero no cambia la funcionalidad de esta.
             Un repetidor regenera una señal a niveles óptimos. Es decir, cuando un repetidor recibe una señal muy débil
             o corrompida, crea una copia bit por bit de la señal original. La posición de un repetidor es vital, éste debe
             poner antes de que la señal se debilite. En el caso de una red local (LAN) la cobertura máxima del cable UTP
             es 100 metros; pues el repetidor debe ponerse unos metros antes de esta distancia y poder extender la
             distancia otros 100 metros."
            );
            dispositivodered.AgregarSubtema(
                 "3. ¿Qué es un HUB?",
            @"             Es el dispositivo que permite centralizar el cableado de una red de computadoras, para luego poder ampliarla.
             Dicho dispositivo recibe una señal y repite esta señal emitiéndola por sus diferentes puertos.
             
             Existen hubs pasivos o hubs activos. Los pasivos sólo interconectan dispositivos, mientras que los hubs
             activos además regeneran las señales recibidas, como si fuera un repetidor. Un hub activo entonces, puede
             ser llamado como un repetidor multipuerto."
            );

            dispositivodered.AgregarSubtema(
                "4. ¿Qué es un Access Point?",
            @"             Un punto de acceso es un dispositivo inalámbrico que funciona en la capa de enlace de datos del modelo
             OSI. Es parecido a un switch (pero inalámbrico) que le da acceso a todos los dispositivos inalámbricos
             como celulares o laptops de los usuarios conectados a él. También llamado dispositivo inalámbrico WiFi
             (Wireless Fidelity)."
            );

            dispositivodered.AgregarSubtema(
                "5. ¿Qué es un Modem Digital?",
            @"             DSU/CSU (modem digital)

             El DSU/CSU (Data Service Unit/Channel Service Unit) o mejor conocido como DTU
             (Data Terminal Unit) es un equipo de interconexión que opera en la capa de Enlace de
             Datos. Un DSU/CSU es básicamente un modem digital que convierte las señales
             digitales en analógicas (modulación) y viceversa (desmodulación) y permite así la
             comunicación entre computadoras a través de la línea telefónica o del cablemódem."
            );

            dispositivodered.AgregarSubtema(
                "6. ¿Qué es un Ruteador?",
            @"             Los ruteadores operan en la capa de red del modelo OSI. Los ruteadores organizan una red grande en
             términos de segmentos lógicos. Como definición simple se considera como un dispositivo que une 2 o más
             segmentos de red a través del protocolo TCP/IP.
             
             El funcionamiento básico de un enrutador o encaminador, como se deduce de su nombre, consiste en enviar
             los paquetes de red por el camino o ruta más adecuada en cada momento. Para ello almacena los paquetes
             recibidos y procesa la información de origen y destino que poseen, esto a través de direcciones IP."
            );

            Tema ieee = new Tema("IEEE");
            ieee.AgregarSubtema(
                 "1. ¿Qué significa IEEE?",
            @"             IEEE (Institute of Electrical and Electronics Engineers, en castellano, Instituto de Ingenieros Eléctricos y
             Electrónicos). Es un organismo que entre otras cosas se encarga de hacer estándares de protocolos como los
             de conexión entre equipos.

             Tecnologías, Velocidades de transmisión y Estándares IEEE

             TECNOLOGÍA          VELOCIDAD DE TRANSMISIÓN      ESTÁNDAR IEEE
             ETHERNET                10 Mbps                       802.3
             FAST ETHERNET         100 Mbps                      802.3u
             GIGABIT ETHERNET      1 Gbps                        802.3z"
            );

            Tema mediosdetransmision = new Tema("Medios de Transmisión");
            mediosdetransmision.AgregarSubtema(
                 "1. ¿Qué es un medio de transmisión?",
            @"Los medios de transmisión son las vías o medios por las cuales se comunican los datos, entre 2
             o más dispositivos."
            );

            mediosdetransmision.AgregarSubtema(
                "2. Tipos de medios de transmisión",
            @"             Los medios de transmisión son las vías o medios por las cuales se comunican los datos entre 2 o más
             dispositivos. Dependiendo de la forma de conducir la señal a través del medio o soporte físico, se pueden
             clasificar en dos grandes grupos:
             • Medios de transmisión alámbricos
             • Medios de transmisión inalámbricos

             Alámbricos: Cable coaxial, Cable UTP, Cable STP y Fibra Óptica.
             Inalámbricos: el aire"
            );

            mediosdetransmision.AgregarSubtema(
                "3. Descripción de cable coaxial",
            @"El cable coaxial consiste en 2 conductores concéntricos y separados por un dieléctrico protegido del
             exterior por un aislante (similar a las antenas de tv).

             Sus características son:
             • Velocidad: 10 a 100 Mbps
             • Costo: Barato
             • Conector: Mediano
             • Longitud máxima: 200 m (delgado) / 500 m (grueso)
             • Protección EMI: Muy buena"
            );

            mediosdetransmision.AgregarSubtema(
                "4. Descripción de cable UTP",
            @"El cable UTP consiste de 8 hilos (4 pares trenzados). Usado actualmente para redes de datos en interiores.

             Sus características son:
             • Velocidad: 10 a 100 Mbps
             • Costo: Muy barato
             • Conector: Pequeño (RJ45)
             • Longitud máxima: 100 m
             • Protección EMI: Poca"
            );

            mediosdetransmision.AgregarSubtema(
                "5. Descripción de fibra óptica",
            @"             Transmite datos mediante impulsos luminosos, permitiendo grandes distancias sin amplificación.

             Tipos:
             • Monomodo (hasta 60 km)
             • Multimodo (hasta 3 km)

             Características:
             • Velocidad: +100 Mbps (hasta 2 Gbps)
             • Costo: Caro
             • Conector: Pequeño
             • Protección EMI: Excelente"
            );

            mediosdetransmision.AgregarSubtema(
                "6. Alcance de red WiFi",
            @"             Máxima longitud sin obstáculos: Hasta 200 metros
             Dispositivo generador: Access Point (Punto de acceso inalámbrico)"
            );

            Tema redinalambrica = new Tema("RED Inalámbrica");
            redinalambrica.AgregarSubtema(
                "1.¿Que es una Red inalámbrica?",
            @" Es una Tecnología que permite la transmisión de datos mediante ondas de radio, eliminando la necesidad de cables y 
               mejorando  la movilidad del usuario. El dispositivo principal es el Access Point.
              Características:
              • Velocidad de transmisión: 50-300 Mbps
              • Costo: Medio
              • Conector: Antena
              • Longitud máxima: 200 metros
              • Protección EMI: Excelente (excepto por interferencias de motores y teléfonos inalámbricos)"
             );
            Tema protocolos = new Tema("Protocolos");
            protocolos.AgregarSubtema(
                "1. Protocolo de red",
             @"Conjunto de normas para comunicación entre dispositivos en red.
                Características:
              • Estándar para comunicación de datos
              • Aplica en LAN, MAN y WAN
              • Define formato y secuencia de mensajes
              • Ejemplos: TCP/IP, HTTP, FTP"
            );
            protocolos.AgregarSubtema(
                "2. AppleTalk",
            @"Protocolo desarrollado por Apple para sus sistemas.
              Detalles:
              • Uso en redes locales Apple
              • Compartir archivos/impresoras
              • Configuración automática
              • Limitado a 32 dispositivos"
            );
            protocolos.AgregarSubtema(
                "3. NetBEUI",
            @"Protocolo nativo para redes Windows.
              Especificaciones:
              • Nombre: NetBIOS Extended UI
              • Para redes pequeñas
              • No soporta enrutamiento
              • Sin configuración IP requerida"
            );
            protocolos.AgregarSubtema(
                 "4. IPX/SPX",
            @"Suite de protocolos para Novell Netware.
              Componentes:
              • IPX: Direccionamiento (Capa 3)
              • SPX: Control de conexiones (Capa 4)
              • Usado en redes corporativas 90s"
            );
            protocolos.AgregarSubtema(
                 "5. TCP/IP",
            @"Conjunto base de protocolos de Internet.
              Estructura:
              • TCP: Conexiones confiables
              • IP: Direccionamiento y rutas
              • Multiplataforma (Windows, Linux, Mac)
              • Soporta cualquier dispositivo"
            );

            Tema Protocolos_de_Red_Fundamentales = new Tema("Protocolos de Red Fundamentales");
            Protocolos_de_Red_Fundamentales.AgregarSubtema(
                "1. ¿Qué es una dirección IP?",
            @"Una dirección IP es un número que identifica de forma única a una interfaz en red de cualquier dispositivo 
              conectado a ella que utilice el protocolo IP (Internet Protocol), correspondiente al nivel de red del modelo TCP/IP."
            );
            Protocolos_de_Red_Fundamentales.AgregarSubtema(
                "2. ¿Qué es TCP/IP?",
            @"TCP/IP es un conjunto de protocolos que permiten la comunicación entre los ordenadores pertenecientes a una red. 
              La sigla significa Protocolo de Control de Transmisión / Protocolo de Internet, en referencia a los protocolos TCP e IP."
            );
            Protocolos_de_Red_Fundamentales.AgregarSubtema(
                "3. ¿Qué es IP?",
            @"Protocolo de la capa de red que permite el ruteo de paquetes. El diseño del protocolo IP asume que la entrega 
              de los paquetes puede no ser confiable, pero busca la mejor ruta posible entre las conocidas por la máquina."
            );
            Protocolos_de_Red_Fundamentales.AgregarSubtema(
                "4. ¿Qué es TCP?",
            @"Protocolo de la capa 4 del modelo OSI. Permite establecer una conexión entre dos puntos terminales de una red 
              para intercambiar datos de forma confiable y ordenada."
            );

            Tema ProtocolosdeServiciosdeRed = new Tema("Protocolos de Servicios de Red");
            ProtocolosdeServiciosdeRed.AgregarSubtema(
                "1. ¿Qué es DHCP?",
            @"El Protocolo de Configuración Dinámica de Host (DHCP) es un protocolo cliente/servidor que asigna dinámicamente 
              una dirección IP y otros parámetros de red a cada dispositivo conectado desde un servidor DHCP."
            );
            ProtocolosdeServiciosdeRed.AgregarSubtema(
                "2. ¿Qué es FTP?",
            @"El Protocolo de Transferencia de Archivos (FTP) permite la transferencia de archivos entre sistemas conectados 
              a una red TCP, utilizando una arquitectura cliente-servidor."
            );
            ProtocolosdeServiciosdeRed.AgregarSubtema(
                "3. ¿Qué es SMTP?",
            @"El Protocolo para Transferencia Simple de Correo (SMTP) se utiliza para el envío de mensajes de correo electrónico 
              entre computadoras y dispositivos."
            );
            ProtocolosdeServiciosdeRed.AgregarSubtema(
                "4. ¿Qué es DNS?",
            @"El Sistema de Nombres de Dominio (DNS) traduce nombres de dominio en direcciones IP y viceversa, 
              permitiendo el acceso a sitios web usando nombres comprensibles para humanos."
            );
            ProtocolosdeServiciosdeRed.AgregarSubtema(
                "5. ¿Qué es HTTP?",
            @"El Protocolo de Transferencia de Hipertexto (HTTP) permite la transferencia de información en la World Wide Web, 
              como páginas HTML, imágenes y otros recursos web."
            );
            ProtocolosdeServiciosdeRed.AgregarSubtema(
                "6. ¿Qué es POP3?",
            @"El Protocolo de Oficina Postal versión 3 (POP3) es utilizado por clientes locales de correo para recibir mensajes 
              almacenados en un servidor remoto."
            );

            Tema SeguridadyAccesoRemoto = new Tema("Seguridad y Acceso Remoto");
            SeguridadyAccesoRemoto.AgregarSubtema(
                "1. ¿Qué es TELNET?",
            @"Protocolo de red que permite acceder y controlar remotamente otra máquina como si se estuviera frente a ella. 
              Usa el puerto 23 y requiere que la máquina remota tenga un servicio habilitado para gestionar estas conexiones."
            );
            SeguridadyAccesoRemoto.AgregarSubtema(
                "2. ¿Qué es un Firewall?",
            @"Un firewall es un sistema de seguridad que controla el tráfico de red, bloqueando accesos no autorizados y 
              permitiendo solo comunicaciones autorizadas entre redes o dispositivos."
            );






            listaTemas.Add(redes);
            listaTemas.Add(modeloOSI);
            listaTemas.Add(dispositivodered);
            listaTemas.Add(ieee);
            listaTemas.Add(mediosdetransmision);
            listaTemas.Add(redinalambrica);
            listaTemas.Add(protocolos);
            listaTemas.Add(Protocolos_de_Red_Fundamentales);
            listaTemas.Add(ProtocolosdeServiciosdeRed);
            listaTemas.Add(SeguridadyAccesoRemoto);
            // Agrega más temas y subtemas según necesites
        }

        public List<Tema> ObtenerTemas()
        {
            return listaTemas;
        }

        public Tema ObtenerTemaPorNombre(string nombre)
        {
            return listaTemas.Find(t => t.Nombre == nombre);
        }
    }
}
