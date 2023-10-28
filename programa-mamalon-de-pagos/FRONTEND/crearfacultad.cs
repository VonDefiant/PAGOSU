using programa_mamalon_de_pagos.BACKEND;
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
    public partial class crearfacultad : Form
    {
        public crearfacultad()
        {
            InitializeComponent();
        }

        private void txnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void crearfacultad_Load(object sender, EventArgs e)
        {
            CargarFacultad();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                // Recopila los datos ingresados por el usuario desde los controls del formulario
                string nombre = txnombre.Text;

                // Create an instance of the Institucion class with the provided data
                Facultades facultades = new Facultades(0, nombre);

                // Call the InsertarInstitucion method on the instance to save the data to the database
                facultades.InsertarFacultad();

                // Muestra un mensaje de éxito
                MessageBox.Show("Facultad creada exitosamente.");

                // Limpia los controles del formulario después de guardar
                LimpiarControles();
                CargarFacultad();
            }
            catch (Exception ex)
            {
                // Handle exceptions, e.g., display an error message or log the exception.
                MessageBox.Show("Error al crear la facultad: " + ex.Message);
            }
        }
        private void LimpiarControles()
        {
            // Este método limpia todos los controles del formulario
            txnombre.Text = "";

        }

        private void dgfacultad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void CargarFacultad()
        {
            // Conecta a la base de datos y obtiene los datos de los cursos
            string connectionString = "Data Source = BACKEND/EXACTUS.db; Version = 3; ";
            string selectQuery = "SELECT IDFacultad, Nombre FROM Facultades";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectQuery, connection))
                {
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);

                    // Asigna los datos al DataGridView
                    dgfacultad.DataSource = dt;
                }
            }


        }
    }
}
