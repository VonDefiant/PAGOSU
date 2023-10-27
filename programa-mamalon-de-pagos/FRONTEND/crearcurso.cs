using programa_mamalon_de_pagos.BACKEND;
using System;
using System.Linq;
using System.Windows.Forms;

namespace programa_mamalon_de_pagos.FRONTEND
{
    public partial class crearcurso : Form
    {
        public crearcurso()
        {
            InitializeComponent();

            // Agregar las columnas al DataGridView
            dgvAgregar.Columns.Add("IDCurso", "ID Curso");
            dgvAgregar.Columns.Add("NombreCurso", "Nombre del Curso");
            dgvAgregar.Columns.Add("Descripcion", "Descripción del Curso");
        }

        private void btnAgregarCurso_Click(object sender, EventArgs e)
        {
            int idCurso;
            if (int.TryParse(txtIDCurso.Text, out idCurso))
            {
                // Verificar si el ID del curso ya existe en las filas existentes
                bool idRepetido = dgvAgregar.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToInt32(row.Cells["IDCurso"].Value) == idCurso);

                if (idRepetido)
                {
                    MessageBox.Show("El ID del curso ya existe. Por favor, ingrese un ID único.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string nombreCurso = txtNombreCurso.Text;
                    string descripcion = txtDescripcion.Text;

                    // Agregar un nuevo curso al DataGridView
                    dgvAgregar.Rows.Add(idCurso, nombreCurso, descripcion);

                    // Limpiar los TextBox después de agregar el curso
                    LimpiarTextBox();
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID de curso válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarTextBox()
        {
            txtIDCurso.Clear();
            txtNombreCurso.Clear();
            txtDescripcion.Clear();
        }
    }
}
