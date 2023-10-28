using programa_mamalon_de_pagos.BACKEND;
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


namespace programa_mamalon_de_pagos.FRONTEND
{
    public partial class crearprofesor : Form
    {
        private string connectionString = "Data Source=BACKEND/EXACTUS.db;Version=3;";

        public crearprofesor()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void TELEFONOPROF_TextChanged(object sender, EventArgs e)
        {

        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                // Recopila los datos ingresados por el usuario desde los controles del formulario
                string nombreCompleto = NOMBREPROF.Text;
                string correoElectronico = EMAILPROF.Text;
                string direccion = DIRECPROF.Text;
                string telefono = TELEFONOPROF.Text;

                // Crear una lista para almacenar las asignaturas seleccionadas
                List<string> Asignaturas = new List<string>();

                // Recorrer los elementos marcados en el CheckedListBox
                foreach (var item in CLBCURSOS.CheckedItems)
                {
                    Asignaturas.Add(item.ToString());
                }

                // Crea una instancia de la clase Profesor con los datos ingresados
                Profesor profesor = new Profesor(nombreCompleto, direccion, correoElectronico, telefono);

                // Asigna las asignaturas al profesor
                foreach (var asignatura in Asignaturas)
                {
                    profesor.AsignarAsignatura(asignatura);
                }

                // Llama al método InsertarDocente para guardar los datos en la base de datos
                profesor.InsertarDocente();

                // Muestra un mensaje de éxito
                MessageBox.Show("Profesor insertado exitosamente.");

                // Limpia los controles del formulario después de guardar
                LimpiarControles();
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir al insertar el profesor
                MessageBox.Show("Error al insertar el profesor: " + ex.Message);
            }
        }


        private void EMAILPROF_TextChanged(object sender, EventArgs e)
        {
        }

        private void DIRECPROF_TextChanged(object sender, EventArgs e)
        {
        }

        private void NOMBREPROF_TextChanged(object sender, EventArgs e)
        {
        }
        private void CLBCURSOS_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtén los índices de los elementos marcados
            int[] selectedIndices = CLBCURSOS.CheckedIndices.Cast<int>().ToArray();

            // Recorre los índices de los elementos marcados
            foreach (int index in selectedIndices)
            {
                string cursoSeleccionado = CLBCURSOS.Items[index].ToString();

            }
        }


        private void crearprofesor_Load(object sender, EventArgs e)
        {
            CargarCursosEnCheckedListBox();
        }

        private void CargarCursosEnCheckedListBox()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT NombreCurso FROM Cursos";

                    using (SQLiteCommand cmd = new SQLiteCommand(selectQuery, connection))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CLBCURSOS.Items.Add(reader["NombreCurso"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los cursos: " + ex.Message);
            }
        }

        private void LimpiarControles()
        {
            NOMBREPROF.Text = "";
            EMAILPROF.Text = "";
            DIRECPROF.Text = "";
            TELEFONOPROF.Text = "";
            // Deseleccionar todos los cursos
            for (int i = 0; i < CLBCURSOS.Items.Count; i++)
            {
                CLBCURSOS.SetItemCheckState(i, CheckState.Unchecked);
            }
        }


    }
}
