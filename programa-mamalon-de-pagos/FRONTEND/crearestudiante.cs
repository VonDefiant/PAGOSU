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

namespace programa_mamalon_de_pagos.FRONTEND
{
    public partial class crearestudiante : Form
    {
        private EstudianteDAO EstudianteDAO;
        public crearestudiante()
        {
            InitializeComponent();
            string dbPath = "Data Source=BACKEND/EXACTUS.db;Version=3;";
            EstudianteDAO = new EstudianteDAO(dbPath);
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

        private void FACULTAD_SelectedIndexChanged(object sender, EventArgs e)
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void SAVEBUTTON_Click(object sender, EventArgs e)
        {
            // Recopila los datos del formulario
            string nombreCompleto = nombreestuadiante.Text;
            DateTime fechaDeNacimiento;
            if (!DateTime.TryParse(NACIMIENTOESTUDIANTE.Text, out fechaDeNacimiento))
            {
                MessageBox.Show("Fecha de nacimiento no válida.");
                return;
            }

            string carrera = CARRERA.Text;
            string seccion = SECCIONESTUDIANTE.Text;
            string correoElectronico = EMAILESTUDIANTE.Text;
            string telefono = telefonoalumno.Text;
            string jornada = textBox3.Text;
            string institucion = INSTITUCION.Text;
            string facultad = FACULTAD.Text;

            // Genera el número de carnet automáticamente (puedes personalizar la lógica)
            int carnet = int.Parse(GenerarNumeroCarnet());

            // Crea una instancia de Estudiante
            Estudiante nuevoEstudiante = new Estudiante(carnet, nombreCompleto, fechaDeNacimiento, carrera, seccion, correoElectronico, telefono, jornada, institucion, facultad);


            try
            {
                // Llama a la función para insertar el estudiante en la base de datos
                EstudianteDAO.InsertarEstudiante(nuevoEstudiante);

                // Puedes mostrar un mensaje de confirmación o realizar otras acciones después de guardar el estudiante
                MessageBox.Show("Estudiante guardado con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el estudiante: " + ex.Message);
            }
        }
        private string GenerarNumeroCarnet()
        {
            // Puedes personalizar la lógica para generar el número de carnet automáticamente
            // Aquí se muestra un ejemplo simple:
            Random random = new Random();
            string carnet = random.Next(1000, 9999).ToString() + "-" + random.Next(10, 99).ToString() + "-" + random.Next(1000, 9999).ToString();
            return carnet;
        }

        private void crearestudiante_Load(object sender, EventArgs e)
        {

        }

        private void GUARDAR_Click(object sender, EventArgs e)
        {

        }
    }
}
