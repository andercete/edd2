using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDD_RETO
{
    /// <summary>
    /// Clase que representa la ventana de información de Mongolia.
    /// </summary>
    public partial class InformacionMongoliaForm : Form
    {
        /// <summary>
        /// Constructor de la clase InformacionMongoliaForm.
        /// </summary>
        public InformacionMongoliaForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Historia".
        /// Muestra información sobre la historia de Mongolia.
        /// </summary>
        /// <param name="sender">Objeto que genera el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Información sobre la historia de Mongolia:\n\n" +
                   "Mongolia es un país con una rica historia que se remonta a los tiempos del imperio Mongol, liderado por Genghis Khan en el siglo XIII.\n" +
                   "Desde entonces, Mongolia ha pasado por muchos cambios políticos y culturales, desde la ocupación china hasta la era soviética, y finalmente la independencia en 1990.\n" +
                   "El país también es famoso por ser la tierra natal de muchos exploradores, como Genghis Khan y Marco Polo, y es conocido por su tradición nómada y su cultura pastoral.\n" +
                   "Durante el apogeo del imperio Mongol, que se extendió desde Europa Oriental hasta Asia Central, Mongolia fue el centro de un vasto imperio que abarcaba diferentes regiones y culturas.\n" +
                   "El imperio Mongol fue conocido por su gran habilidad en la guerra y sus conquistas, estableciendo uno de los imperios más grandes de la historia.\n" +
                   "Genghis Khan, el líder del imperio, unificó a las tribus mongolas y estableció un gobierno fuerte y centralizado.\n" +
                   "Además de sus logros militares, el imperio Mongol también contribuyó al intercambio cultural y comercial entre Asia, Europa y el Medio Oriente.\n" +
                   "La Ruta de la Seda, una importante ruta comercial que conectaba el este y el oeste, pasaba a través de Mongolia, lo que permitió el intercambio de bienes, conocimientos y culturas.\n" +
                   "Después del declive del imperio Mongol, Mongolia pasó por períodos de ocupación china y dominio manchú.\n" +
                   "En el siglo XX, Mongolia estuvo bajo la influencia de la Unión Soviética durante muchos años, adoptando un sistema socialista.\n" +
                   "Sin embargo, en 1990, Mongolia logró la transición hacia un sistema democrático y una economía de mercado.\n" +
                   "Hoy en día, Mongolia es conocida por su vasta y hermosa naturaleza, que incluye montañas, estepas y desiertos, así como por su rica cultura y tradiciones nómadas.";
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Idioma".
        /// Muestra información sobre el idioma de Mongolia.
        /// </summary>
        /// <param name="sender">Objeto que genera el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Información sobre el idioma de Mongolia:\n\n" +
                       "El idioma oficial de Mongolia es el mongol, que se escribe con un alfabeto cirílico modificado.\n" +
                       "El mongol es un idioma altamente inflectivo, lo que significa que las palabras pueden cambiar su forma para indicar el género, número, caso y otros aspectos gramaticales.\n" +
                       "El mongol se divide en varios dialectos, siendo el khalkha el más hablado y utilizado en la educación y los medios de comunicación.\n" +
                       "Además del mongol, también se hablan otros idiomas en Mongolia, como el chino y el ruso, debido a la influencia de sus países vecinos y las relaciones comerciales y culturales.\n" +
                       "A lo largo de la historia, el idioma mongol ha experimentado cambios y adaptaciones, especialmente durante la era soviética, cuando se introdujo el uso del alfabeto cirílico.\n" +
                       "Sin embargo, en los últimos años ha habido un movimiento para preservar y promover el uso del antiguo alfabeto mongol, conocido como el alfabeto de escritura clásica mongol.\n" +
                       "El idioma mongol es parte integral de la identidad cultural de Mongolia y desempeña un papel importante en la preservación de su historia y tradiciones.";
        }
        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Comida".
        /// Muestra información sobre la comida de Mongolia.
        /// </summary>
        /// <param name="sender">Objeto que genera el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Información sobre la comida de Mongolia:\n\n" +
                      "La gastronomía mongola se caracteriza por ser rica en carnes y lácteos, lo que refleja la tradición nómada del país.\n" +
                      "Uno de los platos más conocidos es el 'buuz', un tipo de empanada rellena de carne de cordero o vaca y verduras, que se cocina al vapor.\n" +
                      "También es popular el 'khuushuur', una empanada frita similar al 'buuz', pero más grande y con un relleno diferente.\n" +
                      "Otro plato típico es el 'khorkhog', que consiste en carne de cordero cocida en un caldero de metal con piedras calientes y verduras.\n" +
                      "Además de la carne, la leche y los productos lácteos son elementos fundamentales en la dieta mongola. El 'aaruul', por ejemplo, es un producto lácteo deshidratado que se consume como snack.\n" +
                      "Los mongolos también disfrutan de bebidas tradicionales como el 'airag', que es leche de yegua fermentada, y el 'suutei tsai', un té salado con mantequilla.\n" +
                      "La comida mongola refleja la vida nómada y las duras condiciones climáticas del país, proporcionando alimentos ricos en calorías y nutrientes necesarios para la supervivencia.";
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Geografía".
        /// Muestra información sobre la geografía de Mongolia.
        /// </summary>
        /// <param name="sender">Objeto que genera el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Información sobre la geografía de Mongolia:\n\n" +
                       "Mongolia es un país sin salida al mar que se encuentra en Asia Oriental, entre Rusia y China.\n" +
                       "Gran parte de su territorio es estepa, y también cuenta con montañas, como los montes Altái y el Khangai, y desiertos, como el de Gobi.\n" +
                       "El río más importante es el Selenga, que desemboca en el lago Baikal en Rusia.\n" +
                       "El clima en Mongolia varía desde desiertos extremadamente secos hasta regiones montañosas frías. El invierno puede ser especialmente riguroso, con temperaturas muy bajas.\n" +
                       "La geografía diversa de Mongolia ofrece oportunidades para actividades al aire libre, como el senderismo, la escalada y el senderismo a caballo. También es conocido por sus vastas extensiones de paisajes naturales prístinos.\n" +
                       "Mongolia alberga varios parques nacionales, como el Parque Nacional Gorkhi-Terelj y el Parque Nacional Khövsgöl, que son destinos populares para los amantes de la naturaleza y los entusiastas del ecoturismo.";
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Cultura".
        /// Muestra información sobre la cultura de Mongolia.
        /// </summary>
        /// <param name="sender">Objeto que genera el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Información sobre la cultura de Mongolia:\n\n" +
                       "Mongolia tiene una cultura rica y única que ha sido moldeada por siglos de tradiciones nómadas.\n" +
                       "La cultura mongol es conocida por sus festivales tradicionales, como Naadam, que celebra los deportes nacionales como la lucha libre, el tiro con arco y la carrera de caballos.\n" +
                       "La música y la danza también son una parte importante de la cultura mongol, con instrumentos tradicionales como el morin khuur, un instrumento de cuerda con cabeza de caballo, y la danza de la garza, que representa la libertad y la gracia.\n" +
                       "La vestimenta tradicional incluye ropas de colores brillantes y chaquetas de seda bordadas, y la comida tradicional incluye productos lácteos como el queso y el yogur, así como platos de carne de cordero y caballo.\n" +
                       "La yurta, conocida como 'ger' en mongol, es una estructura de vivienda portátil utilizada por los nómadas mongoles. Es una parte importante de la cultura y la identidad mongola.\n" +
                       "La tradición nómada sigue siendo una parte integral de la cultura mongol, y muchos mongoles continúan viviendo en yurtas y practicando el pastoreo y la crianza de animales como sus antepasados lo hicieron durante siglos.";
        }
    }
}
