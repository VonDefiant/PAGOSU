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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace programa_mamalon_de_pagos.FRONTEND
{
    public partial class crearcarrera : Form
    {
        public crearcarrera()
        {
            InitializeComponent();
        }

        private void txnombre_TextChanged(object sender, EventArgs e)
        {

        }



        private void dgfacultad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //INGE SI VE ESTOS DIGALE A ALGUNO DEL GRUPO FREDY FASBER
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                // Recopila los datos ingresados por el usuario desde los controls del formulario
                string nombre = txnombre.Text;

                string facultad = CbFacultad.SelectedItem.ToString();


                Carrera carrera = new Carrera(0, nombre, facultad);


                carrera.InsertarCarrera();

                // Muestra un mensaje de éxito
                MessageBox.Show("Carrera creada exitosamente.");

                // Limpia los controles del formulario después de guardar
                CargarCarreras();

                CargarFacultadesEnComboBox();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al crear la Carrera: " + ex.Message);
            }

        }


        private void crear_carrera_Load(object sender, EventArgs e)
        {
            CargarFacultadesEnComboBox();
        }


        private void LimpiarControles()
        {
            // Este método limpia todos los controles del formulario
            txnombre.Text = ""; ;
            CbFacultad.SelectedIndex = -1;

        }

        private void CbFacultad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgfacultad_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

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
        private void CargarCarreras()
        {
            // Conecta a la base de datos y obtiene los datos de los cursos
            string connectionString = "Data Source = BACKEND/EXACTUS.db; Version = 3; ";
            string selectQuery = "SELECT IdCarrera, NombreCarrera,Facultad FROM Carrera";

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