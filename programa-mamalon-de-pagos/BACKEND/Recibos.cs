using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using static System.Collections.Specialized.BitVector32;

namespace programa_mamalon_de_pagos.BACKEND
{
    public class Recibos
    {
        public int IdRecibo {  get; set; }
        public string Nombre { get; set; }
        public int Carnet { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }

        public Recibos(int idRecibo, string nombre, int carnet, DateTime fecha, string descripcion) 
        {
            IdRecibo = idRecibo;
            Nombre = nombre;
            Carnet = carnet;
            Fecha = fecha;
            Descripcion = descripcion;
        }
        //Método para conexion db
        public void InsertarRecibo()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=BACKEND/EXACTUS.db;Version=3;"))
            {
                connection.Open();

                string queryLastIdRecibo = "SELECT MAX(IdRecibo) FROM Recibos;";
                using (SQLiteCommand cmdLastIdRecibo = new SQLiteCommand(queryLastIdRecibo, connection))
                {
                    var result = cmdLastIdRecibo.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        IdRecibo = Convert.ToInt32(result) + 1;
                    }
                    else
                    {
                        IdRecibo = 1;
                    }
                }

                string insertQuery = "INSERT INTO Estudiantes (IdRecibo, Nombre, Carnet, Fecha, Descripcion) " +
                                    "VALUES (@IdRecibo, @Nombre, @Carnet, @Fecha, @Descripcion);";

                using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Carnet", IdRecibo);
                    cmd.Parameters.AddWithValue("@Nombre", Nombre);
                    cmd.Parameters.AddWithValue("@Carnet", Carnet);
                    cmd.Parameters.AddWithValue("@Fecha", Fecha);
                    cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
                    
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Metodo para actualizar la info
        public void ActualizarRecibo()
        {
            string connectionString = "Data Source = BACKEND/EXACTUS.db; Version = 3; ";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE Recibos SET Nombre = @Nombre, Carnet = @Carnet, Fecha = @Fecha, " +
                                    "Descripcion = @Descripcion+" +
                                    "WHERE IdRecibo= @IdRecibo;";

                using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Carnet", IdRecibo);
                    cmd.Parameters.AddWithValue("@Nombre", Nombre);
                    cmd.Parameters.AddWithValue("@Carnet", Carnet);
                    cmd.Parameters.AddWithValue("@Fecha", Fecha);
                    cmd.Parameters.AddWithValue("@Descripcion", Descripcion);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Método para eliminar
        public void EliminarRecibo()
        {
            string connectionString = "Data Source = BACKEND/EXACTUS.db; Version = 3; ";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM Recibos WHERE IdRecibo = @IdRecibo;";

                using (SQLiteCommand cmd = new SQLiteCommand(deleteQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@IdRecibo", IdRecibo);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
