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
        public int Carnet { get; set; }
        public string NombreCompleto { get; set; }

        public string CarreraGrado { get; set; }
        public string Seccion { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public string Institucion { get; set; }
        public string Facultad { get; set; }
        public string Jornada { get; set; }


        // Constructor
        public Estudiante(int carnet, string nombrecompleto, string apellido, string carreragrado, string seccion, string correoElectronico, string telefono, string institucion, string facultad, string jornada)
        {
            Carnet = carnet;
            NombreCompleto = nombrecompleto;
            CarreraGrado = carreragrado;
            Seccion = seccion;
            CorreoElectronico = correoElectronico;
            Telefono = telefono;
            Institucion = institucion;
            Facultad = facultad;
            Jornada = jornada;  
        }

        // Método para retornar la info
        public string ObtenerInformacion()
        {
            return $"ID: {Carnet}, Nombre: {NombreCompleto},Carrera o grado:{CarreraGrado} ,Seccion: {Seccion}, Correo Electrónico: {CorreoElectronico}, Teléfono: {Telefono}, Institución: {Institucion}, Facultad: {Facultad}, Jornada: {Jornada}";
        }

        //Metodo para actualizar la info
        public void ActualizarInformacion(string nuevonombrecompleto, string nuevaCarreraGrado, string nuevaSeccion, string nuevoCorreo, string nuevoTelefono, string nuevainstitucion, string nuevafacultad,string nuevajornada)
        {
            NombreCompleto = nuevonombrecompleto;
            CarreraGrado = nuevaCarreraGrado;
            Seccion = nuevaSeccion;
            CorreoElectronico = nuevoCorreo;
            Telefono = nuevoTelefono;
            Institucion = nuevainstitucion;
            Facultad = nuevajornada;
            Jornada = Jornada;
        }

        //Metodo para eliminar al estudiante(va relacionada con la base de datos)
        public void EliminarEstudiante()
        {
            // Implementa la lógica para eliminar un estudiante de la base de datos.
            // Eje: BaseDeDatos.EliminarEstudiante(IDEstudiante);
        }
    }




}
