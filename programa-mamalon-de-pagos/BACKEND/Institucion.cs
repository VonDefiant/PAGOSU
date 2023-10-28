using System;
using System.Data.SQLite;

namespace programa_mamalon_de_pagos.BACKEND
{
    public class Institucion
    {
        public int IdInstitucion { get; set; }
        public string Nombre { get; set; }

        public Institucion(int idInstitucion, string nombre)
        {
            IdInstitucion = idInstitucion;
            Nombre = nombre;
        }

        public void InsertarInstitucion()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=BACKEND/EXACTUS.db;Version=3;"))
            {
                connection.Open();

                string queryLastIdInstitucion = "SELECT MAX(IdInstitucion) FROM Instituciones;";
                using (SQLiteCommand cmdLastIdInstitucion = new SQLiteCommand(queryLastIdInstitucion, connection))
                {
                    var result = cmdLastIdInstitucion.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        IdInstitucion = Convert.ToInt32(result) + 1;
                    }
                    else
                    {
                        IdInstitucion = 1;
                    }
                }

                string insertQuery = "INSERT INTO Instituciones (IdInstitucion, Nombre) " +
                                    "VALUES (@IdInstitucion, @Nombre);";

                using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@IdInstitucion", IdInstitucion);
                    cmd.Parameters.AddWithValue("@Nombre", Nombre);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarInstitucion()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=BACKEND/EXACTUS.db;Version=3;"))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM Instituciones WHERE IdInstitucion = @IdInstitucion;";

                using (SQLiteCommand cmd = new SQLiteCommand(deleteQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@IdInstitucion", IdInstitucion);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarInstitucion()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=BACKEND/EXACTUS.db;Version=3;"))
            {
                connection.Open();

                string updateQuery = "UPDATE Instituciones SET Nombre = @Nombre WHERE IdInstitucion = @IdInstitucion;";

                using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@IdInstitucion", IdInstitucion);
                    cmd.Parameters.AddWithValue("@Nombre", Nombre);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
