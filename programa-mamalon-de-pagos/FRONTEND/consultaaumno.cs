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

        private void cmjornada_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            // Obtener los datos del formulario
            int carnet = int.Parse(CARNECONSULTA.Text);
            string nombreCompleto = TXTNOMBRECOMPLETO.Text;
            string carreraGrado = txtcarreta.Text;
            string seccion = textseccion.Text;
            string correoElectronico = txtcorreo.Text;
            string telefono = txtelefono.Text;
            string institucion = cminstitucion.Text;
            string facultad = cmfacultad.Text;
            string jornada = cmjornada.Text;
            

            // Crear una instancia de la clase Estudiante y asignar los datos
            Estudiante estudiante = ObtenerEstudiantePorCarnet(carnet);
            if (estudiante != null)
            {
                estudiante.NombreCompleto = nombreCompleto;
                estudiante.CarreraGrado = carreraGrado;
                estudiante.Seccion = seccion;
                estudiante.CorreoElectronico = correoElectronico;
                estudiante.Telefono = telefono;
                estudiante.Institucion = institucion;
                estudiante.Facultad = facultad;
                estudiante.Jornada = jornada;

                // Actualizar el estudiante en la base de datos
                estudiante.ActualizarEstudiante();
                MessageBox.Show("Estudiante actualizado correctamente.");
            }
            else
            {
                MessageBox.Show("Estudiante no encontrado.");
            }

            private void buscarboton_Click(object sender, EventArgs e)
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
                    cmjornada.Text = estudiante.Jornada;

                    // Habilitar el botón de "Actualizar"
                    BtnActualizar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Estudiante no encontrado.");
                    LimpiarCampos();
                }
            }




        }

    }
}
