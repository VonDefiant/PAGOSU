using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using static System.Collections.Specialized.BitVector32;

namespace programa_mamalon_de_pagos.BACKEND
{
    public class Pagos
    {
        public int IdPago { get; set; }
        public DateTime Fecha { get; set; }
        public int Carnet { get; set; }
        public decimal Monto { get; set; }
        public Grado_Periodo GradoPeriodo { get; set; }

        public Pagos(int idPago, DateTime fecha, int carnet, decimal monto, Grado_Periodo gradoperiodo)
        {
            IdPago = idPago;
            Fecha = fecha;
            Carnet = carnet;
            Monto = monto;
            GradoPeriodo = gradoperiodo;
        }
        //Método para conexion db
        public void InsertarPagos()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=BACKEND/EXACTUS.db;Version=3;"))
            {
                connection.Open();

                string queryLastIdPago = "SELECT MAX(IdPago) FROM Pagos;";
                using (SQLiteCommand cmdLastIdPago = new SQLiteCommand(queryLastIdPago, connection))
                {
                    var result = cmdLastIdPago.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        IdPago = Convert.ToInt32(result) + 1;
                    }
                    else
                    {
                        IdPago = 1;
                    }
                }

                string insertQuery = "INSERT INTO Pagos (IdPago, Fecha, Carnet, Monto, GradoPeriodo) " +
                                    "VALUES (@IdPago, @Fecha, @Carnet, @Monto, @GradoPeriodo);";

                using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@IdPago", IdPago);
                    cmd.Parameters.AddWithValue("@Fecha", Fecha);
                    cmd.Parameters.AddWithValue("@Carnet", Carnet);
                    cmd.Parameters.AddWithValue("@Monto", Monto);
                    cmd.Parameters.AddWithValue("@GradoPeriodo", GradoPeriodo);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Metodo para actualizar la info
        public void ActualizarPagos()
        {
            string connectionString = "Data Source = BACKEND/EXACTUS.db; Version = 3; ";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE Pagos SET Fecha = @Fecha, Carnet = @Carnet, Monto = @Monto, " +
                                    "GradoPeriodo = @GradoPeriodoW" +
                                    "WHERE IdPago = @IdPago;";

                using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@IdPago", IdPago);
                    cmd.Parameters.AddWithValue("@Fecha", Fecha);
                    cmd.Parameters.AddWithValue("@Carnet", Carnet);
                    cmd.Parameters.AddWithValue("@Monto", Monto);
                    cmd.Parameters.AddWithValue("@GradoPeriodo", GradoPeriodo);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Método para eliminar
        public void EliminarPago()
        {
            string connectionString = "Data Source = BACKEND/EXACTUS.db; Version = 3; ";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM Pagos WHERE IdPago = @IdPago;";

                using (SQLiteCommand cmd = new SQLiteCommand(deleteQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@IdPago", IdPago);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}