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
    public partial class reportes : Form
    {
        public reportes()
        {
            InitializeComponent();
            CargarJornadasEnComboBox();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CMBJORNADA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CMBJORNADA.SelectedIndex >= 0)
            {
                string jornadaSeleccionada = CMBJORNADA.SelectedItem.ToString();

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
    }
}
