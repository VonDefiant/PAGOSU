using programa_mamalon_de_pagos.BACKEND;
using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace programa_mamalon_de_pagos.FRONTEND
{
    public partial class borrardocente : Form
    {
        public borrardocente()
        {
            InitializeComponent();
        }

        private void deletebt_Click(object sender, EventArgs e)
        {
            try
            {
                string IDProfesor = TXTBOX.Text;

                if (string.IsNullOrWhiteSpace(IDProfesor))
                {
                    MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Llama al método EliminarDocente con el IDProfesor como parámetro
                EliminarDocente(IDProfesor);

                // Mostrar un mensaje de éxito
                MessageBox.Show("Profesor eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar el cuadro de texto después de eliminar el profesor
                TXTBOX.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el Profesor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EliminarDocente(string IDProfesor)
        {
            string connectionString = "Data Source=BACKEND/EXACTUS.db;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM Docentes WHERE IDProfesor = @IDProfesor;";

                using (SQLiteCommand cmd = new SQLiteCommand(deleteQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@IDProfesor", IDProfesor);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void TXTBOX_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
