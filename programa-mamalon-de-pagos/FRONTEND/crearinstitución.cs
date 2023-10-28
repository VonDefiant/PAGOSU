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
    public partial class crearinstitución : Form
    {
        public crearinstitución()
        {
            InitializeComponent();
        }

        private void crearinstitución_Load(object sender, EventArgs e)
        {
            CargarInstituciones();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                // Recopila los datos ingresados por el usuario desde los controls del formulario
                string nombre = txnombre.Text;


                Institucion institucion = new Institucion(0, nombre);


                institucion.InsertarInstitucion();

                // Muestra un mensaje de éxito
                MessageBox.Show("Institución creada exitosamente.");

                // Limpia los controles del formulario después de guardar
                LimpiarControles();
                CargarInstituciones();
            }
            catch (Exception ex)
            {
                // Handle exceptions, e.g., display an error message or log the exception.
                MessageBox.Show("Error al crear la institución: " + ex.Message);
            }
        }

        private void txnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void LimpiarControles()
        {
            // Este método limpia todos los controles del formulario
            txnombre.Text = "";

        }

        private void dbginstitucion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CargarInstituciones()
        {
            // Conecta a la base de datos y obtiene los datos de los cursos
            string connectionString = "Data Source = BACKEND/EXACTUS.db; Version = 3; ";
            string selectQuery = "SELECT IdInstitucion, Nombre FROM Instituciones";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectQuery, connection))
                {
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);

                    // Asigna los datos al DataGridView
                    dbginstitucion.DataSource = dt;
                }
            }


        }
    }
}