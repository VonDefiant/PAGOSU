using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace programa_mamalon_de_pagos.BACKEND
{
    public class Profesor
    {
        // Propiedades
        public int IDProfesor { get; set; }
        public string NombreCompleto { get; set; }
        public string Direccion { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public List<string> Asignaturas { get; set; }

        // Constructor
        public Profesor(string nombreCompleto, string direccion, string correoElectronico, string telefono)
        {
            NombreCompleto = nombreCompleto;
            Direccion = direccion;
            CorreoElectronico = correoElectronico;
            Telefono = telefono;
            Asignaturas = new List<string>();
        }

        // Método para asignar una nueva asignatura al profesor
        public void AsignarAsignatura(string asignatura)
        {
            Asignaturas.Add(asignatura);
        }

        // Método para obtener la lista de asignaturas del profesor
        public List<string> ObtenerAsignaturas()
        {
            return Asignaturas;
        }

        // Método para insertar un profesor en la base de datos
        public void InsertarDocente()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=BACKEND/EXACTUS.db;Version=3;"))
            {
                connection.Open();

                string queryLastIDProfesor = "SELECT MAX(IDProfesor) FROM Docentes;";
                using (SQLiteCommand cmdLastIDProfesor = new SQLiteCommand(queryLastIDProfesor, connection))
                {
                    var result = cmdLastIDProfesor.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        IDProfesor = Convert.ToInt32(result) + 1;
                    }
                    else
                    {
                        IDProfesor = 1;
                    }
                }

                string insertQuery = "INSERT INTO Docentes (IDProfesor, NombreCompleto, Direccion, CorreoElectronico, Telefono, Asignaturas) " +
                                    "VALUES (@IDProfesor, @NombreCompleto, @Direccion, @CorreoElectronico, @Telefono, @Asignaturas);";

                using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@IDProfesor", IDProfesor);
                    cmd.Parameters.AddWithValue("@NombreCompleto", NombreCompleto);
                    cmd.Parameters.AddWithValue("@Direccion", Direccion);
                    cmd.Parameters.AddWithValue("@CorreoElectronico", CorreoElectronico);
                    cmd.Parameters.AddWithValue("@Telefono", Telefono);
                    cmd.Parameters.AddWithValue("@Asignaturas", string.Join(",", Asignaturas));

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para actualizar la información de un profesor en la base de datos
        public void ActualizarDocente()
        {
            string connectionString = "Data Source=BACKEND/EXACTUS.db;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE Docentes SET NombreCompleto = @NombreCompleto, Direccion = @Direccion, CorreoElectronico = @CorreoElectronico, " +
                                    "Telefono = @Telefono, Asignaturas = @Asignaturas " +
                                    "WHERE IDProfesor = @IDProfesor;";

                using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@IDProfesor", IDProfesor);
                    cmd.Parameters.AddWithValue("@NombreCompleto", NombreCompleto);
                    cmd.Parameters.AddWithValue("@Direccion", Direccion);
                    cmd.Parameters.AddWithValue("@CorreoElectronico", CorreoElectronico);
                    cmd.Parameters.AddWithValue("@Telefono", Telefono);
                    cmd.Parameters.AddWithValue("@Asignaturas", string.Join(",", Asignaturas));

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para eliminar un profesor de la base de datos
        public void EliminarDocente()
        {
            string connectionString = "Data Source=BACKEND/EXACTUS.db;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM Docentes WHERE IDProfesor = @IDProfesor;";

                using (SQLiteCommand cmd = new SQLiteCommand(deleteQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@IDProfesor", IDProfesor);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
