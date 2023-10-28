using programa_mamalon_de_pagos.BACKEND;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;


namespace programa_mamalon_de_pagos.FRONTEND
{
    public partial class crearcurso : Form
    {
        public crearcurso()
        {
            InitializeComponent();

        }

        private void btnAgregarCurso_Click(object sender, EventArgs e)
        {
            try
            {

                // Recopila los datos ingresados por el usuario desde los controles del formulario
                string nombrecurso = txtNombreCurso.Text;
                string descripcion = txtDescripcion.Text;

                // Crea una instancia de la clase Curso con los datos ingresados
                Curso curso = new Curso(nombrecurso, descripcion);

                // Llama al método Insertarcurso para guardar los datos en la base de datos
                curso.InsertarCurso();

                // Muestra un mensaje de éxito
                MessageBox.Show("Curso insertado exitosamente.");

                // Limpia los controles del formulario después de guardar
                LimpiarControles();

                CargarCursos();
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir al insertar el curso
                MessageBox.Show("Error al insertar el curso: " + ex.Message);
            }
        }




        private void dgvAgregar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNombreCurso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void LimpiarControles()
        {
            // Este método limpia todos los controles del formulario
            txtNombreCurso.Text = "";
            txtDescripcion.Text = "";

        }
        private void CargarCursos()
        {
            // Conecta a la base de datos y obtiene los datos de los cursos
            string connectionString = "Data Source = BACKEND/EXACTUS.db; Version = 3; ";
            string selectQuery = "SELECT NombreCurso, IDCurso FROM Cursos";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectQuery, connection))
                {
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);

                    // Asigna los datos al DataGridView
                    dgvAgregar.DataSource = dt;
                }
            }
        }

        private void crearcurso_Load(object sender, EventArgs e)
        {

        }
    }
}
