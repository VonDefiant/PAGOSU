using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using static System.Collections.Specialized.BitVector32;

namespace programa_mamalon_de_pagos.BACKEND
{
    public class Carrera
    {
        public  int IdCarrera { get; set; }
        public string? NombreCarrera { get; set; }
        public string? Facultad { get; set; }

        public Carrera(int idCarrera, string? nombreCarrera, string? facultad)
        {
            IdCarrera = idCarrera;
            NombreCarrera = nombreCarrera;
            Facultad = facultad;
        }
        //Método para conexion db
        public void InsertarCarrera()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=BACKEND/EXACTUS.db;Version=3;"))
            {
                connection.Open();

                string queryLastIdCarrera = "SELECT MAX(IdCarrera) FROM Carrera;";
                using (SQLiteCommand cmdLastIdCarrera = new SQLiteCommand(queryLastIdCarrera, connection))
                {
                    var result = cmdLastIdCarrera.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        IdCarrera = Convert.ToInt32(result) + 1;
                    }
                    else
                    {
                        IdCarrera = 1;
                    }
                }

                string insertQuery = "INSERT INTO Carrera (IdCarrera, NombreCarrera, Facultad) " +
                                    "VALUES (@IdCarrera, @NombreCarrera, @Facultad);";

                using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@IdCarrera", IdCarrera);
                    cmd.Parameters.AddWithValue("@NombreCarrera", NombreCarrera);
                    cmd.Parameters.AddWithValue("@Facultad", Facultad);
                    
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Metodo para actualizar la info
        public void ActualizarCarrera()
        {
            string connectionString = "Data Source = BACKEND/EXACTUS.db; Version = 3; ";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE Carrera SET NombreCarrera = @NombreCarrera, Facultad = @Facultad " +
                                    "WHERE IdCarrera = @IdCarrera;";

                using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@IdCarrera", IdCarrera);
                    cmd.Parameters.AddWithValue("@NombreCarrera", NombreCarrera);
                    cmd.Parameters.AddWithValue("@Facultad", Facultad);
                    
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Método para eliminar
        public void EliminarCarrera()
        {
            string connectionString = "Data Source = BACKEND/EXACTUS.db; Version = 3; ";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM Carrera WHERE IdCarrera = @IdCarrera;";

                using (SQLiteCommand cmd = new SQLiteCommand(deleteQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@IdCarrera", IdCarrera);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
