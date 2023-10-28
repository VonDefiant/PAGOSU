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
using System.Data.SQLite;

namespace programa_mamalon_de_pagos.FRONTEND
{
    public partial class Realizarpagos : Form
    {
        // Cadena de conexión a la base de datos SQLite
        private string connectionString = "Data Source=BACKEND/EXACTUS.db;Version=3;";

        // Constructor del formulario
        public Realizarpagos()
        {
            InitializeComponent();
        }

        // Evento de clic en el botón "Agregar"
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
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

                // Obtener el número de cuenta si se eligió "Transferencia"
                string numeroCuenta = null;
                if (tipoPago == "Transferencia" && !string.IsNullOrWhiteSpace(txtNumeroCuenta.Text))
                {
                    numeroCuenta = txtNumeroCuenta.Text;

                    // Obtener el carnet desde la base de datos SQLite
                    string carnet = ObtenerCarnetDesdeSQLite(numeroCuenta);
                    if (carnet == "Carnet no encontrado")
                    {
                        MessageBox.Show("Número de cuenta no asociado a ningún carnet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Puedes usar el valor de 'carnet' según tus necesidades
                }

                // Insertar los datos en la base de datos SQLite
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string insertDataQuery = "INSERT INTO Pagos (Monto, TipoPago, NumeroCuenta) VALUES (@Monto, @TipoPago, @NumeroCuenta);";

                    using (SQLiteCommand command = new SQLiteCommand(insertDataQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Monto", monto);
                        command.Parameters.AddWithValue("@TipoPago", tipoPago);
                        command.Parameters.AddWithValue("@NumeroCuenta", numeroCuenta);

                        command.ExecuteNonQuery();
                    }
                }

                // Mostrar un mensaje de éxito
                MessageBox.Show("Datos guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Restablecer los controles para permitir nuevos pagos
                txtMonto.Clear();
                txtNumeroCuenta.Clear();
                PagosCB.SelectedIndex = -1; // Desseleccionar el ComboBox
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que ocurra durante el proceso
                MessageBox.Show("Error al guardar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para obtener el carnet desde la base de datos SQLite
        private string ObtenerCarnetDesdeSQLite(string numeroCuenta)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string obtenerCarnetQuery = "SELECT Carnet FROM Estudiantes WHERE NumeroCuenta = @NumeroCuenta;";
                using (SQLiteCommand command = new SQLiteCommand(obtenerCarnetQuery, connection))
                {
                    command.Parameters.AddWithValue("@NumeroCuenta", numeroCuenta);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return result.ToString();
                    }
                    else
                    {
                        // Manejar el caso en el que el número de cuenta no está asociado a ningún carnet
                        return "Carnet no encontrado";
                    }
                }
            }
        }

        // Método para verificar si un carnet existe en la base de datos SQLite
        private bool VerificarCarnetExistente(string carnet)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string verificarCarnetQuery = "SELECT COUNT(*) FROM Estudiantes WHERE Carnet = @Carnet;";
                using (SQLiteCommand command = new SQLiteCommand(verificarCarnetQuery, connection))
                {
                    command.Parameters.AddWithValue("@Carnet", carnet);
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    // Si count es mayor que 0, significa que el carnet existe en la base de datos
                    return count > 0;
                }
            }
        }

        private void txtcarnet_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
