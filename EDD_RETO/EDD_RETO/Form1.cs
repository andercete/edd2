namespace EDD_RETO
{
    /// <summary>
    /// Clase principal que representa el formulario principal de la aplicación.
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
        /// Evento que se ejecuta al hacer clic en el botón "Información".
        /// Abre la ventana de información de Mongolia.
        /// </summary>
        /// <param name="sender">Objeto que genera el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una instancia de la ventana de información de Mongolia
            InformacionMongoliaForm informacionForm = new InformacionMongoliaForm();

            // Mostrar la ventana de información de Mongolia
            informacionForm.Show();
        }
        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Preguntas".
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