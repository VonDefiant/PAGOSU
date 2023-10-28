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
    public partial class reportesporalumno : Form
    {
        public reportesporalumno()
        {
            InitializeComponent();

        }



        private void TXTCARNE_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void BTNVerificarCarnet_Click(object sender, EventArgs e)
        {
            // Obtener el carnet ingresado por el usuario
            string carnet = TXTCARNE.Text;

            // Verificar si el carnet existe en la base de datos
            if (VerificarCarnetExistente(carnet))
            {
                // Filtra los datos en el DataGridView por el carnet
                FiltrarDatosPorCarnet(carnet);
                MessageBox.Show("El carnet existe en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El carnet no existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FiltrarDatosPorCarnet(string carnet)
        {
            try
            {
                // Conecta a la base de datos y obtiene los datos filtrados por el carnet
                string connectionString = "Data Source = BACKEND/EXACTUS.db; Version = 3; ";
                string selectQuery = "SELECT Id, Fecha, Carnet, GradosPeriodos, Monto, TipoPago FROM Pagos WHERE Carnet = @Carnet";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(selectQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Carnet", carnet);
                        using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            dataAdapter.Fill(dt);

                            // Asigna los datos filtrados al DataGridView
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }
        private bool VerificarCarnetExistente(string carnet)
        {
            bool carnetExistente = false;

            try
            {
                string connectionString = "Data Source = BACKEND/EXACTUS.db; Version = 3; ";
                string selectQuery = "SELECT COUNT(*) FROM Pagos WHERE Carnet = @Carnet";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(selectQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Carnet", carnet);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        carnetExistente = count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar el carnet: " + ex.Message);
            }

            return carnetExistente;
        }
    }
}

