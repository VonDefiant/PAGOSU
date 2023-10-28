using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using programa_mamalon_de_pagos.BACKEND;

namespace programa_mamalon_de_pagos.FRONTEND
{
    public partial class Pagos : Form
    {
        public Pagos()
        {
            InitializeComponent();
            // Configura las opciones para el ComboBox de Pagos
            PagosCB.Items.Add("Tarjeta de Débito");
            PagosCB.Items.Add("Tarjeta de Crédito");

            // Muestra la fecha actual en el Label
            labelfecha.Text = "Fecha actual: " + DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar que se haya ingresado un monto
            if (string.IsNullOrWhiteSpace(txtMonto.Text))
            {
                MessageBox.Show("Por favor, ingrese el monto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que se haya seleccionado un tipo de pago
            if (PagosCB.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un tipo de pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el monto ingresado por el usuario
            decimal monto = decimal.Parse(txtMonto.Text);

            // Obtener el tipo de pago seleccionado por el usuario
            string tipoPago = PagosCB.SelectedItem.ToString();

            // Lógica para obtener el carnet desde la base de datos SQLite
            // Aquí deberías escribir el código para consultar la base de datos SQLite y obtener el carnet correspondiente

            // Ejemplo de código para obtener el carnet (a ser reemplazado con la lógica real)
            // string carnet = ObtenerCarnetDesdeSQLite();

            // Mostrar un mensaje con los detalles del pago
            MessageBox.Show($"Monto: {monto}\nTipo de Pago: {tipoPago}\nCarnet: [Carnet obtenido de la base de datos]",
                            "Detalles del Pago", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Restablecer los controles para permitir nuevos pagos
            txtMonto.Clear();
            PagosCB.SelectedIndex = -1; // Desseleccionar el ComboBox
        }

        // Método para obtener el carnet desde la base de datos SQLite (a ser implementado)
        // private string ObtenerCarnetDesdeSQLite()
        // {
        //     // Implementa la lógica para obtener el carnet desde la base de datos SQLite aquí
        //     // Retorna el carnet obtenido
        // }
    }
}
