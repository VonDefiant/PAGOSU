using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using programa_mamalon_de_pagos.BACKEND;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace programa_mamalon_de_pagos.FRONTEND
{
    public partial class crearestudiante : Form
    {

        public crearestudiante()
        {
            InitializeComponent();

        }

        private void nombreestuadiante_TextChanged(object sender, EventArgs e)
        {

        }

        private void EMAILESTUDIANTE_TextChanged(object sender, EventArgs e)
        {

        }

        private void INSTITUCION_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void telefonoalumno_TextChanged(object sender, EventArgs e)
        {

        }

        private void NACIMIENTOESTUDIANTE_TextChanged(object sender, EventArgs e)
        {

        }

        private void SECCIONESTUDIANTE_TextChanged(object sender, EventArgs e)
        {

        }

        private void CARRERA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SAVEBUTTON_Click(object sender, EventArgs e)
        {

        }

        private void crearestudiante_Load(object sender, EventArgs e)
        {

        }

        private void CbFacultad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbFacultad.SelectedIndex >= 0)
            {
                string facultadSeleccionada = CbFacultad.SelectedItem.ToString();


            }
            else
            {
                MessageBox.Show("Por favor, selecciona una facultad válida.");
            }
        }

        private void cbjornada_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbjornada.SelectedIndex >= 0)
            {
                string jornadaSeleccionada = cbjornada.SelectedItem.ToString();

            }
            else
            {
                MessageBox.Show("Por favor, selecciona una Jornada válida.");
            }
        }

        private void crearestudiante_Load_1(object sender, EventArgs e)
        {
            CargarFacultadesEnComboBox();
            CargarInstitucionEnComboBox();
            CargarJornadasEnComboBox();
            CargarCarreraEnComboBox();
        }

        private void Cbinstitucion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbinstitucion.SelectedIndex >= 0)
            {
                string institucionSeleccionada = Cbinstitucion.SelectedItem.ToString();

            }
            else
            {
                MessageBox.Show("Por favor, selecciona una Institucion válida.");
            }

        }

        private void LimpiarControles()
        {
            // Este método limpia todos los controles del formulario
            nombreestuadiante.Text = "";
            EMAILESTUDIANTE.Text = "";
            telefonoalumno.Text = "";
            SECCIONESTUDIANTE.Text = "";
            Cbcarrera.SelectedIndex = -1; // Reinicia la selección en el ComboBox
            Cbinstitucion.SelectedIndex = -1; // Reinicia la selección en el ComboBox
            CbFacultad.SelectedIndex = -1; // Reinicia la selección en el ComboBox
            cbjornada.SelectedIndex = -1; // Reinicia la selección en el ComboBox
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Recopila los datos ingresados por el usuario desde los controles del formulario
                string nombreCompleto = nombreestuadiante.Text;
                string correoElectronico = EMAILESTUDIANTE.Text;
                string telefono = telefonoalumno.Text;
                string seccion = SECCIONESTUDIANTE.Text;
                string carreraGrado = Cbcarrera.Text;
                string institucion = Cbinstitucion.Text;
                string facultad = CbFacultad.Text;
                string jornada = cbjornada.Text;

                // Crea una instancia de la clase Estudiante con los datos ingresados
                Estudiante estudiante = new Estudiante(nombreCompleto, carreraGrado, seccion, correoElectronico, telefono, institucion, facultad, jornada);

                // Llama al método InsertarEstudiante para guardar los datos en la base de datos
                estudiante.InsertarEstudiante();

                // Muestra un mensaje de éxito
                MessageBox.Show("Estudiante insertado exitosamente.");

                // Limpia los controles del formulario después de guardar
                LimpiarControles();
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir al insertar el estudiante
                MessageBox.Show("Error al insertar el estudiante: " + ex.Message);
            }

        }
        private void CargarFacultadesEnComboBox()
        {
            try
            {
                // Conecta a la base de datos y obtiene los nombres de las facultades
                string connectionString = "Data Source = BACKEND/EXACTUS.db; Version = 3; ";
                string selectQuery = "SELECT Nombre FROM Facultades";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(selectQuery, connection))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CbFacultad.Items.Add(reader["Nombre"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las facultades: " + ex.Message);
            }
        }

        private void CargarInstitucionEnComboBox()
        {
            try
            {
                // Conecta a la base de datos y obtiene los nombres de las facultades
                string connectionString = "Data Source = BACKEND/EXACTUS.db; Version = 3; ";
                string selectQuery = "SELECT Nombre FROM Instituciones";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(selectQuery, connection))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Cbinstitucion.Items.Add(reader["Nombre"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las facultades: " + ex.Message);
            }
        }

        private void CargarJornadasEnComboBox()
        {
            try
            {
                // Conecta a la base de datos y obtiene los nombres de las facultades
                string connectionString = "Data Source = BACKEND/EXACTUS.db; Version = 3; ";
                string selectQuery = "SELECT Nombre FROM Jornadas";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(selectQuery, connection))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cbjornada.Items.Add(reader["Nombre"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las facultades: " + ex.Message);
            }
        }

        private void Cbcarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbcarrera.SelectedIndex >= 0)
            {
                string carreraSeleccionada = Cbcarrera.SelectedItem.ToString();

            }
            else
            {
                MessageBox.Show("Por favor, selecciona una Carrera válida.");
            }
        }

        private void CargarCarreraEnComboBox()
        {
            try
            {
                // Conecta a la base de datos y obtiene los nombres de las facultades
                string connectionString = "Data Source = BACKEND/EXACTUS.db; Version = 3; ";
                string selectQuery = "SELECT NombreCarrera FROM Carrera";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(selectQuery, connection))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Cbcarrera.Items.Add(reader["NombreCarrera"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las carreras: " + ex.Message);
            }
        }



    }
}
