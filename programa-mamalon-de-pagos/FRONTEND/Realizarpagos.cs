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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

                // Validar que se haya ingresado un carnet
                if (string.IsNullOrWhiteSpace(txtcarnet.Text))
                {
                    MessageBox.Show("Por favor, ingrese un carnet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                }

                // Obtener el carnet ingresado por el usuario
                string carnet = txtcarnet.Text;

                // Verificar si el carnet existe en la base de datos
                if (!VerificarCarnetExistente(carnet))
                {
                    MessageBox.Show("El carnet no existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DateTime fecha = dateTimePicker1.Value;

                string gradoPeriodo = cmperiodo.SelectedItem as string;

                // Insertar los datos en la base de datos SQLite
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string insertDataQuery = "INSERT INTO Pagos (Monto, TipoPago, NumeroCuenta, Carnet, Fecha, GradosPeriodos) " +
                                              "VALUES (@Monto, @TipoPago, @NumeroCuenta, @Carnet, @Fecha, @GradosPeriodos);";


                    using (SQLiteCommand command = new SQLiteCommand(insertDataQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Monto", monto);
                        command.Parameters.AddWithValue("@TipoPago", tipoPago);
                        command.Parameters.AddWithValue("@NumeroCuenta", numeroCuenta);
                        command.Parameters.AddWithValue("@Carnet", carnet);
                        command.Parameters.AddWithValue("@Fecha", fecha.ToString("dd-MM-yyyy"));
                        command.Parameters.AddWithValue("@GradosPeriodos", gradoPeriodo);


                        command.ExecuteNonQuery();
                    }
                }

                // Mostrar un mensaje de éxito
                MessageBox.Show("Datos guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Restablecer los controles para permitir nuevos pagos
                txtMonto.Clear();
                txtNumeroCuenta.Clear();
                PagosCB.SelectedIndex = -1; // Desseleccionar el ComboBox
                txtcarnet.Clear();
                cmperiodo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que ocurra durante el proceso
                MessageBox.Show("Error al guardar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    // Devolver true si el carnet existe en la base de datos, de lo contrario, devolver false
                    return count > 0;
                }
            }
        }

        private void txtcarnet_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmperiodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmperiodo.SelectedIndex >= 0)
            {
                string gradoPeriodoSeleccionado = cmperiodo.SelectedItem.ToString();


            }
            else
            {
                MessageBox.Show("Por favor, selecciona un periodo válida.");
            }
        }
        private void CargarPeriodosEnComboBox()
        {
            try
            {

                string connectionString = "Data Source = BACKEND/EXACTUS.db; Version = 3; ";
                string selectQuery = "SELECT Nombre FROM GradosPeriodos";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(selectQuery, connection))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmperiodo.Items.Add(reader["Nombre"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los Periodos: " + ex.Message);
            }
        }

        private void Realizarpagos_Load(object sender, EventArgs e)
        {
            CargarPeriodosEnComboBox();
        }
    }
}
