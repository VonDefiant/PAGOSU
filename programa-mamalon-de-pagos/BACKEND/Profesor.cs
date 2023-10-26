using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_mamalon_de_pagos.BACKEND
{
    public class Profesor
    {
        // Propiedades
        public int IDProfesor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public List<string> Asignaturas { get; set; }

        // Constructor
        public Profesor(int idProfesor, string nombre, string apellido, string direccion, string correoElectronico, string telefono)
        {
            IDProfesor = idProfesor;
            Nombre = nombre;
            Apellido = apellido;
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

        // Método para obtener información del profesor
        public string ObtenerInformacion()
        {
            return $"ID: {IDProfesor}, Nombre: {Nombre} {Apellido}, Dirección: {Direccion}, Correo Electrónico: {CorreoElectronico}, Teléfono: {Telefono}";
        }

        // Método para actualizar información del profesor
        public void ActualizarInformacion(string nuevoNombre, string nuevoApellido, string nuevaDireccion, string nuevoCorreo, string nuevoTelefono)
        {
            Nombre = nuevoNombre;
            Apellido = nuevoApellido;
            Direccion = nuevaDireccion;
            CorreoElectronico = nuevoCorreo;
            Telefono = nuevoTelefono;
        }

        // Método para eliminar al profesor (Este metodo va relacionado a la base de datos)
        public void EliminarProfesor()
        {
            // Implementa la lógica para eliminar un profesor de la base de datos.
            // Por ejemplo: BaseDeDatos.EliminarProfesor(IDProfesor);
        }
    }
}
