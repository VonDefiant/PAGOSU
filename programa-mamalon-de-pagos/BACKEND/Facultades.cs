using System.Data.SQLite;

namespace programa_mamalon_de_pagos.BACKEND
{
    public class Facultades
    {
        public int IdFacultad { get; set; }
        public string Nombre { get; set; }

        public Facultades(int idFacultad, string nombre)
        {
            IdFacultad = idFacultad;
            Nombre = nombre;
        }

        // Método para Insertar una Facultad
        public void InsertarFacultad()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=BACKEND/EXACTUS.db;Version=3;"))
            {
                connection.Open();

                string queryLastIdFacultad = "SELECT MAX(IDFacultad) FROM Facultades;";
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

                string insertQuery = "INSERT INTO Facultades (IDFacultad, Nombre) " +
                                    "VALUES (@IDFacultad, @Nombre);";

                using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@IDFacultad", IdFacultad);
                    cmd.Parameters.AddWithValue("@Nombre", Nombre);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para Actualizar una Facultad
        public void ActualizarFacultad()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=BACKEND/EXACTUS.db;Version=3;"))
            {
                connection.Open();

                string updateQuery = "UPDATE Facultades SET Nombre = @Nombre WHERE IDFacultad = @IDFacultad;";

                using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@IDFacultad", IdFacultad);
                    cmd.Parameters.AddWithValue("@Nombre", Nombre);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para Eliminar una Facultad
        public void EliminarFacultad()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=BACKEND/EXACTUS.db;Version=3;"))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM Facultades WHERE IDFacultad = @IDFacultad;";

                using (SQLiteCommand cmd = new SQLiteCommand(deleteQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@IDFacultad", IdFacultad);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
