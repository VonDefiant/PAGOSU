using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace programa_mamalon_de_pagos
{
    public class Estudiante
    {
        // Propiedades
        public int Carnet { get; private set; }
        public string NombreCompleto { get; set; }
        public string CarreraGrado { get; set; }
        public string Seccion { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public string Institucion { get; set; }
        public string Facultad { get; set; }
        public string Jornada { get; set; }

        // Constructor
        public Estudiante(string nombrecompleto, string carreragrado, string seccion, string correoElectronico, string telefono, string institucion, string facultad, string jornada)
        {
            NombreCompleto = nombrecompleto;
            CarreraGrado = carreragrado;
            Seccion = seccion;
            CorreoElectronico = correoElectronico;
            Telefono = telefono;
            Institucion = institucion;
            Facultad = facultad;
            Jornada = jornada;
        }

        //Método para conexion db
        public void InsertarEstudiante()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=BACKEND/EXACTUS.db;Version=3;"))
            {
                connection.Open();

                string queryLastCarnet = "SELECT MAX(Carnet) FROM Estudiantes;";
                using (SQLiteCommand cmdLastCarnet = new SQLiteCommand(queryLastCarnet, connection))
                {
                    var result = cmdLastCarnet.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        Carnet = Convert.ToInt32(result) + 1;
                    }
                    else
                    {
                        Carnet = 1;
                    }
                }

                string insertQuery = "INSERT INTO Estudiantes (Carnet, NombreCompleto, CarreraGrado, Seccion, CorreoElectronico, Telefono, Institucion, Facultad, Jornada) " +
                                    "VALUES (@Carnet, @NombreCompleto, @CarreraGrado, @Seccion, @CorreoElectronico, @Telefono, @Institucion, @Facultad, @Jornada);";

                using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Carnet", Carnet);
                    cmd.Parameters.AddWithValue("@NombreCompleto", NombreCompleto);
                    cmd.Parameters.AddWithValue("@CarreraGrado", CarreraGrado);
                    cmd.Parameters.AddWithValue("@Seccion", Seccion);
                    cmd.Parameters.AddWithValue("@CorreoElectronico", CorreoElectronico);
                    cmd.Parameters.AddWithValue("@Telefono", Telefono);
                    cmd.Parameters.AddWithValue("@Institucion", Institucion);
                    cmd.Parameters.AddWithValue("@Facultad", Facultad);
                    cmd.Parameters.AddWithValue("@Jornada", Jornada);

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
                    cmd.Parameters.AddWithValue("@Carnet", Carnet);
                    cmd.Parameters.AddWithValue("@NombreCompleto", NombreCompleto);
                    cmd.Parameters.AddWithValue("@CarreraGrado", CarreraGrado);
                    cmd.Parameters.AddWithValue("@Seccion", Seccion);
                    cmd.Parameters.AddWithValue("@CorreoElectronico", CorreoElectronico);
                    cmd.Parameters.AddWithValue("@Telefono", Telefono);
                    cmd.Parameters.AddWithValue("@Institucion", Institucion);
                    cmd.Parameters.AddWithValue("@Facultad", Facultad);
                    cmd.Parameters.AddWithValue("@Jornada", Jornada);

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
                    cmd.Parameters.AddWithValue("@Carnet", Carnet);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
