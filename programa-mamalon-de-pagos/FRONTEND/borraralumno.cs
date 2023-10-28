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

namespace programa_mamalon_de_pagos.FRONTEND
{
    public partial class borraralumno : Form
    {
        public borraralumno()
        {
            InitializeComponent();
        }

        private void txtcurso_TextChanged(object sender, EventArgs e)
        {

        }

        private void deletebt_Click(object sender, EventArgs e)
        {
            try
            {
                string carnet = txtcarnet.Text; // Suponiendo que el carnet del estudiante se ingresa en el cuadro de texto txtcarnet

                if (string.IsNullOrWhiteSpace(carnet))
                {
                    MessageBox.Show("Por favor, ingrese un carnet válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Llamar al método EliminarEstudiante con el carnet del estudiante a eliminar
                EliminarEstudiante(carnet);

                // Mostrar un mensaje de éxito
                MessageBox.Show("Estudiante eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar el cuadro de texto después de eliminar el estudiante
                txtcarnet.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el estudiante: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EliminarEstudiante(string carnet)
        {
            string connectionString = "Data Source = BACKEND/EXACTUS.db; Version = 3; ";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM Estudiantes WHERE Carnet = @Carnet;";

                using (SQLiteCommand cmd = new SQLiteCommand(deleteQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Carnet", carnet);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}

