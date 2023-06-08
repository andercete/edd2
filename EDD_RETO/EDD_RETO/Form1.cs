namespace EDD_RETO
{
    /// <summary>
    /// Clase principal que representa el formulario principal de la aplicaci�n.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Constructor de la clase Form1.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Evento que se ejecuta al hacer clic en el bot�n "Informaci�n".
        /// Abre la ventana de informaci�n de Mongolia.
        /// </summary>
        /// <param name="sender">Objeto que genera el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una instancia de la ventana de informaci�n de Mongolia
            InformacionMongoliaForm informacionForm = new InformacionMongoliaForm();

            // Mostrar la ventana de informaci�n de Mongolia
            informacionForm.Show();
        }
        /// <summary>
        /// Evento que se ejecuta al hacer clic en el bot�n "Preguntas".
        /// Abre la ventana de preguntas de Mongolia.
        /// </summary>
        /// <param name="sender">Objeto que genera el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void button2_Click(object sender, EventArgs e)
        {
            // Crear una instancia de la ventana de preguntas de Mongolia
            PreguntasMongoliaForm preguntasForm = new PreguntasMongoliaForm();

            // Mostrar la ventana de preguntas de Mongolia
            preguntasForm.Show();
        }
    }
}