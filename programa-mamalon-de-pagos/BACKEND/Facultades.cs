using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace programa_mamalon_de_pagos.BACKEND
{
    public class Facultades
    {
        //Propiedades
        public string? IdFacultad { get; set; }
        public string? Nombre { get; set; }
        public string? Institucion { get; set; }

        //Constructor
        public Facultades(string idFacultad, string nombre, string institucion)
        {
            IdFacultad = idFacultad;
            Nombre = nombre;
            Institucion = institucion;
        }
    }
}
