using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using static System.Collections.Specialized.BitVector32;

namespace programa_mamalon_de_pagos.BACKEND
{
    public class Usuarios
    {
        // Propiedades
        public int IDAdmin { get; set; }
        public string NombreCompleto { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }

        // Constructor
        public Usuarios(int idAdmin, string nombreCompleto, string apellido, string usuario, string contrasena)
        {
            IDAdmin = idAdmin;
            NombreCompleto = nombreCompleto;
            Usuario = usuario;
            Contrasena = contrasena;
        }

        //Método para conexion db
        public void InsertarUsuario()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=BACKEND/EXACTUS.db;Version=3;"))
            {
                connection.Open();

                string queryLastIDAdmin = "SELECT MAX(IDAdmin) FROM Estudiantes;";
                using (SQLiteCommand cmdLastIDAdmin = new SQLiteCommand(queryLastIDAdmin, connection))
                {
                    var result = cmdLastIDAdmin.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        IDAdmin = Convert.ToInt32(result) + 1;
                    }
                    else
                    {
                        IDAdmin = 1;
                    }
                }

                string insertQuery = "INSERT INTO Usuarios (IDAdmin, NombreCompleto, Usuario, Contrasena) " +
                                    "VALUES (@IDAdmin, @NombreCompleto, @Usuario, @Contrasena);";

                using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@IDAdmin", IDAdmin);
                    cmd.Parameters.AddWithValue("@NombreCompleto", NombreCompleto);
                    cmd.Parameters.AddWithValue("@CarreraGrado", Usuario);
                    cmd.Parameters.AddWithValue("@Seccion", Contrasena);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Metodo para actualizar la info
        public void ActualizarUsuario()
        {
            string connectionString = "Data Source = BACKEND/EXACTUS.db; Version = 3; ";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE Usuarios SET NombreCompleto = @NombreCompleto, Usuario = @Usuario, Contrasena= @Contrasena, " +
                                    "WHERE IDAdmin = @IDAdmin;";

                using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@IDAdmin", IDAdmin);
                    cmd.Parameters.AddWithValue("@NombreCompleto", NombreCompleto);
                    cmd.Parameters.AddWithValue("@CarreraGrado", Usuario);
                    cmd.Parameters.AddWithValue("@Seccion", Contrasena);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Método para eliminar
        public void EliminarUsuario()
        {
            string connectionString = "Data Source = BACKEND/EXACTUS.db; Version = 3; ";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM Usuarios WHERE IDAdmin = @IDAdmin;";

                using (SQLiteCommand cmd = new SQLiteCommand(deleteQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@IDAdmin", IDAdmin);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
