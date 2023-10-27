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
    public partial class crearinstitución : Form
    {
        public crearinstitución()
        {
            InitializeComponent();
        }

        private void crearinstitución_Load(object sender, EventArgs e)
        {

        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                // Recopila los datos ingresados por el usuario desde los controls del formulario
                string nombre = txnombre.Text;

                // Create an instance of the Institucion class with the provided data
                Institucion institucion = new Institucion(0, nombre); // You need to provide IdInstitucion (0 for a new record).

                // Call the InsertarInstitucion method on the instance to save the data to the database
                institucion.InsertarInstitucion();

                // Muestra un mensaje de éxito
                MessageBox.Show("Institución creada exitosamente.");

                // Limpia los controles del formulario después de guardar
                LimpiarControles();
            }
            catch (Exception ex)
            {
                // Handle exceptions, e.g., display an error message or log the exception.
                MessageBox.Show("Error al crear la institución: " + ex.Message);
            }
        }

        private void txnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void LimpiarControles()
        {
            // Este método limpia todos los controles del formulario
            txnombre.Text = "";

        }
    }
}
