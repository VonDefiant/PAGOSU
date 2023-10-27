using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_mamalon_de_pagos.BACKEND
{
    public class Institucion
    {
        public int IdInstitucion { get; set; }
        public string? Nombre { get; set; }

        public Institucion(int idInstitucion, string nombre)
        {
            IdInstitucion = idInstitucion;
            Nombre = nombre;
        }
    }
}
