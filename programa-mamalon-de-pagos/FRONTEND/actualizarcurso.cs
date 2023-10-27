using programa_mamalon_de_pagos.BACKEND;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa_mamalon_de_pagos.FRONTEND
{
    public partial class actualizarcurso : Form
    {
        private Curso curso;

        public actualizarcurso()
        {
            InitializeComponent();
            curso = new Curso("", "");
        }
        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            // Obtener los nuevos valores desde los controles del formulario
            string nuevoNombre = txtNombreCurso.Text;
            string nuevaDescripcion = txtDescripcionCurso.Text;

            // Llamar al método ActualizarInformacion de la instancia de la clase Curso
            curso.ActualizarInformacion(nuevoNombre, nuevaDescripcion);

            // Actualizar los datos en la base de datos
            try
            {
                curso.ActualizarInformacionEnLaBaseDeDatos();
                MessageBox.Show("Información actualizada correctamente en la base de datos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los datos en la base de datos: " + ex.Message);
            }
        }


    }
}


