using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_mamalon_de_pagos.BACKEND
{
    public class Pagos
    {
        public string? IdPago { get; set; }
        public DateTime Fecha {  get; set; }
        public int Carnet {  get; set; }
        public decimal Monto { get; set; }
        public Grado_Periodo GradoPeriodo { get; set;}

        public Pagos(string idPago, DateTime fecha, int carnet, decimal monto, Grado_Periodo gradoperiodo) 
        {
            IdPago = idPago;
            Fecha = fecha;
            Carnet = carnet;
            Monto = monto;
            GradoPeriodo = gradoperiodo;
        }
    }
}
