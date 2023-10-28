using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace programa_mamalon_de_pagos.FRONTEND.imagenes
{
    public partial class borrarcurso : Form
    {
        public borrarcurso()
        {
            InitializeComponent();
        }

        private void txtcurso_TextChanged(object sender, EventArgs e)
        {
            // Puedes agregar validaciones adicionales si es necesario
        }

        private void deletebt_Click(object sender, EventArgs e)
        {
            try
            {
                string idCurso = txtcurso.Text; // Suponiendo que el ID del curso se ingresa en el cuadro de texto txtcurso

                if (string.IsNullOrWhiteSpace(idCurso))
                {
                    MessageBox.Show("Por favor, ingrese un ID de curso válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Llamar al método EliminarCurso con el ID del curso a eliminar
                EliminarCurso(idCurso);

                // Mostrar un mensaje de éxito
                MessageBox.Show("Curso eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar el cuadro de texto después de eliminar el curso
                txtcurso.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el curso: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarCurso(string idCurso)
        {
            string connectionString = "Data Source = BACKEND/EXACTUS.db; Version = 3; ";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM Cursos WHERE IDCurso = @IDcurso;";

                using (SQLiteCommand cmd = new SQLiteCommand(deleteQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@IDcurso", idCurso);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
