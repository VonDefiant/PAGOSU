using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_mamalon_de_pagos
{
    public class Estudiante
    {
        // Propiedades(Puede que falte alguna, pero estas serian las mas importantes)
        public int IDEstudiante { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CarreraGrado { get; set; }
        public string Seccion { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }

        // Constructor
        public Estudiante(int idEstudiante, string nombre, string apellido, string carreragrado, string seccion, string correoElectronico, string telefono)
        {
            IDEstudiante = idEstudiante;
            Nombre = nombre;
            Apellido = apellido;
            CarreraGrado = carreragrado;
            Seccion = seccion;
            CorreoElectronico = correoElectronico;
            Telefono = telefono;
        }

        // Método para retornar la info
        public string ObtenerInformacion()
        {
            return $"ID: {IDEstudiante}, Nombre: {Nombre} {Apellido},Carrera o grado:{CarreraGrado} ,Seccion: {Seccion}, Correo Electrónico: {CorreoElectronico}, Teléfono: {Telefono}";
        }

        //Metodo para actualizar la info
        public void ActualizarInformacion(string nuevoNombre, string nuevoApellido, string nuevaCarreraGrado, string nuevaSeccion, string nuevoCorreo, string nuevoTelefono)
        {
            Nombre = nuevoNombre;
            Apellido = nuevoApellido;
            CarreraGrado = nuevaCarreraGrado;
            Seccion = nuevaSeccion;
            CorreoElectronico = nuevoCorreo;
            Telefono = nuevoTelefono;
        }

        //Metodo para eliminar al estudiante(va relacionada con la base de datos)
        public void EliminarEstudiante()
        {
            // Implementa la lógica para eliminar un estudiante de la base de datos.
            // Eje: BaseDeDatos.EliminarEstudiante(IDEstudiante);
        }
    }

}
