using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using System.Data.SQLite;

namespace programa_mamalon_de_pagos.BACKEND
{
    public class Curso
    {
        // Propiedades
        public int IDCurso { get; set; }
        public string NombreCurso { get; set; }
        public string Facultad { get; set; }

        // Constructor
        public Curso( string nombreCurso, string facultad)
        {

            NombreCurso = nombreCurso;
            Facultad = facultad;
        }
        public void InsertarCurso()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=BACKEND/EXACTUS.db;Version=3;"))
            {
                connection.Open();

                string queryLastIDCurso = "SELECT MAX(IDCurso) FROM Cursos;";
                using (SQLiteCommand cmdLastIDCurso = new SQLiteCommand(queryLastIDCurso, connection))
                {
                    var result = cmdLastIDCurso.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        IDCurso = Convert.ToInt32(result) + 1;
                    }
                    else
                    {
                        IDCurso = 1;
                    }
                }

                string insertQuery = "INSERT INTO Cursos (IDCurso, NombreCurso, Facultad) " +
                                    "VALUES (@IDCurso, @NombreCurso, @Facultad);";

                using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@IDCurso", IDCurso);
                    cmd.Parameters.AddWithValue("@NombreCurso", NombreCurso);
                    cmd.Parameters.AddWithValue("@Facultad", Facultad);


                    cmd.ExecuteNonQuery();
                }
            }
        }
        // Método para actualizar información
        public void ActualizarInformacion(string nuevoNombre, string nuevaFacultad)
        {
            NombreCurso = nuevoNombre;
            Facultad = nuevaFacultad;
        }
        public void EliminarCurso(int IDCurso)
        {
            string connectionString = "Data Source = BACKEND/EXACTUS.db; Version = 3; ";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM Cursos WHERE IDCurso = @IDCurso;";

                using (SQLiteCommand cmd = new SQLiteCommand(deleteQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@IDCurso", IDCurso);
                    cmd.ExecuteNonQuery();
                }
            }
        }


    }

}

