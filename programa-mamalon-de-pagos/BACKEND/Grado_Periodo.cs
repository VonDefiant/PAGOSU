using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace programa_mamalon_de_pagos.BACKEND
{
    public class Grado_Periodo
    {
        public int Grado {  get; set; }
        public string Periodo { get; set; }

        public Grado_Periodo(int grado, string periodo) 
        {
            Grado = grado;
            Periodo = periodo;
        }
    }
}
