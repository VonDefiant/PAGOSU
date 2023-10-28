using programa_mamalon_de_pagos.BACKEND;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa_mamalon_de_pagos.FRONTEND
{
    public partial class borrarinstitucion : Form
    {
        public borrarinstitucion()
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
                // Obtener el ID de la institución a eliminar del cuadro de texto
                if (int.TryParse(TXTBOX.Text, out int idInstitucion))
                {
                    // Crear una instancia de la clase Institucion
                    var institucion = new Institucion(idInstitucion, "");

                    // Llamar al método EliminarInstitucion
                    institucion.EliminarInstitucion();

                    // Mostrar un mensaje de éxito
                    MessageBox.Show("Institución eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar el cuadro de texto después de eliminar la institución
                    TXTBOX.Clear();
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un ID de institución válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la institución: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
