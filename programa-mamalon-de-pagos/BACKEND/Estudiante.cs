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
        // Propiedades(Puede que falte alguna, pero estas serian las mas importantes)
        public int Carnet { get; set; }
        public string NombreCompleto { get; set; }

        public string CarreraGrado { get; set; }
        public string Seccion { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public string Institucion { get; set; }
        public string Facultad { get; set; }
        public string Jornada { get; set; }


        // Constructor
        public Estudiante(int carnet, string nombrecompleto, string carreragrado, string seccion, string correoElectronico, string telefono, string institucion, string facultad, string jornada)
        {
            Carnet = carnet;
            NombreCompleto = nombrecompleto;
            CarreraGrado = carreragrado;
            Seccion = seccion;
            CorreoElectronico = correoElectronico;
            Telefono = telefono;
            Institucion = institucion;
            Facultad = facultad;
            Jornada = jornada;  
        }
        public void InsertarEstudiante()
        {
            string connectionString = "Data Source = BACKEND/EXACTUS.db; Version = 3; ";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();


                string checkCarnetQuery = "SELECT COUNT(*) FROM Estudiantes WHERE Carnet = @Carnet;";
                using (SQLiteCommand checkCarnetCmd = new SQLiteCommand(checkCarnetQuery, connection))
                {
                    checkCarnetCmd.Parameters.AddWithValue("@Carnet", Carnet);
                    int count = Convert.ToInt32(checkCarnetCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        throw new Exception("El carnet ya existe en la base de datos.");
                    }
                }

                string formattedCarnet = $"{Carnet / 1000000:0000}-{(Carnet / 10000) % 100:00}-{Carnet % 10000:0000}";

                string insertQuery = "INSERT INTO Estudiantes (Carnet, NombreCompleto, CarreraGrado, Seccion, CorreoElectronico, Telefono, Institucion, Facultad, Jornada) " +
                                    "VALUES (@Carnet, @NombreCompleto, @CarreraGrado, @Seccion, @CorreoElectronico, @Telefono, @Institucion, @Facultad, @Jornada);";

                using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Carnet", formattedCarnet);
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
