using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_mamalon_de_pagos.BACKEND
{
    public class Recibos
    {
        public int IdRecibo {  get; set; }
        public string Nombre { get; set; }
        public int Carnet { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }

        public Recibos(int idRecibo, string nombre, int carnet, DateTime fecha, string descripcion) 
        {
            IdRecibo = idRecibo;
            Nombre = nombre;
            Carnet = carnet;
            Fecha = fecha;
            Descripcion = descripcion;
        }
    }
}
