using programa_mamalon_de_pagos.BACKEND;
using System;
using System.Linq;
using System.Windows.Forms;

namespace programa_mamalon_de_pagos.FRONTEND
{
    public partial class crearcurso : Form
    {


        private void btnAgregarCurso_Click(object sender, EventArgs e)
        {

            
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
    }
}
