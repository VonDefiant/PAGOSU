using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using static System.Collections.Specialized.BitVector32;

namespace programa_mamalon_de_pagos.BACKEND
{
    public class Grado_Periodo
    {
        public int IDGradoPeriodo {  get; set; }
        public int Grado {  get; set; }
        public string Periodo { get; set; }

        public Grado_Periodo(int grado, string periodo) 
        {
            Grado = grado;
            Periodo = periodo;
        }
        //Método para conexion db
        public void InsertarEstudiante()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=BACKEND/EXACTUS.db;Version=3;"))
            {
                connection.Open();

                string queryLastIDGradoPeriodo = "SELECT MAX(IDGradoPeriodo) FROM Grado_Periodo;";
                using (SQLiteCommand cmdLastIDGradoPeriodo = new SQLiteCommand(queryLastIDGradoPeriodo, connection))
                {
                    var result = cmdLastIDGradoPeriodo.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        IDGradoPeriodo = Convert.ToInt32(result) + 1;
                    }
                    else
                    {
                        IDGradoPeriodo = 1;
                    }
                }

                string insertQuery = "INSERT INTO Estudiantes (Carnet, NombreCompleto, CarreraGrado, Seccion, CorreoElectronico, Telefono, Institucion, Facultad, Jornada) " +
                                    "VALUES (@Carnet, @NombreCompleto, @CarreraGrado, @Seccion, @CorreoElectronico, @Telefono, @Institucion, @Facultad, @Jornada);";

                using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Carnet", IDGradoPeriodo);
                    cmd.Parameters.AddWithValue("@NombreCompleto", Grado);
                    cmd.Parameters.AddWithValue("@CarreraGrado", Periodo);
                    
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Metodo para actualizar la info
        public void ActualizarEstudiante()
        {
            string connectionString = "Data Source = BACKEND/EXACTUS.db; Version = 3; ";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE Estudiantes SET NombreCompleto = @NombreCompleto, CarreraGrado = @CarreraGrado, Seccion = @Seccion, " +
                                    "CorreoElectronico = @CorreoElectronico, Telefono = @Telefono, Institucion = @Institucion, Facultad = @Facultad, Jornada = @Jornada " +
                                    "WHERE Carnet = @Carnet;";

                using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Carnet", IDGradoPeriodo);
                    cmd.Parameters.AddWithValue("@NombreCompleto", Grado);
                    cmd.Parameters.AddWithValue("@CarreraGrado", Periodo);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Método para eliminar
        public void EliminarEstudiante()
        {
            string connectionString = "Data Source = BACKEND/EXACTUS.db; Version = 3; ";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM Estudiantes WHERE Carnet = @Carnet;";

                using (SQLiteCommand cmd = new SQLiteCommand(deleteQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Carnet", IDGradoPeriodo);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
