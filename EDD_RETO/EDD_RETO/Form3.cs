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
    /// Formulario principal para el juego de preguntas sobre Mongolia.
    /// </summary>
    public partial class PreguntasMongoliaForm : Form
    {
        /// <summary>
        /// Constructor de la clase PreguntasMongoliaForm.
        /// Inicializa los componentes del formulario y las variables necesarias.
        /// </summary>
        private List<string> temasSeleccionados;
        private Random random;
        private string temaSeleccionado;
        private string respuestaCorrecta;
        public PreguntasMongoliaForm()
        {
            InitializeComponent();
            temasSeleccionados = new List<string>();
            random = new Random();
        }
        /// <summary>
        /// Evento de clic del botón "Generar Pregunta".
        /// Genera y muestra una pregunta aleatoria basada en los temas seleccionados.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>

        private void button1_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado al menos un tema
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked || checkBox5.Checked)
            {
                // Limpiar el campo de la pregunta
                richTextBox1.Clear();

                // Reiniciar los radio buttons
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;

                // Limpiar temas seleccionados
                temasSeleccionados.Clear();

                // Verificar qué temas han sido seleccionados y agregarlos a la lista
                if (checkBox1.Checked)
                {
                    temasSeleccionados.Add("Historia");
                }

                if (checkBox2.Checked)
                {
                    temasSeleccionados.Add("Idioma");
                }

                if (checkBox3.Checked)
                {
                    temasSeleccionados.Add("Comida");
                }

                if (checkBox4.Checked)
                {
                    temasSeleccionados.Add("Geografía");
                }

                if (checkBox5.Checked)
                {
                    temasSeleccionados.Add("Cultura");
                }

                // Obtener un tema aleatorio de la lista de temas seleccionados
                temaSeleccionado = temasSeleccionados[random.Next(temasSeleccionados.Count)];

                // Generar y mostrar una pregunta aleatoria del tema seleccionado
                GenerarPreguntaAleatoria(temaSeleccionado);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione al menos un tema de pregunta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Genera una pregunta aleatoria según el tema especificado.
        /// </summary>
        /// <param name="tema">El tema de la pregunta.</param>
        private void GenerarPreguntaAleatoria(string tema)
        {
            switch (tema)
            {
                case "Historia":
                    GenerarPreguntaHistoria();
                    break;

                case "Idioma":
                    GenerarPreguntaIdioma();
                    break;

                case "Comida":
                    GenerarPreguntaComida();
                    break;

                case "Geografía":
                    GenerarPreguntaGeografia();
                    break;

                case "Cultura":
                    GenerarPreguntaCultura();
                    break;
            }
        }
        

        /// <summary>
        /// Genera una pregunta de historia de forma aleatoria.
        /// </summary>
        private void GenerarPreguntaHistoria()
        {
            int opcionHistoria = random.Next(3);
            if (opcionHistoria == 0)
            {
                richTextBox1.Text = "¿Cuál fue el líder del imperio Mongol en el siglo XIII?\n\na) Genghis Khan\nb) Kublai Khan\nc) Attila el Huno";
                respuestaCorrecta = "a";
            }
            else if (opcionHistoria == 1)
            {
                richTextBox1.Text = "¿Qué eventos históricos marcaron la expansión del imperio Mongol?\n\na) La batalla de Ain Jalut\nb) La expedición de Marco Polo\nc) La invasión de Europa Occidental";
                respuestaCorrecta = "c";
            }
            else if (opcionHistoria == 2)
            {
                richTextBox1.Text = "¿Cómo influyó el imperio Mongol en la historia mundial?\n\na) Fomentando el intercambio cultural\nb) Estableciendo una ruta comercial entre Europa y Asia\nc) Creando un imperio unificado bajo un solo líder";
                respuestaCorrecta = "b";
            }
        }

        /// <summary>
        /// Genera una pregunta de idioma de forma aleatoria.
        /// </summary>
        private void GenerarPreguntaIdioma()
        {
            int opcionIdioma = random.Next(3);
            if (opcionIdioma == 0)
            {
                richTextBox1.Text = "¿Cuál es el idioma oficial de Mongolia?\n\na) Mongol\nb) Chino\nc) Ruso";
                respuestaCorrecta = "a";
            }
            else if (opcionIdioma == 1)
            {
                richTextBox1.Text = "¿Cuáles son algunos saludos comunes en mongol?\n\na) Sain uu\nb) Namarraa\nc) Bayartai";
                respuestaCorrecta = "a";
            }
            else if (opcionIdioma == 2)
            {
                richTextBox1.Text = "¿Qué alfabeto se utiliza para escribir el idioma mongol?\n\na) Cirílico\nb) Latino\nc) Árabe";
                respuestaCorrecta = "a";
            }
        }

        /// <summary>
        /// Genera una pregunta de comida de forma aleatoria.
        /// </summary>
        private void GenerarPreguntaComida()
        {
            int opcionComida = random.Next(3);
            if (opcionComida == 0)
            {
                richTextBox1.Text = "¿Cuál es uno de los platos más conocidos de la gastronomía mongola?\n\na) Buuz\nb) Sushi\nc) Pizza";
                respuestaCorrecta = "a";
            }
            else if (opcionComida == 1)
            {
                richTextBox1.Text = "¿Qué ingredientes son típicos en la cocina mongola?\n\na) Carne de cordero y leche de yak\nb) Arroz y fideos\nc) Queso y pan";
                respuestaCorrecta = "a";
            }
            else if (opcionComida == 2)
            {
                richTextBox1.Text = "¿Cuál es el método de cocción tradicional utilizado en la cocina mongola?\n\na) Asado en un horno de tierra\nb) Fritura en aceite caliente\nc) Cocido al vapor";
                respuestaCorrecta = "a";
            }
        }

        /// <summary>
        /// Genera una pregunta de geografía de forma aleatoria.
        /// </summary>
        private void GenerarPreguntaGeografia()
        {
            int opcionGeografia = random.Next(3);
            if (opcionGeografia == 0)
            {
                richTextBox1.Text = "¿Dónde se encuentra Mongolia?\n\na) Asia\nb) Europa\nc) América";
                respuestaCorrecta = "a";
            }
            else if (opcionGeografia == 1)
            {
                richTextBox1.Text = "¿Cuál es la capital de Mongolia?\n\na) Ulán Bator\nb) Moscú\nc) Pekín";
                respuestaCorrecta = "a";
            }
            else if (opcionGeografia == 2)
            {
                richTextBox1.Text = "¿Cuál es el punto más alto de Mongolia?\n\na) Jargalant Khairkhan\nb) Montaña Bogd Uul\nc) Khüiten Peak";
                respuestaCorrecta = "c";
            }
        }

        /// <summary>
        /// Genera una pregunta de cultura de forma aleatoria.
        /// </summary>
        private void GenerarPreguntaCultura()
        {
            int opcionCultura = random.Next(3);
            if (opcionCultura == 0)
            {
                richTextBox1.Text = "¿Cuál es el símbolo tradicional de la suerte en la cultura mongola?\n\na) Tumen Nas\nb) Ovoo\nc) La danza de la espada";
                respuestaCorrecta = "b";
            }
            else if (opcionCultura == 1)
            {
                richTextBox1.Text = "¿Cuál es una característica distintiva de la vestimenta tradicional mongola?\n\na) El del (gorro tradicional)\nb) El kimono\nc) El sombrero de copa";
                respuestaCorrecta = "a";
            }
            else if (opcionCultura == 2)
            {
                richTextBox1.Text = "¿Cuál es uno de los festivales más importantes de Mongolia?\n\na) Naadam\nb) Diwali\nc) Oktoberfest";
                respuestaCorrecta = "a";
            }
        }
        /// <summary>
        /// Obtiene la respuesta seleccionada por el usuario.
        /// </summary>
        /// <returns>La respuesta seleccionada (a, b, c).</returns>
        private string ObtenerRespuestaSeleccionada()
        {
            if (radioButton1.Checked)
            {
                return "a";
            }
            else if (radioButton2.Checked)
            {
                return "b";
            }
            else if (radioButton3.Checked)
            {
                return "c";
            }
            else
            {
                return "";
            }
        }
        /// <summary>
        /// Evento de clic del botón para verificar la respuesta seleccionada.
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una respuesta
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked)
            {
                // Verificar la respuesta seleccionada con la respuesta correcta
                string respuestaSeleccionada = ObtenerRespuestaSeleccionada();
                if (respuestaSeleccionada == respuestaCorrecta)
                {
                    MessageBox.Show("Respuesta correcta", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Respuesta incorrecta", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una respuesta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
