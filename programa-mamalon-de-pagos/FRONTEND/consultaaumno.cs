using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa_mamalon_de_pagos.FRONTEND
{
    public partial class consultaaumno : Form
    {
        public consultaaumno()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void chbcursos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtcorreo_TextChanged(object sender, EventArgs e)
        {
        }

        private void textseccion_TextChanged(object sender, EventArgs e)
        {
        }

        private void cminstitucion_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void cmfacultad_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtelefono_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtcarreta_TextChanged(object sender, EventArgs e)
        {
        }

        private void TXTNOMBRECOMPLETO_TextChanged(object sender, EventArgs e)
        {
        }

        private void CARNECONSULTA_TextChanged(object sender, EventArgs e)
        {
        }

        private void buscarboton_Click(object sender, EventArgs e)
        {
            {
                // Obtener el número de carnet ingresado por el usuario
                int carnet = int.Parse(CARNECONSULTA.Text);

                // Crear una instancia de la clase Estudiante
                Estudiante estudiante = ObtenerEstudiantePorCarnet(carnet);

                if (estudiante != null)
                {
                    // Mostrar los datos del estudiante en los campos correspondientes
                    TXTNOMBRECOMPLETO.Text = estudiante.NombreCompleto;
                    txtcarreta.Text = estudiante.CarreraGrado;
                    textseccion.Text = estudiante.Seccion;
                    txtcorreo.Text = estudiante.CorreoElectronico;
                    txtelefono.Text = estudiante.Telefono;
                    cminstitucion.Text = estudiante.Institucion;
                    cmfacultad.Text = estudiante.Facultad;
                    // Otros campos y asignaturas...

                    // Habilitar el botón de "Actualizar"
                    BtnActualizar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Estudiante no encontrado.");
                    LimpiarCampos();
                }
            }
            private void LimpiarCampos()
            {
                // Limpia todos los campos del formulario
                TXTNOMBRECOMPLETO.Text = "";
                txtcarreta.Text = "";
                textseccion.Text = "";
                txtcorreo.Text = "";
                txtelefono.Text = "";
                cminstitucion.Text = "";
                cmfacultad.Text = "";
                CARNECONSULTA.Text = "";

                // Deshabilitar el botón de "Actualizar"
                BtnActualizar.Enabled = false;
            }

        }
        private Estudiante ObtenerEstudiantePorCarnet(int carnet)
        {
            // Aquí deberías implementar la lógica para obtener un estudiante por su carnet
            // utilizando tu base de datos y retornar una instancia de la clase Estudiante
            // con los datos obtenidos de la base de datos.
            // Puedes utilizar la conexión a la base de datos y la consulta SQL para esto.
            // Asegúrate de manejar adecuadamente la conexión y los errores.
            // Si el estudiante no se encuentra, puedes retornar null.

            // Ejemplo:
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=BACKEND/EXACTUS.db;Version=3;"))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM Estudiantes WHERE Carnet = @Carnet;";
                using (SQLiteCommand cmd = new SQLiteCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Carnet", carnet);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Crear una instancia de Estudiante y asignar los datos
                            Estudiante estudiante = new Estudiante(reader["NombreCompleto"].ToString(), reader["CarreraGrado"].ToString(), reader["Seccion"].ToString(), reader["CorreoElectronico"].ToString(), reader["Telefono"].ToString(), reader["Institucion"].ToString(), reader["Facultad"].ToString(), reader["Jornada"].ToString());
                            // Asignar asignaturas y otros campos...

                            return estudiante;
                        }
                        else
                        {
                            return null; // Estudiante no encontrado
                        }














                    }
                }
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
