using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_mamalon_de_pagos.BACKEND
{
    public class Curso
    {
        // Propiedades
        public int IDCurso { get; set; }
        public string NombreCurso { get; set; }
        public string Descripcion { get; set; }

        // Constructor
        public Curso(int idCurso, string nombreCurso, string descripcion)
        {
            IDCurso = idCurso;
            NombreCurso = nombreCurso;
            Descripcion = descripcion;
        }

        // Método para actualizar información
        public void ActualizarInformacion(string nuevoNombre, string nuevaDescripcion)
        {
            NombreCurso = nuevoNombre;
            Descripcion = nuevaDescripcion;
        }
    }
}
