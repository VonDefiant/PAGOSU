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
    public partial class reportesporjornada : Form
    {
        public reportesporjornada()
        {
            InitializeComponent();
            CargarJornadasEnComboBox();
            CMBJORNADA.SelectedIndexChanged += CMBJORNADA_SelectedIndexChanged;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CMBJORNADA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CMBJORNADA.SelectedIndex >= 0)
            {
                string PeriodoSeleccionado = CMBJORNADA.SelectedItem.ToString();

                // Filtra los datos en el DataGridView
                FiltrarDatosPorPeriodo(PeriodoSeleccionado);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una Jornada válida.");
            }
        }
        private void CargarJornadasEnComboBox()
        {
            try
            {
                // Conecta a la base de datos y obtiene los nombres de las facultades
                string connectionString = "Data Source = BACKEND/EXACTUS.db; Version = 3; ";
                string selectQuery = "SELECT Nombre FROM GradosPeriodos";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(selectQuery, connection))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CMBJORNADA.Items.Add(reader["Nombre"].ToString());
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
        private void FiltrarDatosPorPeriodo(string Periodo)
        {
            try
            {
                // Conecta a la base de datos y obtiene los datos filtrados por la jornada
                string connectionString = "Data Source = BACKEND/EXACTUS.db; Version = 3; ";
                string selectQuery = "SELECT Id, Fecha, Carnet, GradosPeriodos,Monto, TipoPago FROM Pagos WHERE GradosPeriodos = @GradosPeriodos";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(selectQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@GradosPeriodos", Periodo);
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

    }
}


