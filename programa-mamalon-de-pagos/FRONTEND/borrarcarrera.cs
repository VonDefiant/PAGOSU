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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace programa_mamalon_de_pagos.FRONTEND
{
    public partial class borrarcarrera : Form
    {
        public borrarcarrera()
        {
            InitializeComponent();
        }

        private void TXTBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void deletebt_Click(object sender, EventArgs e)
        {
            try
            {
                string idCarrera = TXTBOX.Text; 

                if (string.IsNullOrWhiteSpace(idCarrera))
                {
                    MessageBox.Show("Por favor, ingrese un ID de carrera válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Llamar al método EliminarCarrera con el ID de la carrera a eliminar
                EliminarCarrera(idCarrera);

                // Mostrar un mensaje de éxito
                MessageBox.Show("Carrera eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar el cuadro de texto después de eliminar la carrera
                TXTBOX.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la carrera: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void EliminarCarrera(string idCarrera)
        {
            string connectionString = "Data Source=BACKEND/EXACTUS.db;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM Carrera WHERE IdCarrera = @IdCarrera;";

                using (SQLiteCommand cmd = new SQLiteCommand(deleteQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@IdCarrera", idCarrera);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
