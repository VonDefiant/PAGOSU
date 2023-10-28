using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace programa_mamalon_de_pagos.BACKEND
{
    public class Facultades
    {
        // Propiedades
        public int IdFacultad { get; set; }
        public string Nombre { get; set; }

        // Constructor con dos argumentos
        public Facultades(int idFacultad, string nombre)
        {
            IdFacultad = idFacultad;
            Nombre = nombre;
        }

        public void InsertarFacultad()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=BACKEND/EXACTUS.db;Version=3;"))
            {
                connection.Open();

                string queryLastIdFacultad = "SELECT MAX(IDFacultad) FROM Facultades;";
                using (SQLiteCommand cmdLastIdInstitucion = new SQLiteCommand(queryLastIdFacultad, connection))
                {
                    var result = cmdLastIdInstitucion.ExecuteScalar();
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
    }
}
