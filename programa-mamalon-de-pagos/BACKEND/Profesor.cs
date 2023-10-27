using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

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
    }
}
