using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_mamalon_de_pagos.BACKEND
{
    public class Usuarios
    {
        // Propiedades
        public int IDAdmin { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }

        // Constructor
        public Usuarios(int idAdmin, string nombre, string apellido, string usuario, string contrasena)
        {
            IDAdmin = idAdmin;
            Nombre = nombre;
            Apellido = apellido;
            Usuario = usuario;
            Contrasena = contrasena;
        }

        // Método para iniciar sesión
        public bool IniciarSesion(string usuario, string contrasena)
        {
            // Lógica para validar las credenciales del administrador
            return Usuario == usuario && Contrasena == contrasena;
        }

        // Método para gestionar cuentas de usuarios
        public void GestionarCuentas()
        {
            // Lógica para gestionar cuentas de usuarios (por ejemplo, crear, actualizar o eliminar cuentas de estudiantes, profesores, etc.)
            // ...
        }

        // Método para cambiar configuraciones del sistema
        public void CambiarConfiguracion(string nuevaConfiguracion)
        {
            // Lógica para cambiar configuraciones del sistema
            // ...
        }
    }
}
