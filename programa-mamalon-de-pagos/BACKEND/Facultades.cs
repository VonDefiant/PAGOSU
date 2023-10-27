using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using static System.Collections.Specialized.BitVector32;

namespace programa_mamalon_de_pagos.BACKEND
{
    public class Facultades
    {
        //Propiedades
        public int IdFacultad { get; set; }
        public string? Nombre { get; set; }
        public string? Institucion { get; set; }

        //Constructor
        public Facultades(int idFacultad, string nombre, string institucion)
        {
            IdFacultad = idFacultad;
            Nombre = nombre;
            Institucion = institucion;
        }
        //Método para conexion db
        public void InsertarFacultad()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=BACKEND/EXACTUS.db;Version=3;"))
            {
                connection.Open();

                string queryLastIdFacultad = "SELECT MAX(IdFacultad) FROM Facultades;";
                using (SQLiteCommand cmdLastIdFacultad = new SQLiteCommand(queryLastIdFacultad, connection))
                {
                    var result = cmdLastIdFacultad.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        IdFacultad = Convert.ToInt32(result) + 1;
                    }
                    else
                    {
                        IdFacultad = 1;
                    }
                }

                string insertQuery = "INSERT INTO Facultades (IdFacultad, Nombre, Institucion) " +
                                    "VALUES (@IdFacultad, @Nombre @Institucion);";

                using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@IdFacultad", IdFacultad);
                    cmd.Parameters.AddWithValue("@Nombre", Nombre);
                    cmd.Parameters.AddWithValue("@Institucion", Institucion);
                    
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Metodo para actualizar la info
        public void ActualizarFacultad()
        {
            string connectionString = "Data Source = BACKEND/EXACTUS.db; Version = 3; ";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE Facultades SET Nombre = @Nombre, Institucion = @Institucion " +
                                    "WHERE IdFacultad = @IdFacultad;";

                using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@IdFacultad", IdFacultad);
                    cmd.Parameters.AddWithValue("@Nombre", Nombre);
                    cmd.Parameters.AddWithValue("@Institucion", Institucion);
                    
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Método para eliminar
        public void EliminarFacultad()
        {
            string connectionString = "Data Source = BACKEND/EXACTUS.db; Version = 3; ";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM Facultades WHERE IdFacultad = @IdFacultad;";

                using (SQLiteCommand cmd = new SQLiteCommand(deleteQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@IdFacultad", IdFacultad);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
