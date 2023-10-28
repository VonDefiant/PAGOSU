using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using programa_mamalon_de_pagos.BACKEND; // Asegúrate de importar el espacio de nombres correcto

namespace programa_mamalon_de_pagos.FRONTEND
{
    public partial class borrarfacultad : Form
    {
        public borrarfacultad()
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
                if (string.IsNullOrWhiteSpace(TXTBOX.Text))
                {
                    MessageBox.Show("Por favor, ingrese el ID de la facultad que desea eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idFacultad;
                if (!int.TryParse(TXTBOX.Text, out idFacultad))
                {
                    MessageBox.Show("El ID de la facultad debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Crear una instancia de la clase Facultades
                Facultades facultad = new Facultades(idFacultad, "");

                // Llamar al método EliminarFacultad
                facultad.EliminarFacultad();

                // Mostrar un mensaje de éxito
                MessageBox.Show("Facultad eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar el cuadro de texto después de eliminar la facultad
                TXTBOX.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la facultad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
